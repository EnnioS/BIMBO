using Presentacion.Controles;
using Negocio.Utilities.Validaciones;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using Entities.Data;
using Entities.Entities;
using Negocio.Controllers;

namespace Presentacion.Vistas
{
    public partial class GestionarProveedor : Form
    {
        private static ErrorProvider errorNombre = new ErrorProvider();
        private static ErrorProvider errorEmail = new ErrorProvider();
        private static ErrorProvider errorTelefono1 = new ErrorProvider();
        private static ErrorProvider errorTelefono2 = new ErrorProvider();
        private static ErrorProvider errorDireccion = new ErrorProvider();
        private static ErrorProvider errorContacto = new ErrorProvider();
        string idProveedor = "";
        public GestionarProveedor()
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

        private void GestionarProveedor_Load(object sender, EventArgs e)
        {
            this.LlenarListViewProveedor();
        }



        //Agregar NUevo Usuario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre.Texts.Trim();
            var email = txtEmail.Texts.Trim();
            var telefono1 = txtTelefono1.Texts.Trim();
            var telefono2 = (txtTelefono2.Texts.Trim() == "(   )    -") ? "" : txtTelefono2.Texts.Trim();
            var direccion = txtDireccion.Texts.Trim();
            var contacto = txtContacto.Texts.Trim();

            if (txtNombre_Validating() && txtEmail_Validating() && txtDireccion_Validating() && txtTelefono1_Validating() && txtContacto_Validating())
            {
                try
                {
                    using (var _db1 = new BimDb1Context())
                    {

                        //Crear usuario
                        if (idProveedor == "")
                        {

                            var proveedor = new Provider();
                            proveedor.Id = this.CrearCodigoProveedor(_db1).Trim(); //Crear codigo automaticamente
                            proveedor.Name = nombre.Trim();
                            proveedor.Email = email.Trim();
                            proveedor.Address = direccion.Trim();
                            proveedor.Contact = contacto.Trim();
                            proveedor.Tel1 = telefono1.Trim();
                            proveedor.Tel2 = telefono2.Trim();


                            _db1.Providers.Add(proveedor);

                            _db1.SaveChanges();
                            this.LlenarListViewProveedor();
                            MessageBox.Show("Proveedor Guardado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.clear();

                        }
                        //Actualizar usuario
                        else
                        {
                            var proveedor = _db1.Providers.Find(idProveedor);
                            proveedor.Name = nombre.Trim();
                            proveedor.Email = email.Trim();
                            proveedor.Address = direccion.Trim();
                            proveedor.Contact = contacto.Trim();
                            proveedor.Tel1 = telefono1.Trim();
                            proveedor.Tel2 = telefono2.Trim();
                            proveedor.Acrive = this.validarRButtonActive();


                            _db1.SaveChanges();
                            this.LlenarListViewProveedor();
                            MessageBox.Show("Proveedor Actualizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error del sistema GUF-002: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Uno o más campos se encuentran vacios, o el dato ingresado no corresponde al campo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void lvProveedores_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (lvProveedores.SelectedIndices.Count <= 0)
                {
                    return;
                }
                int intselectedindex = lvProveedores.SelectedIndices[0];
                if (intselectedindex >= 0)
                {
                    IEnumerable<Plate> placaList = new List<Plate>();
                    //Obtiene el priner dato de la listview
                    idProveedor = lvProveedores.Items[intselectedindex].Text.Trim();

                    using (BimDb1Context _db1 = new BimDb1Context())
                    {
                        var providerDetail = _db1.Providers.Where(u => u.Id == idProveedor).ToList();

                        txtNombre.Texts = providerDetail[0].Name;
                        txtEmail.Texts = providerDetail[0].Email;
                        txtTelefono1.Texts = providerDetail[0].Tel1;
                        txtTelefono2.Texts = providerDetail[0].Tel2;
                        txtDireccion.Texts = providerDetail[0].Address;
                        txtContacto.Texts = providerDetail[0].Contact;

                        this.validarRbuttonsActivo(providerDetail[0].Acrive);
                    }

                    PlateController plateController = new PlateController();
                    placaList = plateController.getnumeroPlacaByProviderI(idProveedor);
                    this.poblarListViewPlacaByProviderId(placaList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema GUF-003: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void poblarListViewPlacaByProviderId(IEnumerable<Plate> plateList)
        {
            lvNumPlacas.Items.Clear();

            List<Plate> placaList = (List<Plate>)plateList;

            var i = 0;
            foreach (var placa in placaList)
            {

                ListViewItem plateItem = new ListViewItem(placaList[i].LicensePlaateNumber.Trim());

                lvNumPlacas.Items.Add(plateItem);
                i++;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.clear();
            idProveedor = "";
        }

        private void btnBuscarProvider_Click(object sender, EventArgs e)
        {


            try
            {


                using (BimDb1Context _db1 = new BimDb1Context())
                {

                    var buscarProveedor = txtSeachByName.Texts.Trim();
                    List<Provider> Providerlist;
                    if (rbNombre.Checked == true)
                    {

                        //Query EF (Where Like "text%") odenado de manera acendente
                        Providerlist = _db1.Providers.Where(un => un.Name.StartsWith(buscarProveedor)).OrderBy(x => x.Name).ToList();//recuperando registro
                    }
                    else
                    {
                        //Query EF (Where Like "text%") odenado de manera acendente
                        Providerlist = _db1.Providers.Where(un => un.Id.StartsWith(buscarProveedor)).OrderBy(x => x.Id).ToList();//recuperando registro de usuarios
                    }
                    var providerCount = Providerlist.Count();// contando cantidad de registro en tabla

                    lvProveedores.Items.Clear();

                    for (var i = 0; i < providerCount; i++)
                    {
                        ListViewItem providerItem = new ListViewItem(Providerlist[i].Id.ToString());

                        //Agregando datos a la lista
                        providerItem.SubItems.Add(Providerlist[i].Name.Trim());
                        providerItem.SubItems.Add(Providerlist[i].Email.Trim());

                        if (Providerlist[i].Tel2.Trim().IsNullOrEmpty() || Providerlist[i].Tel2.Trim() == "(   )    -")
                        {
                            providerItem.SubItems.Add(Providerlist[i].Tel1.Trim());
                        }
                        else
                        {
                            providerItem.SubItems.Add(Providerlist[i].Tel1.Trim() + " / " + Providerlist[i].Tel2.Trim());
                        }

                        providerItem.SubItems.Add(Providerlist[i].Address.Trim());

                        if (Providerlist[i].Acrive == true)
                        {

                            providerItem.SubItems.Add("Activo");
                        }
                        else
                        {
                            providerItem.SubItems.Add("Inactivo");
                        }

                        //Agregando lista al componente listview
                        lvProveedores.Items.Add(providerItem);

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema GUF-002: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Validar campos

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            txtNombre_Validating();
        }


        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail_Validating();
        }


        private void txtTelefono1_Leave(object sender, EventArgs e)
        {
            txtTelefono1_Validating();
        }



        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            txtDireccion_Validating();
        }


        private void txtContacto_Leave(object sender, EventArgs e)
        {
            txtContacto_Validating();
        }



        //Metodos Personalizados
        private void LlenarListViewProveedor()
        {
            try
            {
                //Instanciando Conexión a la BD
                BimDb1Context _db1 = new BimDb1Context();

                var Providerslist = _db1.Providers.ToList();//recuperando registro de proveedores
                var providerCount = Providerslist.Count();// contando cantidad de registro en tabla usuario

                lvProveedores.Items.Clear();//Limpia los datos de la lista

                for (var i = 0; i < providerCount; i++)
                {
                    ListViewItem providerItem = new ListViewItem(Providerslist[i].Id.ToString().Trim());

                    //Agregando datos a la lista

                    providerItem.SubItems.Add(Providerslist[i].Name.Trim());
                    providerItem.SubItems.Add(Providerslist[i].Email.Trim());
                    if (Providerslist[i].Tel2.Trim().IsNullOrEmpty() || Providerslist[i].Tel2.Trim() == "(   )    -")
                    {
                        providerItem.SubItems.Add(Providerslist[i].Tel1.Trim());
                    }
                    else
                    {
                        providerItem.SubItems.Add(Providerslist[i].Tel1.Trim() + " / " + Providerslist[i].Tel2.Trim());

                    }

                    providerItem.SubItems.Add(Providerslist[i].Address.Trim());
                    if (Providerslist[i].Acrive == true)
                    {

                        providerItem.SubItems.Add("Activo");
                    }
                    else
                    {
                        providerItem.SubItems.Add("Inactivo");
                    }

                    lvProveedores.Items.Add(providerItem);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema GUF-001: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CrearCodigoProveedor(BimDb1Context _db1)
        {


            //obteter el último registro
            var providerContent = _db1.Providers;
            var countReg = providerContent.Count();//cantidad de registros
            string NewProvCode = "";
            string OnlyLetter = "CPR-";
            if (countReg > 0)
            {
                var idLastProv = providerContent.OrderByDescending(p => p.CreatedAt).FirstOrDefault();//dato del último registro por fecha
                string id = idLastProv.Id;//ID último registro
                var onlyNumber = idLastProv.Id.Substring(id.Length - 4);//Se selecciona solo los numeros sin letras ni guión
                var numeroProv = Convert.ToInt32(onlyNumber.TrimStart(new Char[] { '0' }));//Elimina los ceros al inicio de la cadena de numero
                numeroProv += 1;


                NewProvCode = numeroProv.ToString();//convertir Int a String
                NewProvCode = NewProvCode.PadLeft(4, '0');//agregar ceros restantes a la cadena de 4 digitos


                var res = OnlyLetter + NewProvCode;

                return OnlyLetter + NewProvCode;
            }
            else
            {
                return "";
            }


        }


        private void clear()
        {
            txtNombre.Texts = txtEmail.Texts = txtTelefono1.Texts = txtTelefono2.Texts = txtDireccion.Texts = txtContacto.Texts = "";
        }
        private bool txtNombre_Validating()
        {
            if (ValidarTxt.ValidateText(txtNombre.Texts))
            {
                errorNombre.SetIconPadding(txtNombre, -30);
                errorNombre.SetError(txtNombre, "El campo nombre no puede estar vacio");
                return false;
            }
            else
            {
                errorNombre.Clear();
                return true;
            }
        }
        private bool txtEmail_Validating()
        {
            if (!ValidarTxt.validarEmail(txtEmail.Texts.Trim()))
            {
                errorEmail.SetIconPadding(txtEmail, -30);
                errorEmail.SetError(txtEmail, "El campo email debe cumplir con el formato 'nombre@dominio.com'");
                return false;
            }
            else
            {
                errorEmail.Clear();
                return true;
            }
        }
        private bool txtTelefono1_Validating()
        {
            if (ValidarTxt.ValidateText(txtTelefono1.Texts) || txtTelefono1.Texts == "(   )    -")
            {
                errorTelefono1.SetIconPadding(txtTelefono1, -30);
                errorTelefono1.SetError(txtTelefono1, "El campo telefono 1 no puede estar vacio");
                return false;
            }
            else
            {
                errorTelefono1.Clear();
                return true;
            }
        }


        private bool txtDireccion_Validating()
        {
            if (ValidarTxt.ValidateText(txtDireccion.Texts))
            {
                errorDireccion.SetIconPadding(txtDireccion, -30);
                errorDireccion.SetError(txtDireccion, "El campo telelfono 2 no puede estar vacio");
                return false;
            }
            else
            {
                errorDireccion.Clear();
                return true;
            }
        }

        private bool txtContacto_Validating()
        {
            if (ValidarTxt.ValidateText(txtContacto.Texts))
            {
                errorContacto.SetIconPadding(txtContacto, -30);
                errorContacto.SetError(txtContacto, "El campo telelfono 2 no puede estar vacio");
                return false;
            }
            else
            {
                errorContacto.Clear();
                return true;
            }
        }

        private bool validarRButtonActive()
        {
            var isAvtive = false;
            if (rbActive.Checked = true && rbUnactive.Checked == false)
            {
                isAvtive = true;
            }
            else if (rbActive.Checked = false && rbUnactive.Checked == true)
            {
                isAvtive = false;
            }
            return isAvtive;
        }


        private void validarRbuttonsActivo(bool? active)
        {
            if (active == true)
            {
                rbActive.Checked = true;
            }
            else
            {
                rbUnactive.Checked = true;
            }
        }

        private void lvNumPlacas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}