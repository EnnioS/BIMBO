using Entities.Entities;
using System.Windows.Forms;

namespace Presentacion.Vistas
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LblUser = new Label();
            LblPass = new Label();
            userBindingSource = new BindingSource(components);
            btnAceptar = new Controles.RoundedBtn();
            btnCancelar = new Controles.RoundedBtn();
            txtUser = new Controles.CustomeTextBox();
            txtPass = new Controles.CustomeTextBox();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // LblUser
            // 
            LblUser.AutoSize = true;
            LblUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            LblUser.Location = new Point(14, 25);
            LblUser.Name = "LblUser";
            LblUser.Size = new Size(64, 21);
            LblUser.TabIndex = 0;
            LblUser.Text = "Usuario";
            // 
            // LblPass
            // 
            LblPass.AutoSize = true;
            LblPass.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            LblPass.Location = new Point(14, 117);
            LblPass.Name = "LblPass";
            LblPass.Size = new Size(89, 21);
            LblPass.TabIndex = 2;
            LblPass.Text = "Contraseña";
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(User);
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.HotTrack;
            btnAceptar.BackgroundColor = SystemColors.HotTrack;
            btnAceptar.BorderColor = Color.PaleVioletRed;
            btnAceptar.BorderRadius = 7;
            btnAceptar.BorderSize = 0;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(14, 208);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 40);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Ingresar";
            btnAceptar.TextColor = Color.White;
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ControlDarkDark;
            btnCancelar.BackgroundColor = SystemColors.ControlDarkDark;
            btnCancelar.BorderColor = Color.PaleVioletRed;
            btnCancelar.BorderRadius = 7;
            btnCancelar.BorderSize = 0;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(120, 208);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextColor = Color.White;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUser
            // 
            txtUser.BackColor = SystemColors.Window;
            txtUser.BorderColor = Color.RoyalBlue;
            txtUser.BorderFocusColor = Color.SteelBlue;
            txtUser.BorderRadius = 10;
            txtUser.BorderSize = 2;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.DimGray;
            txtUser.Location = new Point(14, 50);
            txtUser.Margin = new Padding(4);
            txtUser.Multiline = false;
            txtUser.Name = "txtUser";
            txtUser.Padding = new Padding(7);
            txtUser.PasswordChar = false;
            txtUser.PlaceholderColor = Color.DarkGray;
            txtUser.PlaceholderText = "";
            txtUser.Size = new Size(410, 43);
            txtUser.TabIndex = 10;
            txtUser.Texts = "";
            txtUser.UnderlinedStyle = false;
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.Window;
            txtPass.BorderColor = Color.RoyalBlue;
            txtPass.BorderFocusColor = Color.SteelBlue;
            txtPass.BorderRadius = 10;
            txtPass.BorderSize = 2;
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = Color.DimGray;
            txtPass.Location = new Point(14, 142);
            txtPass.Margin = new Padding(4);
            txtPass.Multiline = false;
            txtPass.Name = "txtPass";
            txtPass.Padding = new Padding(7);
            txtPass.PasswordChar = true;
            txtPass.PlaceholderColor = Color.DarkGray;
            txtPass.PlaceholderText = "";
            txtPass.Size = new Size(410, 43);
            txtPass.TabIndex = 11;
            txtPass.Texts = "";
            txtPass.UnderlinedStyle = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(439, 265);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(LblPass);
            Controls.Add(LblUser);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingresar";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblUser;
        private Label LblPass;
        private BindingSource userBindingSource;
        private Controles.RoundedBtn btnAceptar;
        private Controles.RoundedBtn btnCancelar;
        private Controles.CustomeTextBox txtUser;
        private Controles.CustomeTextBox txtPass;
    }
}