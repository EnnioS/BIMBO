using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Security.Cryptography;
using System.Text;
using System.Linq;
using System.Data;
using Entities.Data;
using Negocio.Utilities;

namespace Presentacion.Vistas
{
    public partial class LoginForm : Form
    {
        public string userTxt = "";
        public string passTxt = "";
        BimDb1Context _db1;
       

        public LoginForm()
        {
            InitializeComponent();
            this.userTxt = txtUser.Texts;
            this.passTxt = txtPass.Texts;
            _db1 = new BimDb1Context();
        }

    private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try {

                

                //SHA256 sha = SHA256.Create();

                var userName = txtUser.Texts.Trim();
                var password = txtPass.Texts.Trim();
                //Convierte el la cadena de caracteres del input a un array de byte y computa la encriptación.
                //byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                //Crear un instania de StringBuilder para colectar los bytes
                // y creat una cadena de caracteres
                //StringBuilder sBuilder = new StringBuilder();

                //itera por cada byte de los datos encriptados
                //y formatea cada uno como una cadena de hexadecimal.
                /*for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                var hashed_password = sBuilder.ToString();*/

                /*var user = _db1.Users.FirstOrDefault(q => q.UserName == userName && q.Password == password);

                if (user != null)
                {
                    var role = user.UsersRoles.FirstOrDefault();
                    var manyToMany = _db1.Users.Include("Roles").ToList();
                    var rolename = role.Role.RolName;
                    mainMenuForm mainMenuForm = new mainMenuForm(this, rolename);
                    //mainMenuForm mainMenuForm = new mainMenuForm();
                    mainMenuForm.Show();
                    Visible = false;
                    
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta, vuelva a intentarlo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/

                //Obtener Id Roll desde tbl Usuario
                var userLogin = _db1.Users.Where(u => u.UserName == txtUser.Texts
                    && u.Password == txtPass.Texts).ToList();
              
                
                    if (userLogin.Count() > 0)
                    {
                    var isActive = userLogin.Select(userActive => userActive.Active).First();

                        if (isActive == true)
                        {
                            var roleId = userLogin[0].RoleId;
                            var UserName = userLogin[0].FirstName.Trim() + " " + userLogin[0].LastName.Trim();
                            MyGlobalsVar.userId = userLogin[0].Id;


                            //Obtener RollName x roleId
                            var roleName = _db1.Roles.FirstOrDefault(r => r.Id == roleId).RolName.ToString();

                            mainMenuForm mainMenu = new mainMenuForm(this, UserName, roleName);
                            mainMenu.Show();
                            Visible = false;
                        }
                        else
                        {
                        MessageBox.Show("Este usuario ha sido dado de baja, vuelva a intentarlo con otro usuario", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta, vuelva a intentarlo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
                  
            }catch(Exception ex) {
                MessageBox.Show("Error del sistema LUF-001: " + ex + ", Pongase en contacto con Soporte Técnico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}