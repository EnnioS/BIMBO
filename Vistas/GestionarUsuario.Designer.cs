namespace Presentacion.Vistas
{
    partial class GestionarUsuario
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
            txtFirstName = new Controles.CustomeTextBox();
            LblUser = new Label();
            txtLastName = new Controles.CustomeTextBox();
            label1 = new Label();
            txtNomUser = new Controles.CustomeTextBox();
            label2 = new Label();
            txtEmail = new Controles.CustomeTextBox();
            label3 = new Label();
            txtPass = new Controles.CustomeTextBox();
            label4 = new Label();
            rbAdmin = new RadioButton();
            rbGeneral = new RadioButton();
            rbEntry = new RadioButton();
            label5 = new Label();
            btnCerrar = new Controles.RoundedBtn();
            btnGuardar = new Controles.RoundedBtn();
            btnNuevo = new Controles.RoundedBtn();
            lvUsers = new ListView();
            chlvId = new ColumnHeader();
            chlvFullName = new ColumnHeader();
            chlvEmailUser = new ColumnHeader();
            chlvUserName = new ColumnHeader();
            chlvPassUser = new ColumnHeader();
            chlvRollUser = new ColumnHeader();
            chvStatus = new ColumnHeader();
            btnBuscarUser = new Controles.RoundedBtn();
            txtSeachByName = new Controles.CustomeTextBox();
            rbActive = new RadioButton();
            rbUnactive = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.Window;
            txtFirstName.BorderColor = Color.RoyalBlue;
            txtFirstName.BorderFocusColor = Color.SteelBlue;
            txtFirstName.BorderRadius = 7;
            txtFirstName.BorderSize = 1;
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.ForeColor = Color.DimGray;
            txtFirstName.Location = new Point(11, 45);
            txtFirstName.Margin = new Padding(5, 4, 5, 4);
            txtFirstName.Multiline = false;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Padding = new Padding(7);
            txtFirstName.PasswordChar = false;
            txtFirstName.PlaceholderColor = Color.DarkGray;
            txtFirstName.PlaceholderText = "";
            txtFirstName.Size = new Size(325, 43);
            txtFirstName.TabIndex = 12;
            txtFirstName.Texts = "";
            txtFirstName.UnderlinedStyle = false;
            txtFirstName.Leave += txtFirstName_Leave;
            // 
            // LblUser
            // 
            LblUser.AutoSize = true;
            LblUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            LblUser.Location = new Point(11, 21);
            LblUser.Name = "LblUser";
            LblUser.Size = new Size(68, 21);
            LblUser.TabIndex = 11;
            LblUser.Text = "Nombre";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.Window;
            txtLastName.BorderColor = Color.RoyalBlue;
            txtLastName.BorderFocusColor = Color.SteelBlue;
            txtLastName.BorderRadius = 7;
            txtLastName.BorderSize = 1;
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.ForeColor = Color.DimGray;
            txtLastName.Location = new Point(345, 45);
            txtLastName.Margin = new Padding(5, 4, 5, 4);
            txtLastName.Multiline = false;
            txtLastName.Name = "txtLastName";
            txtLastName.Padding = new Padding(7);
            txtLastName.PasswordChar = false;
            txtLastName.PlaceholderColor = Color.DarkGray;
            txtLastName.PlaceholderText = "";
            txtLastName.Size = new Size(325, 43);
            txtLastName.TabIndex = 14;
            txtLastName.Texts = "";
            txtLastName.UnderlinedStyle = false;
            txtLastName.Leave += txtLastName_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(345, 21);
            label1.Name = "label1";
            label1.Size = new Size(67, 21);
            label1.TabIndex = 13;
            label1.Text = "Apellido";
            // 
            // txtNomUser
            // 
            txtNomUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNomUser.BackColor = SystemColors.Window;
            txtNomUser.BorderColor = Color.RoyalBlue;
            txtNomUser.BorderFocusColor = Color.SteelBlue;
            txtNomUser.BorderRadius = 7;
            txtNomUser.BorderSize = 1;
            txtNomUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomUser.ForeColor = Color.DimGray;
            txtNomUser.Location = new Point(678, 45);
            txtNomUser.Margin = new Padding(5, 4, 5, 4);
            txtNomUser.Multiline = false;
            txtNomUser.Name = "txtNomUser";
            txtNomUser.Padding = new Padding(7);
            txtNomUser.PasswordChar = false;
            txtNomUser.PlaceholderColor = Color.DarkGray;
            txtNomUser.PlaceholderText = "";
            txtNomUser.Size = new Size(562, 43);
            txtNomUser.TabIndex = 16;
            txtNomUser.Texts = "";
            txtNomUser.UnderlinedStyle = false;
            txtNomUser.Leave += txtNomUser_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(678, 21);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
            label2.TabIndex = 15;
            label2.Text = "Nombre de Usuario";
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
            txtEmail.Location = new Point(11, 123);
            txtEmail.Margin = new Padding(5, 4, 5, 4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(7);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = Color.DarkGray;
            txtEmail.PlaceholderText = "";
            txtEmail.Size = new Size(658, 43);
            txtEmail.TabIndex = 18;
            txtEmail.Texts = "";
            txtEmail.UnderlinedStyle = false;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 99);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 17;
            label3.Text = "Email";
            // 
            // txtPass
            // 
            txtPass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPass.BackColor = SystemColors.Window;
            txtPass.BorderColor = Color.RoyalBlue;
            txtPass.BorderFocusColor = Color.SteelBlue;
            txtPass.BorderRadius = 7;
            txtPass.BorderSize = 1;
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = Color.DimGray;
            txtPass.Location = new Point(678, 123);
            txtPass.Margin = new Padding(5, 4, 5, 4);
            txtPass.Multiline = false;
            txtPass.Name = "txtPass";
            txtPass.Padding = new Padding(7);
            txtPass.PasswordChar = false;
            txtPass.PlaceholderColor = Color.DarkGray;
            txtPass.PlaceholderText = "";
            txtPass.Size = new Size(562, 43);
            txtPass.TabIndex = 20;
            txtPass.Texts = "";
            txtPass.UnderlinedStyle = false;
            txtPass.Leave += txtPass_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(678, 99);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 19;
            label4.Text = "Contraseña";
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Location = new Point(23, 27);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(125, 24);
            rbAdmin.TabIndex = 21;
            rbAdmin.Text = "Administrador";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbGeneral
            // 
            rbGeneral.AutoSize = true;
            rbGeneral.Location = new Point(23, 51);
            rbGeneral.Name = "rbGeneral";
            rbGeneral.Size = new Size(135, 24);
            rbGeneral.TabIndex = 22;
            rbGeneral.Text = "Usuario General";
            rbGeneral.UseVisualStyleBackColor = true;
            // 
            // rbEntry
            // 
            rbEntry.AutoSize = true;
            rbEntry.Checked = true;
            rbEntry.Location = new Point(23, 75);
            rbEntry.Name = "rbEntry";
            rbEntry.Size = new Size(199, 24);
            rbEntry.TabIndex = 23;
            rbEntry.TabStop = true;
            rbEntry.Text = "Usuario Entrada de Datos";
            rbEntry.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 294);
            label5.Name = "label5";
            label5.Size = new Size(146, 21);
            label5.TabIndex = 25;
            label5.Text = "Buscar por Nombre";
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
            btnCerrar.Location = new Point(224, 851);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(101, 40);
            btnCerrar.TabIndex = 31;
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
            btnGuardar.Location = new Point(118, 851);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 40);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            btnNuevo.Location = new Point(11, 851);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(101, 40);
            btnNuevo.TabIndex = 29;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextColor = Color.White;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // lvUsers
            // 
            lvUsers.BackColor = Color.WhiteSmoke;
            lvUsers.CheckBoxes = true;
            lvUsers.Columns.AddRange(new ColumnHeader[] { chlvId, chlvFullName, chlvEmailUser, chlvUserName, chlvPassUser, chlvRollUser, chvStatus });
            lvUsers.FullRowSelect = true;
            lvUsers.GridLines = true;
            lvUsers.HideSelection = true;
            lvUsers.HoverSelection = true;
            lvUsers.Location = new Point(10, 368);
            lvUsers.MultiSelect = false;
            lvUsers.Name = "lvUsers";
            lvUsers.Size = new Size(1230, 464);
            lvUsers.TabIndex = 28;
            lvUsers.UseCompatibleStateImageBehavior = false;
            lvUsers.View = View.Details;
            lvUsers.MouseDown += lvUsers_MouseDown;
            // 
            // chlvId
            // 
            chlvId.Width = 0;
            // 
            // chlvFullName
            // 
            chlvFullName.Text = "Nombre";
            chlvFullName.Width = 300;
            // 
            // chlvEmailUser
            // 
            chlvEmailUser.Text = "Email";
            chlvEmailUser.Width = 300;
            // 
            // chlvUserName
            // 
            chlvUserName.Text = "Usuario";
            chlvUserName.Width = 150;
            // 
            // chlvPassUser
            // 
            chlvPassUser.Text = "Contraseña";
            chlvPassUser.Width = 200;
            // 
            // chlvRollUser
            // 
            chlvRollUser.Text = "Rol";
            chlvRollUser.Width = 200;
            // 
            // chvStatus
            // 
            chvStatus.Text = "Estado";
            chvStatus.Width = 80;
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
            btnBuscarUser.Location = new Point(675, 319);
            btnBuscarUser.Margin = new Padding(3, 4, 3, 4);
            btnBuscarUser.Name = "btnBuscarUser";
            btnBuscarUser.Size = new Size(101, 40);
            btnBuscarUser.TabIndex = 27;
            btnBuscarUser.TextColor = Color.White;
            btnBuscarUser.UseVisualStyleBackColor = false;
            btnBuscarUser.Click += btnBuscarUser_Click;
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
            txtSeachByName.Location = new Point(10, 318);
            txtSeachByName.Margin = new Padding(5, 4, 5, 4);
            txtSeachByName.Multiline = false;
            txtSeachByName.Name = "txtSeachByName";
            txtSeachByName.Padding = new Padding(7);
            txtSeachByName.PasswordChar = false;
            txtSeachByName.PlaceholderColor = Color.DarkGray;
            txtSeachByName.PlaceholderText = "";
            txtSeachByName.Size = new Size(658, 43);
            txtSeachByName.TabIndex = 26;
            txtSeachByName.Texts = "";
            txtSeachByName.UnderlinedStyle = false;
            txtSeachByName.KeyDown += txtSeachByName_KeyDown;
            txtSeachByName.KeyPress += txtSeachByName_KeyPress;
            txtSeachByName.KeyUp += txtSeachByName_KeyUp;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Checked = true;
            rbActive.Location = new Point(25, 27);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(72, 24);
            rbActive.TabIndex = 24;
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
            rbUnactive.TabIndex = 25;
            rbUnactive.Text = "Inactivo";
            rbUnactive.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbAdmin);
            groupBox1.Controls.Add(rbGeneral);
            groupBox1.Controls.Add(rbEntry);
            groupBox1.Location = new Point(12, 173);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 115);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo de Usuario";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbActive);
            groupBox2.Controls.Add(rbUnactive);
            groupBox2.Location = new Point(678, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 95);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Condición del Usuario";
            // 
            // GestionarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1257, 904);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtSeachByName);
            Controls.Add(btnBuscarUser);
            Controls.Add(lvUsers);
            Controls.Add(btnNuevo);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNomUser);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Controls.Add(LblUser);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "GestionarUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Gestión de Usuarios";
            WindowState = FormWindowState.Maximized;
            Load += GestionarUsuario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controles.CustomeTextBox txtFirstName;
        private Label LblUser;
        private Controles.CustomeTextBox txtLastName;
        private Label label1;
        private Controles.CustomeTextBox txtNomUser;
        private Label label2;
        private Controles.CustomeTextBox txtEmail;
        private Label label3;
        private Controles.CustomeTextBox txtPass;
        private Label label4;
        private RadioButton rbAdmin;
        private RadioButton rbGeneral;
        private RadioButton rbEntry;
        private Label label5;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private ColumnHeader chlvNombre;
        private ColumnHeader chlvEmail;
        private ColumnHeader chlvUsuario;
        private ColumnHeader chlvConstrasena;
        private ColumnHeader chlvRoll;
        private Controles.RoundedBtn btnCerrar;
        private Controles.RoundedBtn btnGuardar;
        private Controles.RoundedBtn btnNuevo;
        private ListView lvUsers;
        private ColumnHeader chlvFullName;
        private ColumnHeader chlvEmailUser;
        private ColumnHeader chlvPassUser;
        private ColumnHeader chlvRollUser;
        private Controles.RoundedBtn btnBuscarUser;
        private ColumnHeader chlvUserName;
        private Controles.CustomeTextBox txtSeachByName;
        private ColumnHeader chlvId;
        private RadioButton rbActive;
        private RadioButton rbUnactive;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ColumnHeader chvStatus;
    }
}