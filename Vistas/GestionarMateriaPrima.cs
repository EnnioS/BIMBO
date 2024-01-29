using Presentacion.Utilities;
using Negocio.Utilities.Validaciones;
using EnvDTE;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualStudio.TextManager.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Provider;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Entities.Data;
using Entities.Entities;
using Entities.DTO;

namespace Presentacion.Vistas
{
    public partial class GestionarMateriaPrima : Form
    {
        string productCode = "";

        private static ErrorProvider errorProducto = new ErrorProvider();
        private static ErrorProvider errorDescripcion = new ErrorProvider();
        private static ErrorProvider errorTara = new ErrorProvider();
        private static ErrorProvider errorNeto = new ErrorProvider();
        private static ErrorProvider errorPrecio = new ErrorProvider();
        private static ErrorProvider errorProv = new ErrorProvider();

        List<ProviderDTO> providers = new List<ProviderDTO>();
        List<ProductDTO> products = new List<ProductDTO>();

        public GestionarMateriaPrima()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            mainMenuForm p = (mainMenuForm)this.MdiParent;
            Control[] c = p.Controls.Find("mcMainBtnContainer", true);
            MaterialCard b = (MaterialCard)c[0];
            b.Visible = true;
            Close();
        }

        private void GestionarMateriaPrima_Load(object sender, EventArgs e)
        {
            FillComboBox.LlenarComboBoxProveedores(proveedoresDropDown, providers);
            FillComboBox.LlenarComboBoxProductos(ccbProducto, products);
            this.LlenarListViewMateriaPrima();
        }



        private void proveedoresDropDown_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = proveedoresDropDown.SelectedIndex;//Seleccionanod la posición (index) del elemento seleccionado en el combobox
            var idProvSelected = providers[selectedIndex].Id; //obteniendo ID proveedor por el index
            this.FillListViewMateriaPrimaTop(idProvSelected);
        }

        private void FillListViewMateriaPrimaTop(string idProvSelected)
        {
            try
            {
                //Instanciando Conexión a la BD
                BimDb1Context _db1 = new BimDb1Context();




                //Consulta de mucho a muchos inner right
                var listRawMaterial = _db1.Rawmaterials.Where(rm => rm.ProvidersRawmaterials.Any(j => j.ProviderId == idProvSelected)).ToList();

                var materialCount = listRawMaterial.Count();// contando cantidad de registro en tabla usuario

                listViewMateriaPrimaTop.Items.Clear();//Limpia los datos de la lista

                for (var i = 0; i < materialCount; i++)
                {
                    ListViewItem materiaPrimaItem = new ListViewItem(listRawMaterial[i].Id.ToString());
                    //Agregando datos a la lista
                    materiaPrimaItem.SubItems.Add(listRawMaterial[i].Description.ToString());
                    if (listRawMaterial[i].Active == true)
                    {
                        materiaPrimaItem.SubItems.Add("Activo");
                    }
                    else
                    {
                        materiaPrimaItem.SubItems.Add("Inactivo");
                    }

                    //Agregando lista al componente listview
                    listViewMateriaPrimaTop.Items.Add(materiaPrimaItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema MPF-001: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {

            var productoId = ccbProducto.Texts.Trim();
            var descripcion = txtDescripcion.Texts.Trim();
           
            if(ValidarTxt.IsDouble(txtTara.Texts) && ValidarTxt.IsDouble(txtNeto.Texts) && ValidarTxt.IsDouble(txtPrecio.Texts))
            {
                var tara = decimal.Parse(txtTara.Texts.Trim());
                var neto = decimal.Parse(txtNeto.Texts.Trim());
                var precio = decimal.Parse(txtPrecio.Texts.Trim());
           

                ProvidersRawmaterial providersRawmaterial = new ProvidersRawmaterial();
                Rawmaterial rawMaterial = new Rawmaterial();


                var providerCode = "";
                var productCode = "";

                try
                {

                    using (var _db1 = new BimDb1Context())
                    {

                        var providerText = proveedoresDropDown.Texts.Trim().Split(" - ");
                        providerCode = providerText[0];

                        if (proveedoresDropDown_Validating(providerCode))//valida si Si existe proveedor y ejecuta lo que se encuentra dentro la condición
                        {

                            if (ccbProducto_vacio_Validating() && txtDescripcion_Validating() && txtTara_Validating() && txtNeto_Validating() && txtPrecio_Validating())
                            {
                                var productText = ccbProducto.Texts.Trim().Split(" - ");
                                productCode = productText[0];

                                if (ccbProducto_Validating(productCode) && ccbProducto_Validating_Relationship_Provider(providerCode, productCode))
                                {
                                    //Actualiza datos de tabla producto ya que producto existe en tabla productos y existe la relación con el proveedor seleccionado
                                    var prodUpdate = _db1.Rawmaterials.Find(productCode);
                                    prodUpdate.Description = descripcion.Trim();
                                    prodUpdate.Tara = tara;
                                    prodUpdate.NetWeight = neto;
                                    prodUpdate.PricePerKg = precio;
                                    _db1.SaveChanges();


                                    listViewMateriaPrimaTop.Items.Clear();
                                    this.FillListViewMateriaPrimaTop(providerCode);
                                    this.clear();
                                    products.Clear();

                                    FillComboBox.LlenarComboBoxProductos(ccbProducto, products);

                                    this.LlenarListViewMateriaPrima();

                                    MessageBox.Show("Producto Actualizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else if (ccbProducto_Validating(productCode) && !ccbProducto_Validating_Relationship_Provider(providerCode, productCode))
                                {

                                    //Crea relacion guardado código en tabal pivote ProviderRawmaterial
                                    providersRawmaterial.ProviderId = providerCode;
                                    providersRawmaterial.RawmaterialId = productCode;
                                    _db1.ProvidersRawmaterials.Add(providersRawmaterial);

                                    //Actualiza datos de tabla producto ya que producto existe en tabla productos y existe la relación con el proveedor seleccionado
                                    var prodUpdate = _db1.Rawmaterials.Find(productCode);
                                    prodUpdate.Description = descripcion.Trim();
                                    prodUpdate.Tara = tara;
                                    prodUpdate.NetWeight = neto;
                                    prodUpdate.PricePerKg = precio;


                                    _db1.SaveChanges();

                                    listViewMateriaPrimaTop.Items.Clear();
                                    this.FillListViewMateriaPrimaTop(providerCode);
                                    this.clear();
                                    products.Clear();

                                    FillComboBox.LlenarComboBoxProductos(ccbProducto, products);

                                    this.LlenarListViewMateriaPrima();

                                    MessageBox.Show("Producto Agregado al Proveedor Exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else if (!ccbProducto_Validating(productCode))//valida si Si existe producto y ejecuta lo que se encuentra dentro la condición
                                {
                                    //Agregar nuevo producto a la tabla producto y crea relacionado con el proveedor


                                    rawMaterial.Id = productoId.Trim();
                                    rawMaterial.Description = descripcion.Trim();

                                    rawMaterial.Description = descripcion.Trim();
                                    rawMaterial.Tara = tara;
                                    rawMaterial.NetWeight = neto;
                                    rawMaterial.PricePerKg = precio;
                                    providersRawmaterial.ProviderId = providerCode;

                                    providersRawmaterial.Rawmaterial = rawMaterial;
                                    _db1.ProvidersRawmaterials.Add(providersRawmaterial);
                                    _db1.SaveChanges();


                                    listViewMateriaPrimaTop.Items.Clear();
                                    this.clear();
                                    products.Clear();

                                    FillComboBox.LlenarComboBoxProductos(ccbProducto, products);
                                    this.FillListViewMateriaPrimaTop(providerCode);
                                    this.LlenarListViewMateriaPrima();
                                    MessageBox.Show("Producto Creado y Agregado al proveedor Exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                            else
                            {
                                MessageBox.Show("Uno o más campos se encuentran vacios, o el dato ingresado no corresponde al campo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        else
                        {
                            MessageBox.Show("El campo proveedor se encuentra vacio o no es valido, seleccione un proveedor de la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        /*}
                        else
                        {
                            MessageBox.Show("el dato ingresado en el campo Proveedor no existe, debe seleccionar un proveedor de la lista", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }*/
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error del sistema RMF-001: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Los datos numéricos no deben contener letras, solo numeros con decimales, ej: 112.3222223333", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void clear()
        {
            ccbProducto.Texts = txtDescripcion.Texts = txtTara.Texts = txtNeto.Texts = txtPrecio.Texts = "";
        }

        private void ccbProducto_Leave(object sender, EventArgs e)
        {
            //validar si existe codigo Producto
            var selectedProdIndex = ccbProducto.SelectedIndex;
            var productCode = products[selectedProdIndex].Id;

            ccbProducto_Validating(productCode);
        }
        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            txtDescripcion_Validating();
        }
        private void txtTara_Leave(object sender, EventArgs e)
        {
            txtTara_Validating();
        }
        private void txtNeto_Leave(object sender, EventArgs e)
        {
            txtNeto_Validating();
        }
        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            txtPrecio_Validating();
        }


        private void listViewMateriaPrima_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {

                if (listViewMateriaPrima.SelectedIndices.Count <= 0)
                {
                    return;
                }
                int intselectedindex = listViewMateriaPrima.SelectedIndices[0];
                if (intselectedindex >= 0)
                {

                    /*proveedoresDropDown.Enabled = false;
                    ccbProducto.Enabled = false;*/


                    var prodCode = "";
                    var provedName = "";

                    prodCode = listViewMateriaPrima.SelectedItems[0].SubItems[0].Text;
                    provedName = listViewMateriaPrima.SelectedItems[0].SubItems[2].Text;


                    using (BimDb1Context _db1 = new BimDb1Context())
                    {
                        var prodDetail = _db1.Rawmaterials.Where(u => u.Id == prodCode).ToList();
                        var provCode = _db1.Providers.Where(u => u.Name == provedName).Select(s => s.Id).FirstOrDefault();

                        txtDescripcion.Texts = prodDetail[0].Description.Trim();
                        txtTara.Texts = prodDetail[0].Tara.ToString().Trim();
                        txtNeto.Texts = prodDetail[0].NetWeight.ToString();
                        txtPrecio.Texts = prodDetail[0].PricePerKg.ToString();
                        proveedoresDropDown.Texts = provCode.Trim() + " - " + provedName.Trim();
                        ccbProducto.Texts = prodCode.Trim().ToString() + " - " + prodDetail[0].Description.Trim().ToString();

                        FillListViewMateriaPrimaTop(provCode.Trim().ToString());

                        /*
                        var providerRawMaterials = _db1.ProvidersRawmaterials.Where(u => u.RawmaterialId == prodDetail[0].Id).ToList();
                        var providerDetails = _db1.Providers.Where(u => u.Id == providerRawMaterials[0].ProviderId).ToList();

                        var providerTmp = string.Concat(providerDetails[0].Id, "-", providerDetails[0].Name);

                        for (var i = 0; i < proveedoresDropDown.Items.Count; i++)
                        {
                            if (System.String.Compare(proveedoresDropDown.Items[i].ToString(), providerTmp) == 0)
                            {
                                proveedoresDropDown.SelectedIndex = i;
                            }
                        }*/
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema RMF-003: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtTara_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                txtTara.Texts = "";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            productCode = "";
            proveedoresDropDown.Texts = "";
            ccbProducto.Texts = "";
            txtDescripcion.Texts = "";
            txtNeto.Texts = "0.0000000000";
            txtPrecio.Texts = "0.0000000000";
            txtTara.Texts = "0.0000000000";
            proveedoresDropDown.Enabled = true;
            ccbProducto.Enabled = true;
        }




        //METODOS PERSNALIZADOS


        private void LlenarListViewMateriaPrima()
        {
            try
            {
                //Instanciando Conexión a la BD
                BimDb1Context _db1 = new BimDb1Context();
                //Consulta de mucho a mucho con LINQ
                List<ProviderProductDTO> ProveedorJoinProducto = (from prov in _db1.Providers
                                                                  join provProd in _db1.ProvidersRawmaterials on prov.Id equals provProd.ProviderId
                                                                  join prod in _db1.Rawmaterials on provProd.RawmaterialId equals prod.Id
                                                                  select new ProviderProductDTO
                                                                  {
                                                                      ProductId = prod.Id,
                                                                      ProductName = prod.Description,
                                                                      ProviderName = prov.Name,
                                                                      ProviderIsActive = prov.Acrive
                                                                  }).ToList();


                var ProvidersRawmaterialsCount = ProveedorJoinProducto.Count();// contando cantidad de registro

                listViewMateriaPrima.Items.Clear();//Limpia los datos de la lista

                for (var i = 0; i < ProvidersRawmaterialsCount; i++)
                {
                    ListViewItem materiaPrimaItem = new ListViewItem(ProveedorJoinProducto[i].ProductId);


                    materiaPrimaItem.SubItems.Add(ProveedorJoinProducto[i].ProductName.Trim());
                    materiaPrimaItem.SubItems.Add(ProveedorJoinProducto[i].ProviderName.Trim());
                    if (ProveedorJoinProducto[i].ProviderIsActive == true)
                    {
                        materiaPrimaItem.SubItems.Add("Activo");
                    }
                    else
                    {
                        materiaPrimaItem.SubItems.Add("Inactivo");
                    }


                    //Agregando lista al componente listview
                    listViewMateriaPrima.Items.Add(materiaPrimaItem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema RMF-001: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool proveedoresDropDown_Validating(string codigoProv)
        {
           
            if (!ValidarTxt.validarProveedorCodigo(codigoProv))
            {
                errorProv.SetIconPadding(proveedoresDropDown, -50);
                errorProv.SetError(proveedoresDropDown, "El Proveedor seleccionado no existe");
                return false;

            }
            else if (ValidarTxt.ValidateText(proveedoresDropDown.Texts))
            {
                errorProv.SetIconPadding(proveedoresDropDown, -50);
                errorProv.SetError(proveedoresDropDown, "El campo Proveedor se encuentra vacio");
                return false;
            }
            errorProv.Clear();
            return true;
            

        }

        private bool ccbProducto_vacio_Validating()
        {
            if (ValidarTxt.ValidateText(ccbProducto.Texts))
            {
                errorProducto.SetIconPadding(ccbProducto, -50);
                errorProducto.SetError(ccbProducto, "El campo Producto no puede estar vacio");
                return false;
            }
            else if (ccbProducto.Texts.Length < 5)
            {
                errorProducto.SetIconPadding(ccbProducto, -50);
                errorProducto.SetError(ccbProducto, "El campo Producto debe contener al menos 5 caracteres");
                return false;
            }
            else
            {
                errorProducto.Clear();
                return true;
            }
        }

        private bool ccbProducto_Validating(string codigoProd)
        {
            using (var _db1 = new BimDb1Context())
            {
                var existeProd = _db1.Rawmaterials.Where(p => p.Id == codigoProd).Count();
                if (existeProd <= 0)
                {

                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private bool ccbProducto_Validating_Relationship_Provider(string providerCode, string productCode)
        {
            using (var _db1 = new BimDb1Context())
            {
                var existeProdRelProv = _db1.ProvidersRawmaterials.Where(rm => (rm.ProviderId == providerCode) && (rm.RawmaterialId == productCode)).Count();


                if (existeProdRelProv <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        private bool txtDescripcion_Validating()
        {
            if (ValidarTxt.ValidateText(txtDescripcion.Texts))
            {
                errorDescripcion.SetIconPadding(txtDescripcion, -30);
                errorDescripcion.SetError(txtDescripcion, "El campo descripcion no puede estar vacio");
                return false;
            }
            else
            {
                errorDescripcion.Clear();
                return true;
            }
        }
        private bool txtTara_Validating()
        {
            if (ValidarTxt.ValidateText(txtTara.Texts))
            {
                errorTara.SetIconPadding(txtTara, -30);
                errorTara.SetError(txtTara, "El campo tara no puede estar vacio");
                return false;
            }
            if (!double.TryParse(txtTara.Texts, out double n))
            {
                errorTara.SetIconPadding(txtTara, -30);
                errorTara.SetError(txtTara, "El campo tara solo puede contener números");
                return false;
            }
            else
            {
                errorTara.Clear();
                return true;
            }
        }
        private bool txtNeto_Validating()
        {
            if (ValidarTxt.ValidateText(txtNeto.Texts))
            {
                errorNeto.SetIconPadding(txtNeto, -30);
                errorNeto.SetError(txtNeto, "El campo peso neto no puede estar vacio");
                return false;
            }
            if (!double.TryParse(txtNeto.Texts, out double n))
            {
                errorNeto.SetIconPadding(txtNeto, -30);
                errorNeto.SetError(txtNeto, "El campo Peso Neto Teórico solo puede contener números");
                return false;
            }
            else
            {
                errorNeto.Clear();
                return true;
            }
        }
        private bool txtPrecio_Validating()
        {
            if (ValidarTxt.ValidateText(txtPrecio.Texts))
            {
                errorPrecio.SetIconPadding(txtPrecio, -30);
                errorPrecio.SetError(txtPrecio, "El campo precio no puede estar vacio");
                return false;
            }
            if (!double.TryParse(txtPrecio.Texts, out double n))
            {
                errorPrecio.SetIconPadding(txtPrecio, -30);
                errorPrecio.SetError(txtPrecio, "El campo Peso Por Kilogramo solo puede contener números");
                return false;
            }
            else
            {
                errorPrecio.Clear();
                return true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {


                using (BimDb1Context _db1 = new BimDb1Context())
                {

                    var buscarProducto = txtSeach.Texts.Trim();
                    bool isChequed = false;

                    if (!string.IsNullOrEmpty(buscarProducto))
                    {

                        if (rbDescripcion.Checked == true)
                        {
                            isChequed = true;
                        }
                        FillComboBox.FillListViewOfProductByProductDescriptionManyToMany(isChequed, buscarProducto, listViewMateriaPrima);
                    }
                    else
                    {
                        this.LlenarListViewMateriaPrima();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema GMPF-002: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ccbProducto_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            txtDescripcion.Texts = "";
            txtNeto.Texts = "0.0000000000";
            txtPrecio.Texts = "0.0000000000";
            txtTara.Texts = "0.0000000000";

            var selectedIndex = ccbProducto.SelectedIndex;//Seleccionanod la posición (index) del elemento seleccionado en el combobox
            var productCode = products[selectedIndex].Id; //obteniendo ID proveedor por el index

            //var providerText = proveedoresDropDown.Texts.Trim().Split(" - ");
            //var providerCode = providerText[0];

            //if (ccbProducto_Validating(productCode) && !ccbProducto_Validating_Relationship_Provider(providerCode, productCode))
            if (ccbProducto_Validating(productCode))
            {
                try
                {



                    using (var _db1 = new BimDb1Context())
                    {
                        var rawmaterial = _db1.Rawmaterials.Where(rw => rw.Id == productCode).ToList();
                        txtDescripcion.Texts = rawmaterial[0].Description.Trim();
                        txtNeto.Texts = rawmaterial[0].NetWeight.ToString().Trim();
                        txtPrecio.Texts = rawmaterial[0].PricePerKg.ToString().Trim();
                        txtTara.Texts = rawmaterial[0].Tara.ToString().Trim();
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Error del sistema GMPF-003: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                txtDescripcion.Texts = "";
                txtNeto.Texts = "0.0000000000";
                txtPrecio.Texts = "0.0000000000";
                txtTara.Texts = "0.0000000000";
            }
           
        }
    }
}