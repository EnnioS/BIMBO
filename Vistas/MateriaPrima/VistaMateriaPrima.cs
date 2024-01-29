using Presentacion.Vistas.MateriaPrima;
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
using Negocio.Controllers;
using Entities.DTO;
using Entities.Data;
using Entities.Entities;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Configuration.Provider;

namespace Presentacion.Vistas.MateriaPrima
{
    public partial class VistaMateriaPrima : Form
    {

        ListViewItem listViewEntries;
        ListViewItem listViewMovements;

        int selectedEntryId = 0;
        int selectedMovementId = 0;
        double teoricoWeight = 0.0000000000;
        public VistaMateriaPrima()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            mainMenuForm p = (mainMenuForm)this.MdiParent;
            System.Windows.Forms.Control[] c = p.Controls.Find("mcMainBtnContainer", true);
            MaterialCard b = (MaterialCard)c[0];
            b.Visible = true;
            Close();
        }

        private void btnNuevoBalanza_Click(object sender, EventArgs e)
        {
            EntradaPorPesoBalanza formMPEntradaXBalanza = new EntradaPorPesoBalanza();
            //Definir MDI parent
            formMPEntradaXBalanza.MdiParent = (mainMenuForm)this.Parent.Parent;
            formMPEntradaXBalanza.Show();

        }

        private void btnNuevoTeorico_Click(object sender, EventArgs e)
        {
            EntradaPorPesoTeorico formMPEntradaXPTeorico = new EntradaPorPesoTeorico();
            //Definir MDI parent
            formMPEntradaXPTeorico.MdiParent = (mainMenuForm)this.Parent.Parent;
            formMPEntradaXPTeorico.Show();
            Close();
        }

        private void VistaMateriaPrima_Load(object sender, EventArgs e)
        {

            EntryController entryController = new EntryController();

            lvEntries.Items.Clear();//Limpia los datos de la lista
            List<RawmaterialsEntryDTO> lEntriesDTO = new List<RawmaterialsEntryDTO>();
            lEntriesDTO = entryController.getEntries();
            var countEntries = lEntriesDTO.Count();// contando cantidad de registro en tabla usuario

            if (countEntries > 0)
            {
                for (var i = 0; i < countEntries; i++)
                {
                    listViewEntries = new ListViewItem(lEntriesDTO[i].RawmaterialId.ToString());

                    //Agregando datos a la lista
                    listViewEntries.SubItems.Add(lEntriesDTO[i].ProductName);
                    listViewEntries.SubItems.Add(lEntriesDTO[i].ProviderName.Trim());
                    listViewEntries.SubItems.Add(lEntriesDTO[i].PlateNumber.Trim());
                    listViewEntries.SubItems.Add(lEntriesDTO[i].RecordDate.ToString().Trim());
                    listViewEntries.SubItems.Add(lEntriesDTO[i].teoricoWeight.ToString("N2").Trim());
                    listViewEntries.SubItems.Add(lEntriesDTO[i].BagsNumber.ToString("N2").Trim());
                    listViewEntries.SubItems.Add(lEntriesDTO[i].ReceivedWeight.ToString("N2").Trim());
                    listViewEntries.SubItems.Add(lEntriesDTO[i].BagsNumberReceived.ToString("N2").Trim());
                    listViewEntries.SubItems.Add(lEntriesDTO[i].ProviderId.ToString().Trim());
                    listViewEntries.SubItems.Add(lEntriesDTO[i].EntryId.ToString().Trim());
                    lvEntries.Items.Add(listViewEntries);
                }



            }
            MovementController movementController = new MovementController();
            lvMovements.Items.Clear();//Limpia los datos de la lista
            List<RawmaterialsMovementDTO> lMovemetsDTO = new List<RawmaterialsMovementDTO>();
            lMovemetsDTO = movementController.getMovement();
            var countMovements = lMovemetsDTO.Count();// contando cantidad de registro en tabla usuario

            if (countMovements > 0)
            {
                for (var i = 0; i < countMovements; i++)
                {
                    listViewMovements = new ListViewItem(lMovemetsDTO[i].RawmaterialId.ToString().Trim());

                    //Agregando datos a la lista

                    listViewMovements.SubItems.Add(lMovemetsDTO[i].ProductName.Trim());
                    listViewMovements.SubItems.Add(lMovemetsDTO[i].ProviderName.Trim());
                    listViewMovements.SubItems.Add(lMovemetsDTO[i].PesoManifestado.ToString("N2").Trim());
                    listViewMovements.SubItems.Add(lMovemetsDTO[i].RMovementID.ToString().Trim());
                    listViewMovements.SubItems.Add(lMovemetsDTO[i].EntryId.ToString().Trim());
                    listViewMovements.SubItems.Add(lMovemetsDTO[i].PesoTeorico.ToString("N2").Trim());
                    listViewMovements.SubItems.Add(lMovemetsDTO[i].GrossWeight.ToString("N2").Trim());
                    listViewMovements.SubItems.Add(lMovemetsDTO[i].TaraExtraWeight.ToString("N2").Trim());
                    listViewMovements.SubItems.Add(lMovemetsDTO[i].TaraIndividualWeight.ToString("N2").Trim());
                    lvMovements.Items.Add(listViewMovements);
                }

            }

        }

        private void lvEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Selected Index changes");
        }

        private void lvMovements_MouseDown(object sender, MouseEventArgs e)
        {
            /*
                selectedEntryId = 0;
                selectedMovementId = 0;
                teoricoWeight = 0;

                try
                {


                    if (lvMovements.SelectedIndices.Count <= 0)
                    {
                        selectedEntryId = 0;
                        selectedMovementId = 0;
                        teoricoWeight = 0;
                        return;
                    }


                    teoricoWeight = Convert.ToDouble(lvMovements.SelectedItems[0].SubItems[3].Text.Trim());
                    selectedMovementId = Int32.Parse(lvMovements.SelectedItems[0].SubItems[4].Text);
                    selectedEntryId = Int32.Parse(lvMovements.SelectedItems[0].SubItems[5].Text);


                    // MessageBox.Show(selectedMovementId.ToString() + " - " + selectedEntryId.ToString());

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error del sistema VMPF-003: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }*/

        }

        private void btnPesoT_Click(object sender, EventArgs e)
        {
            EntryController entryController = new EntryController();
            MovementController movementController = new MovementController();
            var searchText = txtPesoT.Texts.Trim();
            this.getEntriesByProductId(searchText);
            this.getMovementByProductId(searchText);
        }

        private void getEntriesByProductId(string searchText)
        {
            EntryController entryController = new EntryController();
            List<RawmaterialsEntryDTO> entriesList = new List<RawmaterialsEntryDTO>();

            entriesList = entryController.getEntriesByProductId(searchText);

            lvEntries.Items.Clear();

            foreach (var entries in entriesList)
            {
                ListViewItem entriesItem = new ListViewItem(
                    entries.RawmaterialId.ToString()
                    );
                entriesItem.SubItems.Add(entries.ProductName.Trim());
                entriesItem.SubItems.Add(entries.ProviderName.Trim());
                entriesItem.SubItems.Add(entries.PlateNumber.Trim());
                entriesItem.SubItems.Add(entries.RecordDate.ToString());
                entriesItem.SubItems.Add(entries.teoricoWeight.ToString("N2"));
                entriesItem.SubItems.Add(entries.BagsNumber.ToString("N2"));
                entriesItem.SubItems.Add(entries.ReceivedWeight.ToString("N2"));
                entriesItem.SubItems.Add(entries.BagsNumberReceived.ToString("N2"));
                entriesItem.SubItems.Add(entries.ProviderId.Trim());
                entriesItem.SubItems.Add(entries.EntryId.ToString());

                //Agregando lista al componente listview
                lvEntries.Items.Add(entriesItem);

            }
        }

        private void getMovementByProductId(string searchText)
        {
            MovementController movementController = new MovementController();
            List<RawmaterialsMovementDTO> movementsList = new List<RawmaterialsMovementDTO>();

            movementsList = movementController.getMovementByProductId(searchText);

            lvMovements.Items.Clear();

            foreach (var movements in movementsList)
            {
                ListViewItem entriesItem = new ListViewItem(
                    movements.RawmaterialId.ToString()
                    );
                entriesItem.SubItems.Add(movements.ProductName.Trim());
                entriesItem.SubItems.Add(movements.ProviderName.Trim());
                entriesItem.SubItems.Add(movements.PesoManifestado.ToString("N2").Trim());
                entriesItem.SubItems.Add(movements.RMovementID.ToString().Trim());
                entriesItem.SubItems.Add(movements.EntryId.ToString().Trim());
                entriesItem.SubItems.Add(movements.PesoTeorico.ToString("N2").Trim());
                entriesItem.SubItems.Add(movements.GrossWeight.ToString("N2").Trim());
                entriesItem.SubItems.Add(movements.TaraExtraWeight.ToString("N2").Trim());
                entriesItem.SubItems.Add(movements.TaraIndividualWeight.ToString("N2").Trim());

                //Agregando lista al componente listview
                lvMovements.Items.Add(entriesItem);

            }
        }

        private void lvEntries_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = lvEntries.SelectedItems[0];
            string[] arrayMovement = {
                item.SubItems[0].Text.Trim(),
                item.SubItems[1].Text.Trim(),
                item.SubItems[2].Text.Trim(),
                item.SubItems[3].Text.Trim(),
                item.SubItems[4].Text.Trim(),
                item.SubItems[5].Text.Trim(),
                item.SubItems[6].Text.Trim(),
                item.SubItems[7].Text.Trim(),
                item.SubItems[8].Text.Trim(),
                item.SubItems[9].Text.Trim(),
                item.SubItems[10].Text.Trim()
            };
            EntradaPorPesoTeorico pesoTeoricoForm = new EntradaPorPesoTeorico(arrayMovement);
            //Definir MDI parent
            pesoTeoricoForm.MdiParent = (mainMenuForm)this.Parent.Parent;
            pesoTeoricoForm.Show();
        }

        private void lvMovements_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var item = lvMovements.SelectedItems[0];
            string[] arrayMovement = {
                item.SubItems[0].Text.Trim(),
                item.SubItems[1].Text.Trim(),
                item.SubItems[2].Text.Trim(),
                item.SubItems[3].Text.Trim(),
                item.SubItems[4].Text.Trim(),
                item.SubItems[5].Text.Trim(),
                item.SubItems[6].Text.Trim()
            };


            EntradaPorPesoBalanza formMPEntradaXBalanza = new EntradaPorPesoBalanza(arrayMovement);
            //Definir MDI parent
            formMPEntradaXBalanza.MdiParent = (mainMenuForm)this.Parent.Parent;
            formMPEntradaXBalanza.Show();
            Close();
        }
    }
}
