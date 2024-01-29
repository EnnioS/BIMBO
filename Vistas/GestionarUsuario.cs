using Presentacion.Controles;
using Negocio.Utilities.Validaciones;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

namespace Presentacion.Vistas
{


    public partial class GestionarUsuario : Form
    {
        private static ErrorProvider errorPName = new ErrorProvider();
        private static ErrorProvider errorPLast = new ErrorProvider();
        private static ErrorProvider errorPEmail = new ErrorProvider();
        private static ErrorProvider errorPPass = new ErrorProvider();
        private static ErrorProvider errorPUName = new ErrorProvider();
        int idUser = 0;
        public GestionarUsuario()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void GestionarUsuario_Load(object sender, EventArgs e)
        {
            this.LlenarListViewUser();
        }

        //Cerrar Formualario y poner visible control contenedor de botones del dashboard
        private void btnCerrar_Click(object sender, EventArgs e)
        {

            mainMenuForm p = (mainMenuForm)this.MdiParent;
            Control[] c = p.Controls.Find("mcMainBtnContainer", true);
            MaterialCard b = (MaterialCard)c[0];
            b.Visible = true;
            Close();


        }

        //Agregar NUevo Usuario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var nombre = txtFirstName.Texts.Trim();
            var apellido = txtLastName.Texts.Trim();
            var usuario = txtNomUser.Texts.Trim();
            var pass = txtPass.Texts;
            var email = txtEmail.Texts.Trim();

            if (txtFirstName_Validating() && txtLastName_Validating() && txtEmail_Validating() && txtPass_Validating())
            {
                try
                {
                    using (var _db1 = new BimDb1Context())
                    {
                        //Crear usuario
                        if (idUser <= 0)
                        {
                            if (txtNomUser_Validating())
                            {

                                var users = new Entities.Entities.User();
                                users.FirstName = nombre.Trim();
                                users.LastName = apellido.Trim();
                                users.UserName = usuario.Trim();
                                users.Password = pass.Trim();
                                users.Email = email.Trim();
                                users.RoleId = this.validarRButtonRole();
                                users.Active = this.validarRButtonActive();

                                _db1.Users.Add(users);

                                _db1.SaveChanges();
                                this.LlenarListViewUser();
                                MessageBox.Show("Usuario Guardado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.clear();
                            }
                            else
                            {
                                MessageBox.Show("El nombre de usuario ya existe, intente nuevamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        //Actualizar usuario
                        else
                        {
                            var userUpdate = _db1.Users.Find(idUser);
                            userUpdate.FirstName = nombre.Trim();
                            userUpdate.LastName = apellido.Trim();
                            userUpdate.UserName = usuario.Trim();
                            userUpdate.Password = pass.Trim();
                            userUpdate.Email = email.Trim();
                            userUpdate.RoleId = this.validarRButtonRole();
                            userUpdate.Active = this.validarRButtonActive();
                            _db1.SaveChanges();
                            this.LlenarListViewUser();
                            MessageBox.Show("Usuario Actualizado exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {
            this.BuscarPorNombre();
        }

        private void lvUsers_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {

                if (lvUsers.SelectedIndices.Count <= 0)
                {
                    return;
                }
                int intselectedindex = lvUsers.SelectedIndices[0];
                if (intselectedindex >= 0)
                {

                    idUser = Int32.Parse(lvUsers.Items[intselectedindex].Text.Trim());//Obtiene el priner dato de la listview

                    using (BimDb1Context _db1 = new BimDb1Context())
                    {
                        var userDetail = _db1.Users.Where(u => u.Id == idUser).ToList();

                        txtFirstName.Texts = userDetail[0].FirstName;
                        txtLastName.Texts = userDetail[0].LastName;
                        txtNomUser.Texts = userDetail[0].UserName;
                        txtPass.Texts = userDetail[0].Password;
                        txtEmail.Texts = userDetail[0].Email;

                        //ACTIVANDO RATIO BUTTONS
                        this.validarRbuttonsTipoUsuario(userDetail[0].RoleId);
                        this.validarRbuttonsActivo(userDetail[0].Active);

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema GUF-003: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.clear();
            idUser = 0;
        }


        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            txtFirstName_Validating();
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            txtLastName_Validating();
        }

        private void txtNomUser_Leave(object sender, EventArgs e)
        {
            txtNomUser_Validating();
            txtNomUser.Texts = txtNomUser.Texts.ToUpper();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            txtEmail_Validating();
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            txtPass_Validating();
        }


        //Metodos Personalizados

        private void BuscarPorNombre()
        {

            try
            {
                using (BimDb1Context _db1 = new BimDb1Context())
                {
                    var buscarUsuario = txtSeachByName.Texts.Trim();
                    //Query EF (Where Like "text%") odenado de manera acendente
                    var Userlist = _db1.Users.Where(un => un.FirstName.StartsWith(buscarUsuario)).OrderBy(x => x.UserName).ToList();//recuperando registro de usuarios
                    var userCount = Userlist.Count();// contando cantidad de registro en tabla usuario
                    var roleName = "";

                    lvUsers.Items.Clear();

                    for (var i = 0; i < userCount; i++)
                    {
                        ListViewItem userItem = new ListViewItem(Userlist[i].Id.ToString());

                        //Buscar roleName por roleId dentro de User
                        var q = from rid in _db1.Roles where rid.Id == Userlist[i].RoleId select rid.RolName.ToString();
                        roleName = q.FirstOrDefault();

                        //Agregando datos a la lista
                        userItem.SubItems.Add(Userlist[i].FirstName.Trim() + " " + Userlist[i].LastName.Trim());
                        userItem.SubItems.Add(Userlist[i].Email.Trim());
                        userItem.SubItems.Add(Userlist[i].UserName.Trim());
                        userItem.SubItems.Add(Userlist[i].Password.Trim());
                        userItem.SubItems.Add(roleName);
                        if (Userlist[i].Active == true)
                        {

                            userItem.SubItems.Add("Activo");
                        }
                        else
                        {
                            userItem.SubItems.Add("Inactivo");
                        }
                        userItem.SubItems.Add(roleName);

                        //Agregando lista al componente listview
                        lvUsers.Items.Add(userItem);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema GUF-002: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LlenarListViewUser()
        {
            try
            {
                //Instanciando Conexión a la BD
                BimDb1Context _db1 = new BimDb1Context();


                var Userlist = _db1.Users.ToList();//recuperando registro de usuarios
                var userCount = Userlist.Count();// contando cantidad de registro en tabla usuario
                var roleName = "";

                lvUsers.Items.Clear();//Limpia los datos de la lista

                for (var i = 0; i < userCount; i++)
                {
                    ListViewItem userItem = new ListViewItem(Userlist[i].Id.ToString());

                    //Buscar roleName por roleId dentro de User
                    var q = from rid in _db1.Roles where rid.Id == Userlist[i].RoleId select rid.RolName.ToString();
                    roleName = q.FirstOrDefault();

                    //Agregando datos a la lista
                    userItem.SubItems.Add(Userlist[i].FirstName.Trim() + " " + Userlist[i].LastName.Trim());
                    userItem.SubItems.Add(Userlist[i].Email.Trim());
                    userItem.SubItems.Add(Userlist[i].UserName.Trim());
                    userItem.SubItems.Add(Userlist[i].Password.Trim());
                    userItem.SubItems.Add(roleName);
                    if (Userlist[i].Active == true)
                    {

                        userItem.SubItems.Add("Activo");
                    }
                    else
                    {
                        userItem.SubItems.Add("Inactivo");
                    }
                    userItem.SubItems.Add(roleName);

                    //Agregando lista al componente listview
                    lvUsers.Items.Add(userItem);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error del sistema GUF-001: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void clear()
        {
            txtFirstName.Texts = txtLastName.Texts = txtNomUser.Texts = txtPass.Texts = txtEmail.Texts = "";
        }

        private int validarRButtonRole()
        {

            var roleId = 0;
            if (rbAdmin.Checked == true)
            {
                roleId = 1;
            }
            else if (rbGeneral.Checked == true)
            {
                roleId = 2;
            }
            else if (rbEntry.Checked == true)
            {
                roleId = 3;
            }
            return roleId;
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

        private void validarRbuttonsTipoUsuario(int roleId)
        {


            if (roleId == 1)
            {
                rbAdmin.Checked = true;
            }
            if (roleId == 2)
            {
                rbGeneral.Checked = true;
            }
            if (roleId == 3)
            {
                rbEntry.Checked = true;
            }
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


        //Validar campos
        private bool txtFirstName_Validating()
        {

            if (ValidarTxt.ValidateText(txtFirstName.Texts))
            {
                errorPName.SetIconPadding(txtFirstName, -30);
                errorPName.SetError(txtFirstName, "El campo nombre no puede estar vacio");
                return false;
            }
            else
            {
                errorPName.Clear();
                return true;
            }
        }

        private bool txtLastName_Validating()
        {
            if (ValidarTxt.ValidateText(txtLastName.Texts))
            {
                errorPLast.SetIconPadding(txtLastName, -30);
                errorPLast.SetError(txtLastName, "El campo Apellido no puede estar vacio");
                return false;
            }
            else
            {
                errorPLast.Clear();
                return true;
            }
        }

        private bool txtNomUser_Validating()
        {

            if (ValidarTxt.validarUserName(txtNomUser.Texts))
            {
                errorPUName.SetIconPadding(txtNomUser, -30);
                errorPUName.SetError(txtNomUser, "El campo Usuario ya existe, trate nuevamente");
                return false;
            }
            else
            {
                errorPUName.Clear();
                return true;
            }
        }

        private bool txtEmail_Validating()
        {
            if (!ValidarTxt.validarEmail(txtEmail.Texts))
            {
                errorPEmail.SetIconPadding(txtEmail, -30);
                errorPEmail.SetError(txtEmail, "El campo email debe cumplir con el formato 'nombre@dominio.com'");
                return false;
            }
            else
            {
                errorPEmail.Clear();
                return true;
            }
        }

        private bool txtPass_Validating()
        {
            if (!ValidarTxt.ValidatePass(txtPass.Texts))
            {
                errorPPass.SetIconPadding(txtPass, -30);
                errorPPass.SetError(txtPass, "La contraseña debe contener al menos un número, un caracrer especial, y no menos de 8 caractereas ej.: 'Prueba1@'");
                return false;
            }
            else
            {
                errorPPass.Clear();
                return true;
            }
        }

        /*protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {

                // Handle key at form level.
                // Do not send event to focused control by returning true.
                return true;
            }
            if (keyData == Keys.Down)
            {
                // Handle key at form level.
                // Do not send event to focused control by returning true.
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }*/

        private void txtSeachByName_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("preionastes keyup");
        }

        private void txtSeachByName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("preionastes keypress");
        }

        private void txtSeachByName_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("preionastes keydown");
        }


        /* 
private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
{
    bool valida = ValidarTxt.soloNumeros(e);
    if (!valida)
    {
        errorP.SetError(txtFirstName,"Este campo acepta solo números");
    }
    else
    {
        errorP0.Clear();
    }
}*/
    }
}
