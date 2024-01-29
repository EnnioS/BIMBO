using Presentacion.Controles;
using Presentacion.Utilities;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities.Entities;
using Entities.DTO;
using Negocio.Utilities;
using Negocio.Controllers;
using Microsoft.IdentityModel.Tokens;
using Negocio.Utilities.Validaciones;
using Entities.Data;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Presentacion.Vistas.MateriaPrima
{


    public partial class EntradaPorPesoBalanza : Form
    {
        List<ProviderDTO> providers = new List<ProviderDTO>();
        List<ProductDTO> products = new List<ProductDTO>();
        List<Plate> plateEntity = new List<Plate>();

        private int entryId;
        private int movementId;
        private double teoricoWeight;
        private double ManifestadoWeight;
        private bool editMode = false;

        private decimal GrossWeight = 0;
        private decimal ExtraTaraWeight = 0;
        private decimal IndTaraWeight = 0;
        private decimal TotalTaraWeight = 0;
        private decimal NetWeight = 0;
        private decimal BagsNumber = 0;
        public EntradaPorPesoBalanza()
        {
            InitializeComponent();
        }

        public EntradaPorPesoBalanza(string[] data)
        {
            InitializeComponent();
            this.entryId = Int32.Parse(data[5]);
            this.movementId = Int32.Parse(data[4]);
            this.teoricoWeight = double.Parse(data[6]);
            this.ManifestadoWeight = double.Parse(data[3]);
            btnCrear.Text = "Actualizar";
            this.editMode = true;
        }

        public EntradaPorPesoBalanza(int entryId, decimal teoricoWeight, double ManifestadoWeight)
        {
            InitializeComponent();
            this.entryId = entryId;
            this.teoricoWeight = (double)teoricoWeight;
            this.ManifestadoWeight = ManifestadoWeight;
            btnCrear.Text = "Crear";
            btnEliminarM.Visible = false;
            editMode = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.cerrarForm();
        }

        #region load 
        private void EntradaPorPesoBalanza_Load(object sender, EventArgs e)
        {
            int plateId;
            txtFecha.Texts = ObtenerFechaHora.GetFormattedDate();
            txtHora.Texts = ObtenerFechaHora.GetFormattedTime();

            MateriaPrimaController materiaPrimaController = new MateriaPrimaController();
            List<RawmaterialsEntryDTO> entriesById = new List<RawmaterialsEntryDTO>();

            entriesById = materiaPrimaController.GetEntriesById(entryId);
            var countEntries = entriesById.Count();// contando cantidad de registro en tabla usuario

            if (countEntries > 0)
            {

                txtProveedor.Texts = entriesById[0].ProviderId + " - " + entriesById[0].ProviderName.ToString();
                txtProducto.Texts = entriesById[0].RawmaterialId + " - " + entriesById[0].ProductName.ToString();
                plateId = entriesById[0].PlateId;
                lblPesoTeorico.Text = teoricoWeight.ToString() + " Kg";
                lblPesoManifestado.Text = ManifestadoWeight.ToString() + " Kg";
                txtPlaca.Texts = materiaPrimaController.GetPlateNumberById(plateId);

                if (editMode == true)
                {

                    RawmaterialsMovement rawmaterialsMovement = new RawmaterialsMovement();
                    MovementController movementController = new MovementController();
                    rawmaterialsMovement = movementController.getMovementById(movementId);
                    

                    if (rawmaterialsMovement != null)
                    {
                        txtPesoB.Texts = rawmaterialsMovement.GrossWeight.ToString("N2");
                        txtTaraE.Texts = rawmaterialsMovement.ExtraTaraWeight.ToString("N2");
                        txtTaraI.Texts = rawmaterialsMovement.IndTaraWeight.ToString("N2");
                        txtTaraT.Texts = rawmaterialsMovement.TotalTaraWeight.ToString("N2");
                        txtPesoN.Texts = rawmaterialsMovement.NetWeight.ToString("N2");
                        txtNumeroB.Texts = rawmaterialsMovement.BagsNumber.ToString("N2");

                        this.GrossWeight = Convert.ToDecimal(rawmaterialsMovement.GrossWeight.ToString("N2"));
                        this.ExtraTaraWeight = Convert.ToDecimal(rawmaterialsMovement.ExtraTaraWeight.ToString("N2"));
                        this.IndTaraWeight = Convert.ToDecimal(rawmaterialsMovement.IndTaraWeight.ToString("N2"));
                        this.TotalTaraWeight = Convert.ToDecimal(rawmaterialsMovement.TotalTaraWeight.ToString("N2"));
                        this.NetWeight = Convert.ToDecimal(rawmaterialsMovement.NetWeight.ToString("N2"));
                        this.BagsNumber = Convert.ToDecimal(rawmaterialsMovement.BagsNumber.ToString("N2"));
                    }
                    else
                    {
                        this.cleanFields();
                    }
                }
                else
                {
                    this.cleanFields();
                }
            }
        }
        #endregion

        private void cleanFields()
        {
            txtPesoB.Texts = "0.00";
            txtTaraE.Texts = "0.00";
            txtTaraI.Texts = "0.00";
            txtPesoN.Texts = "0.00";
            txtNumeroB.Texts = "0.00";
        }
        private void btnCapturarPB_Click(object sender, EventArgs e)
        {

            if ((!ValidarTxt.ValidateText(txtPesoB.Texts) || double.TryParse(txtPesoB.Texts, out double n)) && (!ValidarTxt.ValidateText(txtTaraE.Texts) || double.TryParse(txtTaraE.Texts, out double a)) && (!ValidarTxt.ValidateText(txtTaraI.Texts) || double.TryParse(txtTaraI.Texts, out double c)))
            {
                if (Convert.ToDecimal(txtPesoB.Texts.Trim()) > 0 && Convert.ToDecimal(txtTaraE.Texts.Trim()) > 0 && Convert.ToDecimal(txtTaraI.Texts.Trim()) > 0)
                {
                    this.calcularPeso();
                }
                txtPesoB.Texts = "";
                btnCrear.Enabled = true;
                MateriaPrimaController materiaPrimaController = new MateriaPrimaController();

                var pesoBrutoByScan = materiaPrimaController.getPesoPorBalanza();
                btnCapturarPB.Enabled = false;
                Thread.Sleep(1000);
                txtPesoB.Texts = pesoBrutoByScan.ToString();
                btnCapturarPB.Enabled = true;
                if (pesoBrutoByScan.ToString() != string.Empty)
                {
                    txtPesoB.Texts = pesoBrutoByScan.ToString();
                }
                else
                {
                    txtPesoB.Texts = "0.00";
                    MessageBox.Show("La balanza esta devuelviendo una cadena vacia", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //txtPesoB.Texts = OldVal;

            }
            else
            {
                txtPesoB.Texts = "0.00";
                MessageBox.Show("Los campos numericos no deben de estar vacio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnCapturarTE_Click(object sender, EventArgs e)
        {

            if ((!ValidarTxt.ValidateText(txtPesoB.Texts) || double.TryParse(txtPesoB.Texts, out double n)) && (!ValidarTxt.ValidateText(txtTaraE.Texts) || double.TryParse(txtTaraE.Texts, out double a)) && (!ValidarTxt.ValidateText(txtTaraI.Texts) || double.TryParse(txtTaraI.Texts, out double c)))
            {
                btnCrear.Enabled = true;
                MateriaPrimaController materiaPrimaController = new MateriaPrimaController();
                if (Convert.ToDecimal(txtPesoB.Texts.Trim()) > 0 && Convert.ToDecimal(txtTaraE.Texts.Trim()) > 0 && Convert.ToDecimal(txtTaraI.Texts.Trim()) > 0)
                {
                    this.calcularPeso();
                }
                txtTaraE.Texts = "";
                var taraExtraByScan = materiaPrimaController.getPesoPorBalanza();
                btnCapturarTE.Enabled = false;
                Thread.Sleep(1000);
                txtTaraE.Texts = taraExtraByScan.ToString();
                btnCapturarTE.Enabled = true;
                if (taraExtraByScan.ToString() != string.Empty)
                {
                    txtTaraE.Texts = taraExtraByScan.ToString();
                }
                else
                {
                    txtTaraE.Texts = "0.00";
                    MessageBox.Show("La balanza esta devuelviendo una cadena vacia", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                txtTaraE.Texts = "0.00";
                MessageBox.Show("Los campos numericos no deben de estar vacio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (teoricoWeight_validating())
            {
                if (txtProveedores_Validating() && txtProducto_Validating() && txtPlaca_Validating())
                {
                    if (Convert.ToDecimal(txtPesoB.Texts.Trim()) > 0 || Convert.ToDecimal(txtTaraE.Texts.Trim()) > 0 || Convert.ToDecimal(txtTaraI.Texts.Trim()) > 0)
                    {
                        if (txtPesoB_Validating() && txtTaraE_Validating() && txtTaraI_Validating())
                        {

                            var date = txtFecha.Texts.Trim().Split("/");
                            string datetimeRecord = date[2] + "/" + date[1] + "/" + date[0] + " " + txtHora.Texts.Trim();

                            EntryController entryController = new EntryController();
                            MovementController movementController = new MovementController();
                            RawmaterialsMovement rawmaterialsMovement = new RawmaterialsMovement();

                            rawmaterialsMovement.GrossWeight = Convert.ToDecimal(txtPesoB.Texts.Trim());
                            rawmaterialsMovement.ExtraTaraWeight = Convert.ToDecimal(txtTaraE.Texts.Trim());
                            rawmaterialsMovement.IndTaraWeight = Convert.ToDecimal(txtTaraI.Texts.Trim());
                            rawmaterialsMovement.TotalTaraWeight = Convert.ToDecimal(txtTaraT.Texts.Trim());
                            rawmaterialsMovement.NetWeight = Convert.ToDecimal(txtPesoN.Texts.Trim());
                            rawmaterialsMovement.BagsNumber = Convert.ToDecimal(txtNumeroB.Texts.Trim());
                            rawmaterialsMovement.DateHour = DateTime.Parse(datetimeRecord.ToString());

                            GrossWeight = Convert.ToDecimal(txtPesoB.Texts.Trim());
                            ExtraTaraWeight = Convert.ToDecimal(txtTaraE.Texts.Trim());
                            IndTaraWeight = Convert.ToDecimal(txtTaraI.Texts.Trim());
                            TotalTaraWeight = Convert.ToDecimal(txtTaraT.Texts.Trim());
                            NetWeight = Convert.ToDecimal(txtPesoN.Texts.Trim());
                            BagsNumber = Convert.ToDecimal(txtNumeroB.Texts.Trim());

                            if (Convert.ToDecimal(txtPesoB.Texts.Trim()) > 0 && Convert.ToDecimal(txtTaraE.Texts.Trim()) > 0 && Convert.ToDecimal(txtTaraI.Texts.Trim()) > 0)
                            {
                                this.calcularPeso();
                            }

                            if (editMode == true)
                            {
                                movementController.updateMovement(movementId, rawmaterialsMovement);//Actualizar movimento

                                RawmaterialsEntry rawmaterialsEntry = new RawmaterialsEntry();
                                List<RawmaterialsMovement> rawmaterialsMovementList = new List<RawmaterialsMovement>();
                                rawmaterialsMovementList = movementController.movementsValueCalcsByEntryId(entryId);// capturar lista de valores de los movimientos por id de entada
                                rawmaterialsEntry = this.calcularDatosMovimientos(datetimeRecord, rawmaterialsMovementList);

                                entryController.updateEntry(entryId, rawmaterialsEntry);

                                MessageBox.Show("Movimiento se ha actualizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                rawmaterialsMovement.Weigher = MyGlobalsVar.userName;
                                rawmaterialsMovement.RawMaterialEntryId = entryId;
                                movementController.createMovement(rawmaterialsMovement);

                                RawmaterialsEntry rawmaterialsEntry = new RawmaterialsEntry();
                                List<RawmaterialsMovement> rawmaterialsMovementList = new List<RawmaterialsMovement>();
                                rawmaterialsMovementList = movementController.movementsValueCalcsByEntryId(entryId);// capturar lista de valores de los movimientos por id de entada
                                rawmaterialsEntry = this.calcularDatosMovimientos(datetimeRecord, rawmaterialsMovementList);

                                entryController.updateEntry(entryId, rawmaterialsEntry);
                                movementId = movementController.getLastMovemetId();

                                btnCrear.Text = "Actualizar";
                                editMode = true;
                                btnEliminarM.Visible = true;
                                txtFecha.Texts = ObtenerFechaHora.GetFormattedDate();
                                txtHora.Texts = ObtenerFechaHora.GetFormattedTime();


                                MessageBox.Show("Movimiento creado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Campos numericos no deben contener letras, estar vacio o contener valor menor a cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Al menos un campo debe ser diferente a cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Uno o más campos del proveedor se encuentran vacios", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El registro de peso manifestado No es numerico, se encuentra vacio o es menor que cero", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.cleanFields();
            editMode = false;
            btnCrear.Text = "Crear";
        }

        private RawmaterialsEntry calcularDatosMovimientos(string datetimeRecord, List<RawmaterialsMovement> rawmaterialsMovementList)
        {
            RawmaterialsEntry entry = new RawmaterialsEntry();
            decimal grossWeight = 0;
            decimal extrataraWeight = 0;
            decimal IndividualTaraWeight = 0;
            decimal TotalTaraWeight = 0;
            decimal NetWeight = 0;
            decimal BagsNumber = 0;

            foreach (var movement in rawmaterialsMovementList)// sumatoria de todos los valores de movimientos en la entrada
            {
                grossWeight += movement.GrossWeight;
                extrataraWeight += movement.ExtraTaraWeight;
                IndividualTaraWeight += movement.IndTaraWeight;
            }
            NetWeight = grossWeight - (extrataraWeight + IndividualTaraWeight);
            TotalTaraWeight = extrataraWeight + IndividualTaraWeight;
            BagsNumber = NetWeight / Convert.ToDecimal(teoricoWeight);

            entry.ReceivedWeight = NetWeight;
            entry.BagsNumberReceived = BagsNumber;
            entry.DateHour = DateTime.Parse(datetimeRecord.ToString());

            return entry;
        }
        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            string message = "Esta apunto de Eliminar este movimiento, ¿desea Eliminarlo?";
            string title = "Eliminar Movimientos";
            var dialog = MyGlobalsVar.PreClosingCOnfirmation(message, title);
            if (dialog == DialogResult.Yes)
            {
                var date = txtFecha.Texts.Trim().Split("/");
                string datetimeRecord = date[2] + "/" + date[1] + "/" + date[0] + " " + txtHora.Texts.Trim();

                EntryController entryController = new EntryController();
                RawmaterialsEntry rawmaterialsEntry = new RawmaterialsEntry();
                MovementController movementController = new MovementController();
                List<RawmaterialsMovement> rawmaterialsMovementList = new List<RawmaterialsMovement>();
                movementController.deleteMovement(movementId);
                rawmaterialsMovementList = movementController.movementsValueCalcsByEntryId(entryId);// capturar lista de valores de los movimientos por id de entada
                rawmaterialsEntry = this.calcularDatosMovimientos(datetimeRecord, rawmaterialsMovementList);

                entryController.updateEntryWhenCalc(entryId, rawmaterialsEntry);
                MessageBox.Show("Movimiento eliminados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cerrarForm();
            }
        }
        private void txtProveedor_Leave(object sender, EventArgs e)
        {
            txtProveedores_Validating();
        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            txtPlaca_Validating();
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            txtProducto_Validating();
        }

        private void txtPesoB_Leave(object sender, EventArgs e)
        {
            txtPesoB_Validating();
        }

        private void txtTaraE_Leave(object sender, EventArgs e)
        {
            txtTaraE_Validating();
        }

        private void txtTaraI_Leave(object sender, EventArgs e)
        {
            txtTaraI_Validating();
            /*if ((!ValidarTxt.ValidateText(txtPesoB.Texts) || double.TryParse(txtPesoB.Texts, out double n)) && (!ValidarTxt.ValidateText(txtTaraE.Texts) || double.TryParse(txtTaraE.Texts, out double a)) && (!ValidarTxt.ValidateText(txtTaraI.Texts) || double.TryParse(txtTaraI.Texts, out double c)))
            {
                this.calcularPeso();
            }*/
            if (Convert.ToDecimal(txtPesoB.Texts.Trim()) > 0 && Convert.ToDecimal(txtTaraE.Texts.Trim()) > 0 && Convert.ToDecimal(txtTaraI.Texts.Trim()) > 0)
            {
                this.calcularPeso();
            }
            btnCrear.Enabled = true;
        }

        //METODOS PERSONALIZADOS---------------------------------------------------------------------------------------

        private void calcularPeso()
        {
            double pesoBruto = Convert.ToDouble(txtPesoB.Texts.Trim());
            double pesoTaraExtra = Convert.ToDouble(txtTaraE.Texts.Trim());
            double pesoTaraInd = Convert.ToDouble(txtTaraI.Texts.Trim());

            double pesoTaraTotal = pesoTaraExtra + pesoTaraInd;
            double pesoNeto = pesoBruto - (pesoTaraExtra + pesoTaraInd);
            double numeroBultos = pesoNeto / teoricoWeight;

            txtTaraT.Texts = pesoTaraTotal.ToString();
            txtPesoN.Texts = pesoNeto.ToString();
            txtNumeroB.Texts = numeroBultos.ToString();

        }

        ErrorProvider errorProveedor = new ErrorProvider();
        ErrorProvider errorProducto = new ErrorProvider();
        ErrorProvider errorPlaca = new ErrorProvider();
        ErrorProvider errorPesoB = new ErrorProvider();
        ErrorProvider errorTaraE = new ErrorProvider();
        ErrorProvider errorTaraI = new ErrorProvider();
        //Validaciones
        private bool txtProveedores_Validating()
        {

            if (ValidarTxt.ValidateText(txtProveedor.Texts))
            {
                errorProveedor.SetIconPadding(txtProveedor, -30);
                errorProveedor.SetError(txtProveedor, "El campo Proveedor no debe estar vaacio");
                return false;
            }
            else
            {
                errorProveedor.Clear();

                return true;
            }
        }

        private bool txtProducto_Validating()
        {
            if (ValidarTxt.ValidateText(txtProducto.Texts))
            {
                errorProducto.SetIconPadding(txtProducto, -30);
                errorProducto.SetError(txtProducto, "El campo Producto no debe estar vaacio");
                return false;
            }
            else
            {
                errorProducto.Clear();
                return true;
            }
        }

        private bool txtPlaca_Validating()
        {
            if (ValidarTxt.ValidateText(txtPlaca.Texts))
            {
                errorPlaca.SetIconPadding(txtPlaca, -30);
                errorPlaca.SetError(txtPlaca, "EL campo Placa no debe estar vacio");
                return false;
            }
            else
            {
                errorPlaca.Clear();
                return true;
            }
        }

        private bool txtPesoB_Validating()
        {
            if (ValidarTxt.ValidateText(txtPesoB.Texts))
            {
                errorPesoB.SetIconPadding(txtPesoB, -30);
                errorPesoB.SetError(txtPesoB, "El campo Peso Bruto no puede estar vacio");
                return false;
            }
            if (!double.TryParse(txtPesoB.Texts, out double n))
            {
                errorPesoB.SetIconPadding(txtPesoB, -30);
                errorPesoB.SetError(txtPesoB, "El campo Peso Bruto solo puede contener números");
                return false;
            }
            /*if (double.Parse(txtPesoB.Texts) <= 0)
            {
                errorPesoB.SetIconPadding(txtPesoB, -30);
                errorPesoB.SetError(txtPesoB, "No se permiten valores menores o igual a cero");
                return false;
            }*/
            else
            {
                errorPesoB.Clear();
                return true;
            }
        }
        private bool txtTaraE_Validating()
        {
            if (ValidarTxt.ValidateText(txtTaraE.Texts))
            {
                errorTaraE.SetIconPadding(txtTaraE, -30);
                errorTaraE.SetError(txtTaraE, "El campo Tara Extra no puede estar vacio");
                return false;
            }
            if (!double.TryParse(txtTaraE.Texts, out double n))
            {
                errorTaraE.SetIconPadding(txtTaraE, -30);
                errorTaraE.SetError(txtTaraE, "El campo Tara Extra solo puede contener números");
                return false;
            }
            /*if (double.Parse(txtTaraE.Texts) < 0)
            {
                errorTaraE.SetIconPadding(txtTaraE, -30);
                errorTaraE.SetError(txtTaraE, "No se permiten valores menores a cero");
                return false;
            }*/
            else
            {
                errorTaraE.Clear();
                return true;
            }
        }
        private bool txtTaraI_Validating()
        {
            if (ValidarTxt.ValidateText(txtTaraI.Texts))
            {
                errorTaraI.SetIconPadding(txtTaraI, -30);
                errorTaraI.SetError(txtTaraI, "El campo Tara Individual no puede estar vacio");
                return false;
            }
            if (!double.TryParse(txtTaraI.Texts, out double n))
            {
                errorTaraI.SetIconPadding(txtTaraI, -30);
                errorTaraI.SetError(txtTaraI, "El campo Tara Individual solo puede contener números");
                return false;
            }
            /*if (double.Parse(txtTaraI.Texts) < 0)
            {
                errorTaraI.SetIconPadding(txtTaraI, -30);
                errorTaraI.SetError(txtTaraI, "No se permiten valores menores a cero");
                return false;
            }*/
            else
            {
                errorTaraI.Clear();
                return true;
            }
        }

        private bool teoricoWeight_validating()
        {
            if (ValidarTxt.ValidateText(teoricoWeight.ToString()))
            {
                errorTaraI.SetIconPadding(lblPesoTeorico, -50);
                errorTaraI.SetError(lblPesoTeorico, "EL registro de peso Manifestado se encuentra vacio, verifique en el formulario correspondiente");
                return false;
            }
            if (!double.TryParse(teoricoWeight.ToString(), out double n))
            {
                errorTaraI.SetIconPadding(lblPesoTeorico, -50);
                errorTaraI.SetError(lblPesoTeorico, "El registro de peso Manifestado no es numerico, verifique en el formulario correspondiente");
                return false;
            }
            if (teoricoWeight <= 0)
            {
                errorTaraI.SetIconPadding(lblPesoTeorico, -50);
                errorTaraI.SetError(lblPesoTeorico, "El registro de peso Manifestado no debe contener un valor menos a cero, verifique en el formulario correspondiente");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void cerrarForm()
        {
            VistaMateriaPrima vistaMateriaPrimaForm = new VistaMateriaPrima();
            //Definir MDI parent
            vistaMateriaPrimaForm.MdiParent = (mainMenuForm)this.Parent.Parent;
            vistaMateriaPrimaForm.Show();
            Close();
        }


    }
}
