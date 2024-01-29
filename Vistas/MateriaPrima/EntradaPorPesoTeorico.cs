using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Utilities;
using Negocio.Utilities.Validaciones;
using Entities.Data;
using Negocio.Utilities;
using Negocio.Controllers;
using Entities.DTO;
using Entities.Entities;

using EnvDTE90;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MaterialSkin.Controls;
using EnvDTE;
using DocumentFormat.OpenXml.Wordprocessing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DocumentFormat.OpenXml.Vml.Spreadsheet;
using Microsoft.EntityFrameworkCore.Update;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace Presentacion.Vistas.MateriaPrima
{
    public partial class EntradaPorPesoTeorico : Form
    {

        private static ErrorProvider errorProveedor = new ErrorProvider();
        private static ErrorProvider errorPlaca = new ErrorProvider();
        private static ErrorProvider errorProducto = new ErrorProvider();
        private static ErrorProvider errorPesoManifest = new ErrorProvider();
        private static ErrorProvider errorNumBultosRec = new ErrorProvider();

        List<ProviderDTO> providers = new List<ProviderDTO>();
        List<ProductDTO> products = new List<ProductDTO>();
        decimal pesoTeoricoUnit;
        string[] editDataArray;
        bool modoEdicion = false;
        bool finalizarEntrada = false;
        int idEntry = 0;
        double ManifestadoWeight = 0;
        decimal teoricoWeight = 0;
        double bultosTeoricos = 0;
        double bultosRecived = 0;
        double pesoRecived = 0;
        string idProd = "";
        string idProv = "";
        bool AutocalcOesiTeorico = true;

        int userId = MyGlobalsVar.userId;
        string userName = MyGlobalsVar.userName;
        public EntradaPorPesoTeorico()
        {
            InitializeComponent();
            modoEdicion = false;

            lblPesoTeoricoUnit.Visible = true;
            label4.Visible = true;
        }

        public EntradaPorPesoTeorico(string[] editDataArray)
        {
            InitializeComponent();
            this.editDataArray = editDataArray;
            modoEdicion = true;
            btnCrearM.Visible = true;
            btnFinalizarE.Visible = true;
            btnEliminarE.Visible = true;
            btnGuardar.Text = "Actualizar";
            txtFecha.Texts = ObtenerFechaHora.GetFormattedDate();
            txtHora.Texts = ObtenerFechaHora.GetFormattedTime();
            AutocalcOesiTeorico = false;
            lblPesoTeoricoUnit.Visible = false;
            label4.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.cerrarForm();
        }
        private void EntradaPorPesoTeorico_Load(object sender, EventArgs e)
        {
            txtFecha.Texts = ObtenerFechaHora.GetFormattedDate();
            txtHora.Texts = ObtenerFechaHora.GetFormattedTime();

            FillComboBox.LlenarComboBoxProveedores(cbProveedores, providers);
            if (modoEdicion == true)
            {
                cbProveedores.Enabled = false;
                cbProductos.Enabled = false;
                cbPlates.Enabled = false;
                idProd = editDataArray[0];
                idProv = editDataArray[9];
                idEntry = Int32.Parse(editDataArray[10]);

                cbProductos.Texts = idProd + " - " + editDataArray[1];
                cbProveedores.Texts = idProv + " - " + editDataArray[2];
                cbPlates.Texts = editDataArray[3];
                var dateFormat = DateTime.Parse(editDataArray[4]);
                /*txtFecha.Texts = dateFormat.ToString("dd/MM/yyyy");
                txtHora.Texts = dateFormat.ToString("hh:mm:ss");*/
                txtPesoManifestado.Texts = editDataArray[5];
                txtNumeroBultosTeorico.Texts = editDataArray[6];
                txtPesoRecibido.Texts = editDataArray[7];
                txtNumeroBultosRecibidos.Texts = editDataArray[8];
                teoricoWeight = this.getTeoricWeightByProdId(idProd);
                ManifestadoWeight = Double.Parse(editDataArray[5]);
                bultosTeoricos = Double.Parse(editDataArray[6]);
                pesoRecived = Double.Parse(editDataArray[7]);
                bultosRecived = Double.Parse(editDataArray[8]);
            }

        }

        private void cbProveedores_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cbProveedores.SelectedIndex;
            var idProvSelected = providers[selectedIndex].Id;
            cbProductos.Texts = string.Empty;
            cbPlates.Texts = string.Empty;

            cbPlates.DataSource = null;
            cbPlates.Items.Clear();
            cbProductos.DataSource = null;
            cbProductos.Items.Clear();

            FillComboBox.FillComboBoxOfProductByProductDescriptionManyToMany(idProvSelected, cbProductos);
            FillComboBox.FillComboBoxPlateByProvider(idProvSelected, cbPlates);

        }

        private void cbProductos_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIndex = cbProductos.SelectedIndex;
            if (cbProductos.SelectedItem != null)
            {
                var prod = (ProductDTO)cbProductos.SelectedItem;

                pesoTeoricoUnit = getTeoricWeightByProdId(prod.Id);
                lblPesoTeoricoUnit.Text = pesoTeoricoUnit.ToString("N2");
            }

        }

        private Decimal calculoManifestadoAUtomatico()
        {
            Decimal res = 0;
            if (AutocalcOesiTeorico == true)
            {
                res = Decimal.Parse(txtNumeroBultosTeorico.Texts) * pesoTeoricoUnit;
            }
            else
            {
                res = Convert.ToDecimal(txtPesoManifestado.Texts);
            }
            return res;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var txtPlaca = cbPlates.Texts.Trim();
            var providerCode = cbProveedores.Texts.Trim().Split(" - ")[0];// al capturar texto de combobox se realiza un split y se escoge solamente la parte donde se encuentra el código
            var productCode = cbProductos.Texts.Trim().Split(" - ")[0];
            var verificarProd = "";
            var verificarProv = "";

            var date = txtFecha.Texts.Trim().Split("/");
            string datetimeRecord = date[2] + "/" + date[1] + "/" + date[0] + " " + txtHora.Texts.Trim();
            // datetimeRecord.ToString("MM/dd/yyyy HH:mm:ss tt");
            if (modoEdicion == false)
            {
                verificarProd = productCode;
                verificarProv = providerCode;
            }
            else
            {
                verificarProd = idProd;
                verificarProv = idProv;
            }
            if (cbProveedores_Validating(verificarProv) && cbProducto_Validating(verificarProd) && cbPlaca_Validating())
            {
                if (txtNumeroBultosTeorico_Validating() && txtPesoManifestado_Validating())
                {
                    if (!ValidarTxt.validarCodigoPlaca(txtPlaca, verificarProv))//Si proveedor no tiene el numero de placa crea una nueva placa al proveedor
                    {
                        this.savePlateByProviderId(txtPlaca, verificarProv);
                    }
                    if (modoEdicion == false)
                    {
                        //crear nuevo registro a entradas y movimientos
                        this.createEntry(userId, userName, datetimeRecord, verificarProv, verificarProd, txtPlaca);
                        //this.createMovement(userName, datetimeRecord);
                        MessageBox.Show("Entrada guardada existosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        idEntry = this.getLastEntryId();//id se usa solo si se desea crear movimiento desde este form despues de haber creado por primera vez una entrada
                        modoEdicion = true;
                        btnFinalizarE.Visible = true;
                        btnEliminarE.Visible = true;
                        btnCrearM.Visible = true;
                        idProd = verificarProd;
                        idProv = verificarProv;
                        teoricoWeight = this.getTeoricWeightByProdId(idProd);
                        ManifestadoWeight = Double.Parse(txtPesoManifestado.Texts);
                        btnGuardar.Text = "Actualizar";

                    }
                    else
                    {
                        this.updateEntry(userId, userName, datetimeRecord, verificarProv, verificarProd/*, txtPlaca*/);
                        MessageBox.Show("Entrada Actualizada existosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Campos numericos no deben contener letras, estar vacio o  contener valores menores que cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Uno o más campos se encuentran vacios, o el dato ingresado no corresponde al campo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btnCrearM_Click(object sender, EventArgs e)
        {
            if (cbProveedores_Validating(idProv) && cbProducto_Validating(idProd) && cbPlaca_Validating())
            {
                if (txtNumeroBultosTeorico_Validating() && txtPesoManifestado_Validating())
                {
                    ManifestadoWeight = Double.Parse(txtPesoManifestado.Texts);
                    this.openMovementForm(idEntry, teoricoWeight, ManifestadoWeight);
                }
                else
                {
                    MessageBox.Show("Campos numericos no deben contener letras, estar vacio o contener valores menores que cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Uno o más campos se encuentran vacios, o el dato ingresado no corresponde al campo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            /*
            string message = "Esta apunto de crear un nuevo movimiento, ¿desea crearlo?";
            string title = "Crear Movimiento";
            var dialog = MyGlobalsVar.PreClosingCOnfirmation(message, title);
            if (dialog == DialogResult.Yes)
            {
                txtFecha.Texts = ObtenerFechaHora.GetFormattedDate();
                txtHora.Texts = ObtenerFechaHora.GetFormattedTime();
                if (cbProveedores_Validating(idProv) && cbProducto_Validating(idProd) && cbPlaca_Validating())
                {
                    if (txtNumeroBultosTeorico_Validating() && txtPesoManifestado_Validating())
                    {
                        var date = txtFecha.Texts.Trim().Split("/");
                        string datetimeRecord = date[2] + "/" + date[1] + "/" + date[0] + " " + txtHora.Texts.Trim();
                        this.createMovement(userName, datetimeRecord);
                        MessageBox.Show("Movimiento creado existosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Campos numericos no deben contener letras, estar vacio o contener valores menores que cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Uno o más campos se encuentran vacios, o el dato ingresado no corresponde al campo", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            */

        }

        private void btnEliminarE_Click(object sender, EventArgs e)
        {
            string message = "Esta apunto de Eliminar esta entrada y sus movimientos, ¿desea Eliminarla?";
            string title = "Eliminar Entrada y Movimientos";
            var dialog = MyGlobalsVar.PreClosingCOnfirmation(message, title);
            if (dialog == DialogResult.Yes)
            {
                EntryController entryController = new EntryController();
                entryController.deleteEntryMovementCascade(idEntry);
                MessageBox.Show("Entrada y movimientos eliminados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cerrarForm();
            }
        }
        private void btnFinalizarE_Click(object sender, EventArgs e)
        {
            string message = "Esta apunto de Finalizar esta entrada, ¿desea finalizarla?";
            string title = "Finalizar Movimiento";
            var dialog = MyGlobalsVar.PreClosingCOnfirmation(message, title);
            if (dialog == DialogResult.Yes)
            {
                finalizarEntrada = true;
                var date = txtFecha.Texts.Trim().Split("/");
                string datetimeRecord = date[2] + "/" + date[1] + "/" + date[0] + " " + txtHora.Texts.Trim();
                MovementController movementController = new MovementController();
                movementController.updateMovementByEntryId(idEntry, false);
                this.updateEntry(userId, userName, datetimeRecord, idProv, idProd);
                MessageBox.Show("Entrada y movimientos finalizados con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cerrarForm();
            }
        }

        private void cbProveedores_Leave(object sender, EventArgs e)
        {
            var providerCode = cbProveedores.Texts.Trim().Split(" - ")[0];
            this.cbProveedores_Validating(providerCode);
        }

        private void cbProductos_Leave(object sender, EventArgs e)
        {
            var productCode = cbProductos.Texts.Trim().Split(" - ")[0];
            this.cbProducto_Validating(productCode);
        }

        private void cbPlates_Leave(object sender, EventArgs e)
        {
            this.cbPlaca_Validating();
        }

        private void txtPesoManifestado_Leave(object sender, EventArgs e)
        {
            this.txtPesoManifestado_Validating();
        }
        private void txtNumeroBultos_Leave(object sender, EventArgs e)
        {
            txtPesoManifestado.Texts = calculoManifestadoAUtomatico().ToString("N2");
            this.txtNumeroBultosTeorico_Validating();
        }



        //METODOS PERSONALIZADOS-------------------------------------------------------------------------------
        private void cerrarForm()
        {
            VistaMateriaPrima vistaMateriaPrimaForm = new VistaMateriaPrima();
            //Definir MDI parent
            vistaMateriaPrimaForm.MdiParent = (mainMenuForm)this.Parent.Parent;
            vistaMateriaPrimaForm.Show();
            Close();
        }

        private void openMovementForm(int idEntry, decimal teoricoWeight, double ManifestadoWeight)
        {
            EntradaPorPesoBalanza entradaPorPesoBalanza = new EntradaPorPesoBalanza(idEntry, teoricoWeight, ManifestadoWeight);
            //Definir MDI parent
            entradaPorPesoBalanza.MdiParent = (mainMenuForm)this.Parent.Parent;
            entradaPorPesoBalanza.Show();
            Close();
        }
        private void savePlateByProviderId(string platenumber, string verificarProv)
        {
            PlateController plateController = new PlateController();
            plateController.savePlateByProvidderId(platenumber, verificarProv);
            MessageBox.Show("Se agregó nueva placa al proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private decimal getTeoricWeightByProdId(string idProduct)
        {
            MateriaPrimaController materiaPrimaController = new MateriaPrimaController();
            return materiaPrimaController.getTeoricWeightByProdId(idProduct);
        }
        private int getLastEntryId()
        {
            EntryController entryController = new EntryController();
            return entryController.getLastEntryId();
        }

        private void createEntry(int userId, string userName, string datetimeRecord, string verificarProv, string verificarProd, string txtPlaca)
        {
            RawmaterialsEntry dataEntry = new RawmaterialsEntry();
            EntryController entryController = new EntryController();
            dataEntry.UserId = userId;
            dataEntry.ProviderId = verificarProv;
            dataEntry.PlateId = getPlateIdByProvider(verificarProv, txtPlaca);
            dataEntry.RawmaterialId = verificarProd;
            dataEntry.Weigher = userName;
            dataEntry.DateHour = DateTime.Parse(datetimeRecord);
            dataEntry.ManifestedWeight = calculoManifestadoAUtomatico();
            dataEntry.BagsNumber = decimal.Parse(txtNumeroBultosTeorico.Texts.Trim());
            dataEntry.ReceivedWeight = decimal.Parse(txtPesoRecibido.Texts.Trim());
            dataEntry.BagsNumberReceived = decimal.Parse(txtNumeroBultosRecibidos.Texts.Trim());
            entryController.createEntry(dataEntry);
        }
        private void updateEntry(int userId, string userName, string datetimeRecord, string verificarProv, string verificarProd/*, string txtPlaca*/)
        {
            RawmaterialsEntry dataEntry = new RawmaterialsEntry();
            EntryController entryController = new EntryController();

            ManifestadoWeight = Double.Parse(txtPesoManifestado.Texts);
            bultosTeoricos = Double.Parse(txtNumeroBultosTeorico.Texts);
            pesoRecived = Double.Parse(txtPesoRecibido.Texts);
            bultosRecived = Double.Parse(txtNumeroBultosRecibidos.Texts);
            dataEntry.DateHour = DateTime.Parse(datetimeRecord);
            dataEntry.ManifestedWeight = calculoManifestadoAUtomatico();
            dataEntry.BagsNumber = (decimal)bultosTeoricos;
            dataEntry.ReceivedWeight = (decimal)pesoRecived;
            dataEntry.BagsNumberReceived = (decimal)bultosRecived;
            dataEntry.Active = finalizarEntrada ? false : true;
            entryController.updateEntry(idEntry, dataEntry);
        }
        public void createMovement(string userName, string datetimeRecord)
        {
            MateriaPrimaController materiaPrimaController = new MateriaPrimaController();
            int LastEntrieId;
            RawmaterialsMovement dataMovement = new RawmaterialsMovement();
            MovementController movementController = new MovementController();
            dataMovement.DateHour = DateTime.Parse(datetimeRecord);
            dataMovement.Weigher = userName;
            dataMovement.GrossWeight = 0;
            dataMovement.ExtraTaraWeight = 0;
            dataMovement.IndTaraWeight = 0;
            dataMovement.TotalTaraWeight = 0;
            dataMovement.NetWeight = 0;
            dataMovement.BagsNumber = 0;
            if (modoEdicion == true)
            {
                dataMovement.RawMaterialEntryId = idEntry;
            }
            else
            {
                LastEntrieId = materiaPrimaController.GetLastRawMaterialEntrieId();
                dataMovement.RawMaterialEntryId = LastEntrieId;
            }
            movementController.createMovement(dataMovement);
        }
        private int getPlateIdByProvider(string providerId, string txtPlate)
        {
            PlateByProviderDTO plateByProviderDTOs = new PlateByProviderDTO();
            PlateController pc = new PlateController();

            return pc.getPlateIdByProvider(providerId, txtPlate);
        }
        //Validaciones
        private bool cbProveedores_Validating(string providerId)
        {
            var item = cbProductos.SelectedIndex;
            if (ValidarTxt.ValidateText(cbProveedores.Texts) || !ValidarTxt.validarProveedorCodigo(providerId))
            {
                errorProveedor.SetIconPadding(cbProveedores, -50);
                errorProveedor.SetError(cbProveedores, "Seleccione un Proveedor valido");
                return false;
            }
            else
            {
                errorProveedor.Clear();

                return true;
            }
        }

        private bool cbProducto_Validating(string productId)
        {
            if (ValidarTxt.ValidateText(cbProductos.Texts) || !ValidarTxt.validarProductoCodigo(productId))
            {
                errorProducto.SetIconPadding(cbProductos, -50);
                errorProducto.SetError(cbProductos, "El campo no debe estar vaacio, Seleccione un Producto valido");
                return false;
            }
            else
            {
                errorProducto.Clear();
                return true;
            }
        }

        private bool cbPlaca_Validating()
        {
            if (ValidarTxt.ValidateText(cbPlates.Texts))
            {
                errorPlaca.SetIconPadding(cbPlates, -50);
                errorPlaca.SetError(cbPlates, "EL campo placa no debe estar vacio, agregue nueva palca o seleccione una existente");
                return false;
            }
            else
            {
                errorPlaca.Clear();
                return true;
            }
        }

        private bool txtPesoManifestado_Validating()
        {
            if (ValidarTxt.ValidateText(txtPesoManifestado.Texts))
            {
                errorPesoManifest.SetIconPadding(txtPesoManifestado, -30);
                errorPesoManifest.SetError(txtPesoManifestado, "El campo Peso Manifestado Teórico no puede estar vacio");
                return false;
            }
            if (!double.TryParse(txtPesoManifestado.Texts, out double n))
            {
                errorPesoManifest.SetIconPadding(txtPesoManifestado, -30);
                errorPesoManifest.SetError(txtPesoManifestado, "El campo Peso Manifestado Teórico solo puede contener números");
                return false;
            }
            if (double.Parse(txtPesoManifestado.Texts) <= 0)
            {
                errorPesoManifest.SetIconPadding(txtPesoManifestado, -30);
                errorPesoManifest.SetError(txtPesoManifestado, "No se permiten valores menores o igual a cero");
                return false;
            }
            else
            {
                errorPesoManifest.Clear();
                return true;
            }
        }
        private bool txtNumeroBultosTeorico_Validating()
        {
            if (ValidarTxt.ValidateText(txtNumeroBultosTeorico.Texts))
            {
                errorNumBultosRec.SetIconPadding(txtNumeroBultosTeorico, -30);
                errorNumBultosRec.SetError(txtNumeroBultosTeorico, "El campo Numero Bultos Teóricos no puede estar vacio");
                return false;
            }
            if (!double.TryParse(txtNumeroBultosTeorico.Texts, out double n))
            {
                errorNumBultosRec.SetIconPadding(txtNumeroBultosTeorico, -30);
                errorNumBultosRec.SetError(txtNumeroBultosTeorico, "El campo Numero Bultos Teóricos solo puede contener números");
                return false;
            }
            if (double.Parse(txtNumeroBultosTeorico.Texts) <= 0)
            {
                errorNumBultosRec.SetIconPadding(txtNumeroBultosTeorico, -30);
                errorNumBultosRec.SetError(txtNumeroBultosTeorico, "No se permiten valores menores o igual a cero");
                return false;
            }
            else
            {
                errorNumBultosRec.Clear();
                return true;
            }
        }
        private void txtNumeroBultosTeorico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.A)
            {
                MessageBox.Show("KeyPress");
            }
        }
    }
}
