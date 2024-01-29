using Entities.DTO;
using Entities.Entities;
using MaterialSkin.Controls;
using Negocio.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Vistas.Reportes
{
    public partial class ReportesForm : Form
    {
        public ReportesForm()
        {
            InitializeComponent();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked == true)
            {
                lblDesde.Visible = false;
                lblHasta.Visible = false;
                dpDesde.Visible = false;
                dpHasta.Visible = false;
            }
            else
            {
                lblDesde.Visible = true;
                lblHasta.Visible = true;
                dpDesde.Visible = true;
                dpHasta.Visible = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            mainMenuForm p = (mainMenuForm)this.MdiParent;
            Control[] c = p.Controls.Find("mcMainBtnContainer", true);
            MaterialCard b = (MaterialCard)c[0];
            b.Visible = true;
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            int tipo = 0;
            string fileName = "";
            int selectedItem = cbReportes.SelectedIndex;
            string desde = dpDesde.Text;
            string hasta = dpHasta.Text;


            switch (selectedItem)
            {
                case 0://Proveedores
                    ProviderController providerController = new ProviderController();
                    tipo = selectedItem;
                    if (rbPorFecha.Checked != true)
                    {
                        fileName = "RPT_Proveedores";
                        providerController.providerList(fileName, tipo);
                    }
                    else
                    {
                        ListView lsProv = lvProvider;
                        fileName = "RPT_ProveedoresXFecha";
                        providerController.exportToExcelListViewProviderDataByDate(lsProv, fileName);
                    }
                    break;
                case 1://Productos
                    MateriaPrimaController materiaPrimaController = new MateriaPrimaController();
                    tipo = selectedItem;
                    if (rbPorFecha.Checked != true)
                    {
                        fileName = "RPT_Productos";
                        materiaPrimaController.productList(fileName, tipo);
                    }
                    else
                    {
                        ListView lsProd = lvProduct;
                        fileName = "RPT_ProductosXFecha";
                        materiaPrimaController.exportToExcelListViewProductosDataByDate(lsProd, fileName);
                    }

                    break;
                case 2://Productos por proveedores
                    ProviderRawmaterialController providerRawmaterialController = new ProviderRawmaterialController();
                    tipo = selectedItem;
                    if (rbPorFecha.Checked != true)
                    {
                        fileName = "RPT_Productos_X_Proveedores";
                        providerRawmaterialController.productoProveedorList(fileName, tipo);
                    }
                    else
                    {
                        ListView lsProdProv = lvProvProduct;
                        fileName = "RPT_ProductoXProveedorXFecha";
                        providerRawmaterialController.exportToExcelListViewProdProdDataByDate(lsProdProv, fileName);
                    }

                    break;
                case 3://Por peso teórico
                    EntryController entryController = new EntryController();
                    tipo = selectedItem;
                    if (rbPorFecha.Checked != true)
                    {
                        fileName = "RPT_Entradas_X_peso_teorico";
                        entryController.entriesList(fileName, tipo);
                    }
                    else
                    {
                        ListView lsEntry = lvEntry;
                        fileName = "RPT_EntradasXpesoTeoricoXFecha";
                        entryController.exportToExcelListViewEntriesDataByDate(lsEntry, fileName);
                    }

                    break;
                case 4://Por Movimiento
                    MovementController movementController = new MovementController();
                    tipo = selectedItem;
                    if (rbPorFecha.Checked != true)
                    {
                        fileName = "RPT_Entradas_X_peso_balanza";
                        movementController.movementsList(fileName, tipo);
                    }
                    else
                    {
                        ListView lsMovement = lvMovement;
                        fileName = "RPT_EntradasXpesoBalanzaXFecha";
                        movementController.exportToExcelListViewMovementsDataByDate(lsMovement, fileName);
                    }

                    break;
            }


        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            int selectedItem = cbReportes.SelectedIndex;
            var desde = dpDesde.Text.Trim();
            var hasta = dpHasta.Text.Trim();


            switch (selectedItem)
            {
                case 0://Proveedores
                    lvEntry.Visible = false;
                    lvProduct.Visible = false;
                    lvProvider.Visible = true;
                    lvMovement.Visible = false;
                    lvProvProduct.Visible = false;

                    IEnumerable<Provider> providerList = new List<Provider>();
                    ProviderController providerController = new ProviderController();
                    if (rbTodos.Checked == true)
                    {
                        providerList = providerController.providerList();
                    }
                    else
                    {
                        providerList = providerController.providerListByDates(desde, hasta);
                    }
                    this.llenarListViewProveedor(providerList);
                    break;
                case 1://Productos
                    lvEntry.Visible = false;
                    lvProduct.Visible = true;
                    lvProvider.Visible = false;
                    lvMovement.Visible = false;
                    lvProvProduct.Visible = false;

                    IEnumerable<Rawmaterial> productList = new List<Rawmaterial>();
                    MateriaPrimaController materiaPrimaController = new MateriaPrimaController();
                    if (rbTodos.Checked == true)
                    {
                        productList = materiaPrimaController.productList();
                    }
                    else
                    {
                        productList = materiaPrimaController.productListByDates(desde, hasta);
                    }
                    this.llenarListViewProduct(productList);
                    break;
                case 2://Productos por proveedores
                    lvEntry.Visible = false;
                    lvProduct.Visible = false;
                    lvProvider.Visible = false;
                    lvMovement.Visible = false;
                    lvProvProduct.Visible = true;

                    IEnumerable<ProviderProductDTO> productProviderList = new List<ProviderProductDTO>();
                    ProviderRawmaterialController providerRawmaterialController = new ProviderRawmaterialController();
                    if (rbTodos.Checked == true)
                    {
                        productProviderList = providerRawmaterialController.productoProveedorList();
                    }
                    else
                    {
                        productProviderList = providerRawmaterialController.productoProveedorListByDates(desde, hasta);
                    }
                    this.llenarListViewProviderProduct(productProviderList);
                    break;
                case 3://Por peso teórico
                    lvEntry.Visible = true;
                    lvProduct.Visible = false;
                    lvProvider.Visible = false;
                    lvMovement.Visible = false;
                    lvProvProduct.Visible = false;
                    IEnumerable<RawmaterialsEntryDTO> entriesList = new List<RawmaterialsEntryDTO>();
                    EntryController entryController = new EntryController();
                    if (rbTodos.Checked == true)
                    {
                        entriesList = entryController.entriesList();
                    }
                    else
                    {
                        entriesList = entryController.entriesListByDates(desde, hasta);
                    }
                    this.llenarListViewEntry(entriesList);
                    break;
                case 4://Por peso balanza
                    lvEntry.Visible = false;
                    lvProduct.Visible = false;
                    lvProvider.Visible = false;
                    lvMovement.Visible = true;
                    lvProvProduct.Visible = false;
                    IEnumerable<RawmaterialsMovementDTO> movementsList = new List<RawmaterialsMovementDTO>();
                    MovementController movementController = new MovementController();
                    if (rbTodos.Checked == true)
                    {
                        movementsList = movementController.movementsList();
                    }
                    else
                    {
                        movementsList = movementController.movementListByDates(desde, hasta);
                    }
                    this.llenarListViewMovement(movementsList);
                    break;
                default://Proveedores
                    lvEntry.Visible = false;
                    lvProduct.Visible = true;
                    lvProvider.Visible = false;
                    lvMovement.Visible = false;
                    lvProvProduct.Visible = false;

                    IEnumerable<Rawmaterial> productListDef = new List<Rawmaterial>();
                    MateriaPrimaController materiaPrimaControllerDef = new MateriaPrimaController();
                    if (rbTodos.Checked == true)
                    {
                        productListDef = materiaPrimaControllerDef.productList();
                    }
                    else
                    {
                        productListDef = materiaPrimaControllerDef.productListByDates(desde, hasta);
                    }
                    this.llenarListViewProduct(productListDef);
                    break;
            }
        }

        private void llenarListViewProveedor(IEnumerable<Provider> providerList)
        {
            lvProvider.Items.Clear();
            List<Provider> lprov = new List<Provider>();
            lprov = (List<Provider>)providerList;

            for (var i = 0; i < lprov.Count(); i++)
            {
                ListViewItem providerItem = new ListViewItem(lprov[i].Id.ToString());

                //Agregando datos a la lista
                providerItem.SubItems.Add(lprov[i].Name.Trim());
                providerItem.SubItems.Add(lprov[i].Address.Trim());
                if (lprov[i].Tel2 != string.Empty)
                {
                    providerItem.SubItems.Add(lprov[i].Tel1.Trim() + " / " + lprov[i].Tel2.Trim());
                }
                else
                {
                    providerItem.SubItems.Add(lprov[i].Tel1.Trim());
                }

                providerItem.SubItems.Add(lprov[i].Email.Trim());
                providerItem.SubItems.Add(lprov[i].Contact.Trim());
                providerItem.SubItems.Add(lprov[i].CreatedAt.ToString("dd'/'MM'/'yyyy' 'HH':'mm':'ss").Trim());
                if (lprov[i].Acrive == true)
                {
                    providerItem.SubItems.Add("Activo");
                }
                else
                {
                    providerItem.SubItems.Add("Inactivo");
                }

                //Agregando lista al componente listview
                lvProvider.Items.Add(providerItem);
            }
        }
        private void llenarListViewProduct(IEnumerable<Rawmaterial> productList)
        {
            lvProduct.Items.Clear();
            List<Rawmaterial> lprod = new List<Rawmaterial>();
            lprod = (List<Rawmaterial>)productList;

            for (var i = 0; i < lprod.Count(); i++)
            {
                ListViewItem prodItem = new ListViewItem(lprod[i].Id.ToString());

                //Agregando datos a la lista
                prodItem.SubItems.Add(lprod[i].Description.Trim());
                prodItem.SubItems.Add(lprod[i].CreatedAt.ToString("dd'/'MM'/'yyyy' 'HH':'mm':'ss").Trim());
                prodItem.SubItems.Add(lprod[i].NetWeight.ToString("N2").Trim());
                prodItem.SubItems.Add(lprod[i].Tara.ToString("N2").Trim());
                prodItem.SubItems.Add(lprod[i].PricePerKg.ToString("N2").Trim());
                if (lprod[i].Active == true)
                {
                    prodItem.SubItems.Add("Activo");
                }
                else
                {
                    prodItem.SubItems.Add("Inactivo");
                }

                //Agregando lista al componente listview
                lvProduct.Items.Add(prodItem);

            }
        }

        private void llenarListViewProviderProduct(IEnumerable<ProviderProductDTO> providerproductList)
        {
            lvProvProduct.Items.Clear();
            List<ProviderProductDTO> lprovprod = new List<ProviderProductDTO>();
            lprovprod = (List<ProviderProductDTO>)providerproductList;

            for (var i = 0; i < lprovprod.Count(); i++)
            {
                ListViewItem providerItem = new ListViewItem(lprovprod[i].ProductId.Trim());

                //Agregando datos a la lista
                providerItem.SubItems.Add(lprovprod[i].ProductName.Trim());
                providerItem.SubItems.Add(lprovprod[i].ProviderName.Trim());
                providerItem.SubItems.Add(lprovprod[i].RecordDate.ToString("dd'/'MM'/'yyyy' 'HH':'mm':'ss").Trim());
                if (lprovprod[i].ProviderIsActive == true)
                {
                    providerItem.SubItems.Add("Activo");
                }
                else
                {
                    providerItem.SubItems.Add("Inactivo");
                }

                //Agregando lista al componente listview
                lvProvProduct.Items.Add(providerItem);

            }
        }

        private void llenarListViewEntry(IEnumerable<RawmaterialsEntryDTO> entrylist)
        {
            lvEntry.Items.Clear();
            List<RawmaterialsEntryDTO> lEntry = new List<RawmaterialsEntryDTO>();
            lEntry = (List<RawmaterialsEntryDTO>)entrylist;

            for (var i = 0; i < lEntry.Count(); i++)
            {
                string porcDesv = (((lEntry[i].ReceivedWeight / lEntry[i].teoricoWeight) * 100) - 100).ToString("N2");
                ListViewItem providerItem = new ListViewItem(lEntry[i].RecordDate.ToString("dd'/'MM'/'yyyy' 'HH':'mm':'ss").Trim());

                //Agregando datos a la lista
                providerItem.SubItems.Add(lEntry[i].RawmaterialId.Trim());
                providerItem.SubItems.Add(lEntry[i].ProductName.Trim());
                providerItem.SubItems.Add(lEntry[i].ProviderId.Trim());
                providerItem.SubItems.Add(lEntry[i].ProviderName.Trim());
                providerItem.SubItems.Add(lEntry[i].PlateNumber.Trim());
                providerItem.SubItems.Add(lEntry[i].Weigher.Trim());
                providerItem.SubItems.Add(lEntry[i].BagsNumber.ToString("N2").Trim());
                providerItem.SubItems.Add(lEntry[i].teoricoWeight.ToString("N2").Trim());
                providerItem.SubItems.Add(lEntry[i].BagsNumberReceived.ToString("N2").Trim());
                providerItem.SubItems.Add(lEntry[i].ReceivedWeight.ToString("N2").Trim());
                providerItem.SubItems.Add(porcDesv.Trim());
                if (lEntry[i].Active == true)
                {
                    providerItem.SubItems.Add("NO");
                }
                else
                {
                    providerItem.SubItems.Add("SI");
                }
                if (-0.9 <= double.Parse(porcDesv) && double.Parse(porcDesv) <= 0.9)
                {
                    providerItem.SubItems.Add("Aceptable");
                }
                else if (double.Parse(porcDesv) > 0.9)
                {
                    providerItem.SubItems.Add("En este caso tendría que solicitar que facturen los kg entregados demás ya que se pasa del % aceptable");
                }
                else if (double.Parse(porcDesv) < -0.9)
                {
                    providerItem.SubItems.Add("En este caso tendría que solicitar una NC porque se pasa del % aceptable");
                }

                //Agregando lista al componente listview
                lvEntry.Items.Add(providerItem);

            }
        }

        private void llenarListViewMovement(IEnumerable<RawmaterialsMovementDTO> movementList)
        {
            lvMovement.Items.Clear();
            List<RawmaterialsMovementDTO> lMov = new List<RawmaterialsMovementDTO>();
            lMov = (List<RawmaterialsMovementDTO>)movementList;

            for (var i = 0; i < lMov.Count(); i++)
            {
                ListViewItem providerItem = new ListViewItem(lMov[i].RecordDate.ToString("dd'/'MM'/'yyyy' 'HH':'mm':'ss").Trim());
                //Agregando datos a la lista
                providerItem.SubItems.Add(lMov[i].RawmaterialId.Trim());
                providerItem.SubItems.Add(lMov[i].ProductName.Trim());
                providerItem.SubItems.Add(lMov[i].ProviderName.ToString().Trim());
                providerItem.SubItems.Add(lMov[i].Weigher.Trim());
                providerItem.SubItems.Add(lMov[i].TaraIndividualWeight.ToString("N2").Trim());
                providerItem.SubItems.Add(lMov[i].TaraExtraWeight.ToString("N2").Trim());
                providerItem.SubItems.Add(lMov[i].PesoTeorico.ToString("N2").Trim());
                if (lMov[i].Active == true)
                {
                    providerItem.SubItems.Add("NO");
                }
                else
                {
                    providerItem.SubItems.Add("SI");
                }

                //Agregando lista al componente listview
                lvMovement.Items.Add(providerItem);

            }
        }

        private void ReportesForm_Load(object sender, EventArgs e)
        {

            cbReportes.SelectedIndex = 1;
            dpDesde.Format = DateTimePickerFormat.Custom;
            dpDesde.CustomFormat = "dd/MM/yyyy";
            lvProduct.Visible = true;
            IEnumerable<Rawmaterial> productListDef = new List<Rawmaterial>();
            MateriaPrimaController materiaPrimaControllerDef = new MateriaPrimaController();
            productListDef = materiaPrimaControllerDef.productList();
            this.llenarListViewProduct(productListDef);
        }
    }
}
