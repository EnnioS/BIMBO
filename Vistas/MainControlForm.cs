using Presentacion.Vistas;
using Presentacion.Vistas.Reportes;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvDTE;
using Negocio.Utilities;
using Presentacion.Vistas.MateriaPrima;

namespace Presentacion.Vistas
{
    public partial class mainMenuForm : Form
    {

        public string _roleName;
        public string _userName;
        public mainMenuForm()
        {
            InitializeComponent();
        }

        public mainMenuForm(LoginForm login, string userName, string roleName)
        {
            InitializeComponent();
            _roleName = roleName;
            _userName = userName;
            this.KeyPreview = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingCOnfirmation() == DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private DialogResult PreClosingCOnfirmation()
        {
            DialogResult res = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return res;
        }

        private void btnGestionMP_MouseHover(object sender, EventArgs e)
        {
            btnGestionMP.TextColor = Color.White;
        }

        private void btnGestionMP_MouseLeave(object sender, EventArgs e)
        {
            btnGestionMP.TextColor = Color.Black;
        }

        private void btnGestionUsuario_Click(object sender, EventArgs e)
        {
            GestionarUsuario formUsuario = new GestionarUsuario();
            //Definir MDI parent
            formUsuario.MdiParent = this;
            if (!formUsuario.Visible)
            {
                mcMainBtnContainer.Visible = false;

                formUsuario.Show();
            }
        }

        private void btnGestionProveedor_Click(object sender, EventArgs e)
        {
            GestionarProveedor formProveedor = new GestionarProveedor();
            //Definir MDI parent
            formProveedor.MdiParent = this;
            if (!formProveedor.Visible)
            {
                mcMainBtnContainer.Visible = false;

                formProveedor.Show();
            }
        }

        private void btnGestionMP_Click(object sender, EventArgs e)
        {
            GestionarMateriaPrima formMateriaPrima = new GestionarMateriaPrima();
            //Definir MDI parent
            formMateriaPrima.MdiParent = this;
            if (!formMateriaPrima.Visible)
            {
                mcMainBtnContainer.Visible = false;

                formMateriaPrima.Show();
            }
        }

        private void mainMenuForm_Load(object sender, EventArgs e)
        {

            MyGlobalsVar.userName = _userName;
            MyGlobalsVar.RollName = _roleName;

            lblUserName.Text = "¡Bienvenido! " + _userName + " - " + _roleName;
            if (_roleName == "General")
            {
                grpGestionUser.Enabled = false;
                grpGestionMateria.Enabled = false;
                grpGestionProveedores.Enabled = false;
                grpEntradaMateria.Enabled = true;
                grpReporte.Enabled = true;
            }
            else if (_roleName == "Entrada de Datos")
            {
                grpGestionUser.Enabled = false;
                grpGestionMateria.Enabled = true;
                grpGestionProveedores.Enabled = true;
                grpEntradaMateria.Enabled = false;
                grpReporte.Enabled = false;
            }
            else if (_roleName == "Administrador")
            {
                grpGestionUser.Enabled = true;
                grpGestionMateria.Enabled = true;
                grpGestionProveedores.Enabled = true;
                grpEntradaMateria.Enabled = true;
                grpReporte.Enabled = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedBtn4_Click(object sender, EventArgs e)
        {
            VistaMateriaPrima formVistaMP = new VistaMateriaPrima();
            //Definir MDI parent
            formVistaMP.MdiParent = this;
            if (!formVistaMP.Visible)
            {
                mcMainBtnContainer.Visible = false;

                formVistaMP.Show();
            }
        }

        private void btnGestionReportes_Click(object sender, EventArgs e)
        {
            ReportesForm formReportes = new ReportesForm();
            //Definir MDI parent
            formReportes.MdiParent = this;
            if (!formReportes.Visible)
            {
                mcMainBtnContainer.Visible = false;

                formReportes.Show();
            }
        }
    }
}
