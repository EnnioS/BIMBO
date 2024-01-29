namespace Presentacion.Vistas
{
    partial class GestionarProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevo = new Controles.RoundedBtn();
            btnCerrar = new Controles.RoundedBtn();
            btnGuardar = new Controles.RoundedBtn();
            txtNombre = new Controles.CustomeTextBox();
            label1 = new Label();
            txtEmail = new Controles.CustomeTextBox();
            label2 = new Label();
            txtDireccion = new Controles.CustomeTextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtContacto = new Controles.CustomeTextBox();
            label7 = new Label();
            lvProveedores = new ListView();
            chlvCodigoProv = new ColumnHeader();
            chlvNameProv = new ColumnHeader();
            chlvEmailProv = new ColumnHeader();
            chlvTel1Prov = new ColumnHeader();
            chlvDirProv = new ColumnHeader();
            chlvActiveProv = new ColumnHeader();
            gbBuscarPor = new GroupBox();
            txtSeachByName = new Controles.CustomeTextBox();
            btnBuscarUser = new Controles.RoundedBtn();
            rbCodigo = new RadioButton();
            rbNombre = new RadioButton();
            groupBox2 = new GroupBox();
            rbActive = new RadioButton();
            rbUnactive = new RadioButton();
            txtTelefono1 = new Controles.CustomeMaskedTextBox();
            txtTelefono2 = new Controles.CustomeMaskedTextBox();
            lvNumPlacas = new ListView();
            chlvNumPlaca = new ColumnHeader();
            gbBuscarPor.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.HotTrack;
            btnNuevo.BackgroundColor = SystemColors.HotTrack;
            btnNuevo.BorderColor = Color.PaleVioletRed;
            btnNuevo.BorderRadius = 7;
            btnNuevo.BorderSize = 0;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(12, 841);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 40);
            btnNuevo.TabIndex = 60;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextColor = Color.White;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = SystemColors.ControlDarkDark;
            btnCerrar.BackgroundColor = SystemColors.ControlDarkDark;
            btnCerrar.BorderColor = Color.PaleVioletRed;
            btnCerrar.BorderRadius = 7;
            btnCerrar.BorderSize = 0;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = SystemColors.ControlDark;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(224, 841);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 40);
            btnCerrar.TabIndex = 62;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextColor = Color.White;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.HotTrack;
            btnGuardar.BackgroundColor = SystemColors.HotTrack;
            btnGuardar.BorderColor = Color.PaleVioletRed;
            btnGuardar.BorderRadius = 7;
            btnGuardar.BorderSize = 0;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(118, 841);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 40);
            btnGuardar.TabIndex = 61;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Window;
            txtNombre.BorderColor = Color.RoyalBlue;
            txtNombre.BorderFocusColor = Color.SteelBlue;
            txtNombre.BorderRadius = 7;
            txtNombre.BorderSize = 1;
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.ForeColor = Color.DimGray;
            txtNombre.Location = new Point(13, 49);
            txtNombre.Margin = new Padding(4);
            txtNombre.Multiline = false;
            txtNombre.Name = "txtNombre";
            txtNombre.Padding = new Padding(7);
            txtNombre.PasswordChar = false;
            txtNombre.PlaceholderColor = Color.DarkGray;
            txtNombre.PlaceholderText = "";
            txtNombre.Size = new Size(315, 43);
            txtNombre.TabIndex = 39;
            txtNombre.Texts = "";
            txtNombre.UnderlinedStyle = false;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 38;
            label1.Text = "Nombre";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderColor = Color.RoyalBlue;
            txtEmail.BorderFocusColor = Color.SteelBlue;
            txtEmail.BorderRadius = 7;
            txtEmail.BorderSize = 1;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Location = new Point(336, 49);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.DarkGray;
            txtEmail.PlaceholderText = "";
            txtEmail.Size = new Size(638, 43);
            txtEmail.TabIndex = 41;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = false;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(336, 24);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 40;
            label2.Text = "Email";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = SystemColors.Window;
            txtDireccion.BorderColor = Color.RoyalBlue;
            txtDireccion.BorderFocusColor = Color.SteelBlue;
            txtDireccion.BorderRadius = 7;
            txtDireccion.BorderSize = 1;
            txtDireccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDireccion.ForeColor = Color.DimGray;
            txtDireccion.Location = new Point(981, 49);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Padding = new Padding(7);
            txtDireccion.PasswordChar = false;
            txtDireccion.PlaceholderColor = Color.DarkGray;
            txtDireccion.PlaceholderText = "";
            txtDireccion.Size = new Size(261, 115);
            txtDireccion.TabIndex = 43;
            txtDireccion.Texts = "";
            txtDireccion.UnderlinedStyle = false;
            txtDireccion.Leave += txtDireccion_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(981, 24);
            label3.Name = "label3";
            label3.Size = new Size(75, 21);
            label3.TabIndex = 42;
            label3.Text = "Dirección";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 96);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 44;
            label4.Text = "Teléfono 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(336, 96);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 46;
            label6.Text = "Teléfono 2";
            // 
            // txtContacto
            // 
            txtContacto.BackColor = SystemColors.Window;
            txtContacto.BorderColor = Color.RoyalBlue;
            txtContacto.BorderFocusColor = Color.SteelBlue;
            txtContacto.BorderRadius = 7;
            txtContacto.BorderSize = 1;
            txtContacto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContacto.ForeColor = Color.DimGray;
            txtContacto.Location = new Point(659, 121);
            txtContacto.Margin = new Padding(4);
            txtContacto.Multiline = false;
            txtContacto.Name = "txtContacto";
            txtContacto.Padding = new Padding(7);
            txtContacto.PasswordChar = false;
            txtContacto.PlaceholderColor = Color.DarkGray;
            txtContacto.PlaceholderText = "";
            txtContacto.Size = new Size(315, 43);
            txtContacto.TabIndex = 49;
            txtContacto.Texts = "";
            txtContacto.UnderlinedStyle = false;
            txtContacto.Leave += txtContacto_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(659, 96);
            label7.Name = "label7";
            label7.Size = new Size(72, 21);
            label7.TabIndex = 48;
            label7.Text = "Contacto";
            // 
            // lvProveedores
            // 
            lvProveedores.BackColor = Color.WhiteSmoke;
            lvProveedores.Columns.AddRange(new ColumnHeader[] { chlvCodigoProv, chlvNameProv, chlvEmailProv, chlvTel1Prov, chlvDirProv, chlvActiveProv });
            lvProveedores.FullRowSelect = true;
            lvProveedores.GridLines = true;
            lvProveedores.HideSelection = true;
            lvProveedores.HoverSelection = true;
            lvProveedores.Location = new Point(12, 360);
            lvProveedores.MultiSelect = false;
            lvProveedores.Name = "lvProveedores";
            lvProveedores.Size = new Size(1230, 461);
            lvProveedores.TabIndex = 59;
            lvProveedores.UseCompatibleStateImageBehavior = false;
            lvProveedores.View = View.Details;
            lvProveedores.MouseDown += lvProveedores_MouseDown;
            // 
            // chlvCodigoProv
            // 
            chlvCodigoProv.Text = "Código";
            chlvCodigoProv.Width = 100;
            // 
            // chlvNameProv
            // 
            chlvNameProv.Text = "Nombre";
            chlvNameProv.Width = 200;
            // 
            // chlvEmailProv
            // 
            chlvEmailProv.Text = "Email";
            chlvEmailProv.Width = 200;
            // 
            // chlvTel1Prov
            // 
            chlvTel1Prov.Text = "Teléfonos";
            chlvTel1Prov.Width = 180;
            // 
            // chlvDirProv
            // 
            chlvDirProv.Text = "Dirección";
            chlvDirProv.Width = 450;
            // 
            // chlvActiveProv
            // 
            chlvActiveProv.Text = "Estado";
            chlvActiveProv.Width = 95;
            // 
            // gbBuscarPor
            // 
            gbBuscarPor.Controls.Add(txtSeachByName);
            gbBuscarPor.Controls.Add(btnBuscarUser);
            gbBuscarPor.Controls.Add(rbCodigo);
            gbBuscarPor.Controls.Add(rbNombre);
            gbBuscarPor.Location = new Point(13, 266);
            gbBuscarPor.Name = "gbBuscarPor";
            gbBuscarPor.Size = new Size(962, 88);
            gbBuscarPor.TabIndex = 53;
            gbBuscarPor.TabStop = false;
            gbBuscarPor.Text = "Buscar por";
            // 
            // txtSeachByName
            // 
            txtSeachByName.BackColor = SystemColors.Window;
            txtSeachByName.BorderColor = Color.RoyalBlue;
            txtSeachByName.BorderFocusColor = Color.SteelBlue;
            txtSeachByName.BorderRadius = 7;
            txtSeachByName.BorderSize = 1;
            txtSeachByName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSeachByName.ForeColor = Color.DimGray;
            txtSeachByName.Location = new Point(101, 31);
            txtSeachByName.Margin = new Padding(4);
            txtSeachByName.Multiline = false;
            txtSeachByName.Name = "txtSeachByName";
            txtSeachByName.Padding = new Padding(7);
            txtSeachByName.PasswordChar = false;
            txtSeachByName.PlaceholderColor = Color.DarkGray;
            txtSeachByName.PlaceholderText = "";
            txtSeachByName.Size = new Size(736, 43);
            txtSeachByName.TabIndex = 56;
            txtSeachByName.Texts = "";
            txtSeachByName.UnderlinedStyle = false;
            // 
            // btnBuscarUser
            // 
            btnBuscarUser.BackColor = SystemColors.HotTrack;
            btnBuscarUser.BackgroundColor = SystemColors.HotTrack;
            btnBuscarUser.BorderColor = Color.PaleVioletRed;
            btnBuscarUser.BorderRadius = 7;
            btnBuscarUser.BorderSize = 0;
            btnBuscarUser.FlatAppearance.BorderSize = 0;
            btnBuscarUser.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnBuscarUser.FlatStyle = FlatStyle.Flat;
            btnBuscarUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscarUser.ForeColor = Color.White;
            btnBuscarUser.Image = Properties.Resources.search_20x20px;
            btnBuscarUser.Location = new Point(844, 32);
            btnBuscarUser.Margin = new Padding(3, 4, 3, 4);
            btnBuscarUser.Name = "btnBuscarUser";
            btnBuscarUser.Size = new Size(100, 40);
            btnBuscarUser.TabIndex = 57;
            btnBuscarUser.TextColor = Color.White;
            btnBuscarUser.UseVisualStyleBackColor = false;
            btnBuscarUser.Click += btnBuscarProvider_Click;
            // 
            // rbCodigo
            // 
            rbCodigo.AutoSize = true;
            rbCodigo.Location = new Point(15, 54);
            rbCodigo.Name = "rbCodigo";
            rbCodigo.Size = new Size(79, 24);
            rbCodigo.TabIndex = 55;
            rbCodigo.Text = "Código";
            rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            rbNombre.AutoSize = true;
            rbNombre.Checked = true;
            rbNombre.Location = new Point(15, 28);
            rbNombre.Name = "rbNombre";
            rbNombre.Size = new Size(85, 24);
            rbNombre.TabIndex = 54;
            rbNombre.TabStop = true;
            rbNombre.Text = "Nombre";
            rbNombre.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbActive);
            groupBox2.Controls.Add(rbUnactive);
            groupBox2.Location = new Point(724, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 95);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Condición del Proveedor";
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Checked = true;
            rbActive.Location = new Point(25, 27);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(72, 24);
            rbActive.TabIndex = 51;
            rbActive.TabStop = true;
            rbActive.Text = "Activo";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // rbUnactive
            // 
            rbUnactive.AutoSize = true;
            rbUnactive.Location = new Point(25, 56);
            rbUnactive.Name = "rbUnactive";
            rbUnactive.Size = new Size(82, 24);
            rbUnactive.TabIndex = 52;
            rbUnactive.Text = "Inactivo";
            rbUnactive.UseVisualStyleBackColor = true;
            // 
            // txtTelefono1
            // 
            txtTelefono1.BackColor = SystemColors.Window;
            txtTelefono1.BorderColor = Color.RoyalBlue;
            txtTelefono1.BorderFocusColor = Color.SteelBlue;
            txtTelefono1.BorderRadius = 7;
            txtTelefono1.BorderSize = 1;
            txtTelefono1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono1.ForeColor = Color.DimGray;
            txtTelefono1.Location = new Point(13, 121);
            txtTelefono1.Margin = new Padding(4);
            txtTelefono1.Mask = "(999)0000-0000";
            txtTelefono1.Multiline = false;
            txtTelefono1.Name = "txtTelefono1";
            txtTelefono1.Padding = new Padding(7);
            txtTelefono1.PasswordChar = false;
            txtTelefono1.PlaceholderColor = Color.DarkGray;
            txtTelefono1.PlaceholderText = "";
            txtTelefono1.Size = new Size(315, 43);
            txtTelefono1.TabIndex = 45;
            txtTelefono1.Texts = "(   )    -";
            txtTelefono1.UnderlinedStyle = false;
            // 
            // txtTelefono2
            // 
            txtTelefono2.BackColor = SystemColors.Window;
            txtTelefono2.BorderColor = Color.RoyalBlue;
            txtTelefono2.BorderFocusColor = Color.SteelBlue;
            txtTelefono2.BorderRadius = 7;
            txtTelefono2.BorderSize = 1;
            txtTelefono2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTelefono2.ForeColor = Color.DimGray;
            txtTelefono2.Location = new Point(336, 121);
            txtTelefono2.Margin = new Padding(4);
            txtTelefono2.Mask = "(999)0000-0000";
            txtTelefono2.Multiline = false;
            txtTelefono2.Name = "txtTelefono2";
            txtTelefono2.Padding = new Padding(7);
            txtTelefono2.PasswordChar = false;
            txtTelefono2.PlaceholderColor = Color.DarkGray;
            txtTelefono2.PlaceholderText = "";
            txtTelefono2.Size = new Size(315, 43);
            txtTelefono2.TabIndex = 47;
            txtTelefono2.Texts = "(   )    -";
            txtTelefono2.UnderlinedStyle = false;
            // 
            // lvNumPlacas
            // 
            lvNumPlacas.BackColor = Color.WhiteSmoke;
            lvNumPlacas.Columns.AddRange(new ColumnHeader[] { chlvNumPlaca });
            lvNumPlacas.FullRowSelect = true;
            lvNumPlacas.GridLines = true;
            lvNumPlacas.HideSelection = true;
            lvNumPlacas.HoverSelection = true;
            lvNumPlacas.Location = new Point(981, 171);
            lvNumPlacas.MultiSelect = false;
            lvNumPlacas.Name = "lvNumPlacas";
            lvNumPlacas.Size = new Size(264, 183);
            lvNumPlacas.TabIndex = 63;
            lvNumPlacas.UseCompatibleStateImageBehavior = false;
            lvNumPlacas.View = View.Details;
            lvNumPlacas.SelectedIndexChanged += lvNumPlacas_SelectedIndexChanged;
            // 
            // chlvNumPlaca
            // 
            chlvNumPlaca.Text = "Número de placa";
            chlvNumPlaca.Width = 250;
            // 
            // GestionarProveedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1257, 904);
            Controls.Add(lvNumPlacas);
            Controls.Add(txtTelefono2);
            Controls.Add(txtTelefono1);
            Controls.Add(groupBox2);
            Controls.Add(gbBuscarPor);
            Controls.Add(lvProveedores);
            Controls.Add(txtContacto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(txtDireccion);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(btnNuevo);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GestionarProveedor";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestionar Proveedor";
            WindowState = FormWindowState.Maximized;
            Load += GestionarProveedor_Load;
            gbBuscarPor.ResumeLayout(false);
            gbBuscarPor.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controles.RoundedBtn btnNuevo;
        private Controles.RoundedBtn btnCerrar;
        private Controles.RoundedBtn btnGuardar;
        private Controles.CustomeTextBox txtNombre;
        private Label label1;
        private Controles.CustomeTextBox txtEmail;
        private Label label2;
        private Controles.CustomeTextBox txtDireccion;
        private Label label3;
        private Label label4;
        private Label label6;
        private Controles.CustomeTextBox txtContacto;
        private Label label7;
        private ListView lvProveedores;
        private ColumnHeader chlvCodigoProv;
        private ColumnHeader chlvNameProv;
        private ColumnHeader chlvEmailProv;
        private ColumnHeader chlvTel1Prov;
        private ColumnHeader chlvDirProv;
        private GroupBox gbBuscarPor;
        private RadioButton rbCodigo;
        private RadioButton rbNombre;
        private Controles.CustomeTextBox txtSeachByName;
        private Controles.RoundedBtn btnBuscarUser;
        private GroupBox groupBox2;
        private RadioButton rbActive;
        private RadioButton rbUnactive;
        private Controles.CustomeMaskedTextBox txtTelefono1;
        private Controles.CustomeMaskedTextBox txtTelefono2;
        private ColumnHeader chlvActiveProv;
        private ListView lvNumPlacas;
        private ColumnHeader chlvNumPlaca;
    }
}