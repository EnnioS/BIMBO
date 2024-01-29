namespace Presentacion.Vistas.MateriaPrima
{
    partial class EntradaPorPesoTeorico
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
            btnGuardar = new Controles.RoundedBtn();
            groupBox1 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            txtNumeroBultosRecibidos = new Controles.CustomeTextBox();
            label10 = new Label();
            txtPesoRecibido = new Controles.CustomeTextBox();
            label9 = new Label();
            txtNumeroBultosTeorico = new Controles.CustomeTextBox();
            label8 = new Label();
            txtPesoManifestado = new Controles.CustomeTextBox();
            label6 = new Label();
            txtHora = new Controles.CustomeTextBox();
            label7 = new Label();
            txtFecha = new Controles.CustomeTextBox();
            label5 = new Label();
            btnCerrar = new Controles.RoundedBtn();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbProveedores = new Controles.CustomerComboBox();
            cbPlates = new Controles.CustomerComboBox();
            cbProductos = new Controles.CustomerComboBox();
            btnEliminarE = new Controles.RoundedBtn();
            btnFinalizarE = new Controles.RoundedBtn();
            btnCrearM = new Controles.RoundedBtn();
            label4 = new Label();
            lblPesoTeoricoUnit = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            btnGuardar.Location = new Point(1038, 647);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 40);
            btnGuardar.TabIndex = 103;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtNumeroBultosRecibidos);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtPesoRecibido);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtNumeroBultosTeorico);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPesoManifestado);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtHora);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtFecha);
            groupBox1.Controls.Add(label5);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(12, 188);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1232, 447);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrada por Peso Teórico";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(615, 374);
            label14.Name = "label14";
            label14.Size = new Size(66, 28);
            label14.TabIndex = 98;
            label14.Text = "Bultos";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(616, 302);
            label13.Name = "label13";
            label13.Size = new Size(36, 28);
            label13.TabIndex = 95;
            label13.Text = "Kg";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(616, 230);
            label12.Name = "label12";
            label12.Size = new Size(66, 28);
            label12.TabIndex = 92;
            label12.Text = "Bultos";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(617, 158);
            label11.Name = "label11";
            label11.Size = new Size(36, 28);
            label11.TabIndex = 89;
            label11.Text = "Kg";
            // 
            // txtNumeroBultosRecibidos
            // 
            txtNumeroBultosRecibidos.BackColor = SystemColors.Window;
            txtNumeroBultosRecibidos.BorderColor = Color.RoyalBlue;
            txtNumeroBultosRecibidos.BorderFocusColor = Color.SteelBlue;
            txtNumeroBultosRecibidos.BorderRadius = 7;
            txtNumeroBultosRecibidos.BorderSize = 1;
            txtNumeroBultosRecibidos.Enabled = false;
            txtNumeroBultosRecibidos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroBultosRecibidos.ForeColor = Color.DimGray;
            txtNumeroBultosRecibidos.Location = new Point(408, 368);
            txtNumeroBultosRecibidos.Margin = new Padding(4);
            txtNumeroBultosRecibidos.Multiline = false;
            txtNumeroBultosRecibidos.Name = "txtNumeroBultosRecibidos";
            txtNumeroBultosRecibidos.Padding = new Padding(7);
            txtNumeroBultosRecibidos.PasswordChar = false;
            txtNumeroBultosRecibidos.PlaceholderColor = Color.DarkGray;
            txtNumeroBultosRecibidos.PlaceholderText = "";
            txtNumeroBultosRecibidos.Size = new Size(200, 43);
            txtNumeroBultosRecibidos.TabIndex = 97;
            txtNumeroBultosRecibidos.Texts = "0.00";
            txtNumeroBultosRecibidos.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(408, 343);
            label10.Name = "label10";
            label10.Size = new Size(200, 21);
            label10.TabIndex = 96;
            label10.Text = "Número de Bultos Recibido";
            // 
            // txtPesoRecibido
            // 
            txtPesoRecibido.BackColor = SystemColors.Window;
            txtPesoRecibido.BorderColor = Color.RoyalBlue;
            txtPesoRecibido.BorderFocusColor = Color.SteelBlue;
            txtPesoRecibido.BorderRadius = 7;
            txtPesoRecibido.BorderSize = 1;
            txtPesoRecibido.Enabled = false;
            txtPesoRecibido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesoRecibido.ForeColor = Color.DimGray;
            txtPesoRecibido.Location = new Point(409, 296);
            txtPesoRecibido.Margin = new Padding(4);
            txtPesoRecibido.Multiline = false;
            txtPesoRecibido.Name = "txtPesoRecibido";
            txtPesoRecibido.Padding = new Padding(7);
            txtPesoRecibido.PasswordChar = false;
            txtPesoRecibido.PlaceholderColor = Color.DarkGray;
            txtPesoRecibido.PlaceholderText = "";
            txtPesoRecibido.Size = new Size(200, 43);
            txtPesoRecibido.TabIndex = 94;
            txtPesoRecibido.Texts = "0.00";
            txtPesoRecibido.UnderlinedStyle = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(409, 271);
            label9.Name = "label9";
            label9.Size = new Size(152, 21);
            label9.TabIndex = 93;
            label9.Text = "Peso Neto Calculado";
            // 
            // txtNumeroBultosTeorico
            // 
            txtNumeroBultosTeorico.BackColor = SystemColors.Window;
            txtNumeroBultosTeorico.BorderColor = Color.RoyalBlue;
            txtNumeroBultosTeorico.BorderFocusColor = Color.SteelBlue;
            txtNumeroBultosTeorico.BorderRadius = 7;
            txtNumeroBultosTeorico.BorderSize = 1;
            txtNumeroBultosTeorico.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroBultosTeorico.ForeColor = Color.DimGray;
            txtNumeroBultosTeorico.Location = new Point(409, 224);
            txtNumeroBultosTeorico.Margin = new Padding(4);
            txtNumeroBultosTeorico.Multiline = false;
            txtNumeroBultosTeorico.Name = "txtNumeroBultosTeorico";
            txtNumeroBultosTeorico.Padding = new Padding(7);
            txtNumeroBultosTeorico.PasswordChar = false;
            txtNumeroBultosTeorico.PlaceholderColor = Color.DarkGray;
            txtNumeroBultosTeorico.PlaceholderText = "";
            txtNumeroBultosTeorico.Size = new Size(200, 43);
            txtNumeroBultosTeorico.TabIndex = 91;
            txtNumeroBultosTeorico.Texts = "0.00";
            txtNumeroBultosTeorico.UnderlinedStyle = false;
            txtNumeroBultosTeorico.Leave += txtNumeroBultos_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(409, 199);
            label8.Name = "label8";
            label8.Size = new Size(196, 21);
            label8.TabIndex = 90;
            label8.Text = "Número de Bultos Teóricos";
            // 
            // txtPesoManifestado
            // 
            txtPesoManifestado.BackColor = SystemColors.Window;
            txtPesoManifestado.BorderColor = Color.RoyalBlue;
            txtPesoManifestado.BorderFocusColor = Color.SteelBlue;
            txtPesoManifestado.BorderRadius = 7;
            txtPesoManifestado.BorderSize = 1;
            txtPesoManifestado.Enabled = false;
            txtPesoManifestado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesoManifestado.ForeColor = Color.DimGray;
            txtPesoManifestado.Location = new Point(410, 152);
            txtPesoManifestado.Margin = new Padding(4);
            txtPesoManifestado.Multiline = false;
            txtPesoManifestado.Name = "txtPesoManifestado";
            txtPesoManifestado.Padding = new Padding(7);
            txtPesoManifestado.PasswordChar = false;
            txtPesoManifestado.PlaceholderColor = Color.DarkGray;
            txtPesoManifestado.PlaceholderText = "";
            txtPesoManifestado.Size = new Size(200, 43);
            txtPesoManifestado.TabIndex = 88;
            txtPesoManifestado.Texts = "0.00";
            txtPesoManifestado.UnderlinedStyle = false;
            txtPesoManifestado.Leave += txtPesoManifestado_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(410, 127);
            label6.Name = "label6";
            label6.Size = new Size(132, 21);
            label6.TabIndex = 87;
            label6.Text = "Peso Manifestado";
            // 
            // txtHora
            // 
            txtHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtHora.BackColor = SystemColors.Window;
            txtHora.BorderColor = Color.RoyalBlue;
            txtHora.BorderFocusColor = Color.SteelBlue;
            txtHora.BorderRadius = 7;
            txtHora.BorderSize = 1;
            txtHora.Enabled = false;
            txtHora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHora.ForeColor = Color.DimGray;
            txtHora.Location = new Point(617, 80);
            txtHora.Margin = new Padding(4);
            txtHora.Multiline = false;
            txtHora.Name = "txtHora";
            txtHora.Padding = new Padding(7);
            txtHora.PasswordChar = false;
            txtHora.PlaceholderColor = Color.DarkGray;
            txtHora.PlaceholderText = "";
            txtHora.Size = new Size(200, 43);
            txtHora.TabIndex = 86;
            txtHora.Texts = "";
            txtHora.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(617, 55);
            label7.Name = "label7";
            label7.Size = new Size(122, 21);
            label7.TabIndex = 85;
            label7.Text = "Hora de Entrada";
            // 
            // txtFecha
            // 
            txtFecha.BackColor = SystemColors.Window;
            txtFecha.BorderColor = Color.RoyalBlue;
            txtFecha.BorderFocusColor = Color.SteelBlue;
            txtFecha.BorderRadius = 7;
            txtFecha.BorderSize = 1;
            txtFecha.Enabled = false;
            txtFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFecha.ForeColor = Color.DimGray;
            txtFecha.Location = new Point(410, 80);
            txtFecha.Margin = new Padding(4);
            txtFecha.Multiline = false;
            txtFecha.Name = "txtFecha";
            txtFecha.Padding = new Padding(7);
            txtFecha.PasswordChar = false;
            txtFecha.PlaceholderColor = Color.DarkGray;
            txtFecha.PlaceholderText = "";
            txtFecha.Size = new Size(200, 43);
            txtFecha.TabIndex = 84;
            txtFecha.Texts = "";
            txtFecha.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(410, 55);
            label5.Name = "label5";
            label5.Size = new Size(128, 21);
            label5.TabIndex = 83;
            label5.Text = "Fecha de Entrada";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
            btnCerrar.Location = new Point(1144, 647);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 40);
            btnCerrar.TabIndex = 104;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextColor = Color.White;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(73, 21);
            label3.TabIndex = 78;
            label3.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 74;
            label2.Text = "Proveedor";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(499, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 99;
            label1.Text = "Placa";
            // 
            // cbProveedores
            // 
            cbProveedores.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbProveedores.BackColor = SystemColors.Window;
            cbProveedores.BorderColor = Color.RoyalBlue;
            cbProveedores.BorderSize = 1;
            cbProveedores.DropDownStyle = ComboBoxStyle.DropDown;
            cbProveedores.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbProveedores.ForeColor = Color.DimGray;
            cbProveedores.IconColor = Color.RoyalBlue;
            cbProveedores.ListBackColor = Color.FromArgb(230, 228, 245);
            cbProveedores.ListTextColor = Color.DimGray;
            cbProveedores.Location = new Point(12, 47);
            cbProveedores.MinimumSize = new Size(200, 30);
            cbProveedores.Name = "cbProveedores";
            cbProveedores.Padding = new Padding(1);
            cbProveedores.Size = new Size(479, 38);
            cbProveedores.TabIndex = 75;
            cbProveedores.Texts = "";
            cbProveedores.OnSelectedIndexChanged += cbProveedores_OnSelectedIndexChanged;
            cbProveedores.Leave += cbProveedores_Leave;
            // 
            // cbPlates
            // 
            cbPlates.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbPlates.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbPlates.BackColor = SystemColors.Window;
            cbPlates.BorderColor = Color.RoyalBlue;
            cbPlates.BorderSize = 1;
            cbPlates.DropDownStyle = ComboBoxStyle.DropDown;
            cbPlates.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbPlates.ForeColor = Color.DimGray;
            cbPlates.IconColor = Color.RoyalBlue;
            cbPlates.ListBackColor = Color.FromArgb(230, 228, 245);
            cbPlates.ListTextColor = Color.DimGray;
            cbPlates.Location = new Point(497, 47);
            cbPlates.MinimumSize = new Size(200, 30);
            cbPlates.Name = "cbPlates";
            cbPlates.Padding = new Padding(1);
            cbPlates.Size = new Size(201, 38);
            cbPlates.TabIndex = 76;
            cbPlates.Texts = "";
            cbPlates.Leave += cbPlates_Leave;
            // 
            // cbProductos
            // 
            cbProductos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbProductos.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbProductos.BackColor = SystemColors.Window;
            cbProductos.BorderColor = Color.RoyalBlue;
            cbProductos.BorderSize = 1;
            cbProductos.DropDownStyle = ComboBoxStyle.DropDown;
            cbProductos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbProductos.ForeColor = Color.DimGray;
            cbProductos.IconColor = Color.RoyalBlue;
            cbProductos.ListBackColor = Color.FromArgb(230, 228, 245);
            cbProductos.ListTextColor = Color.DimGray;
            cbProductos.Location = new Point(12, 116);
            cbProductos.MinimumSize = new Size(200, 30);
            cbProductos.Name = "cbProductos";
            cbProductos.Padding = new Padding(1);
            cbProductos.Size = new Size(686, 38);
            cbProductos.TabIndex = 79;
            cbProductos.Texts = "";
            cbProductos.OnSelectedIndexChanged += cbProductos_OnSelectedIndexChanged;
            cbProductos.Leave += cbProductos_Leave;
            // 
            // btnEliminarE
            // 
            btnEliminarE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminarE.BackColor = Color.Red;
            btnEliminarE.BackgroundColor = Color.Red;
            btnEliminarE.BorderColor = Color.PaleVioletRed;
            btnEliminarE.BorderRadius = 7;
            btnEliminarE.BorderSize = 0;
            btnEliminarE.FlatAppearance.BorderSize = 0;
            btnEliminarE.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnEliminarE.FlatStyle = FlatStyle.Flat;
            btnEliminarE.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminarE.ForeColor = Color.White;
            btnEliminarE.Location = new Point(12, 647);
            btnEliminarE.Margin = new Padding(3, 4, 3, 4);
            btnEliminarE.Name = "btnEliminarE";
            btnEliminarE.Size = new Size(155, 40);
            btnEliminarE.TabIndex = 99;
            btnEliminarE.Text = "Eliminar entrada";
            btnEliminarE.TextColor = Color.White;
            btnEliminarE.UseVisualStyleBackColor = false;
            btnEliminarE.Visible = false;
            btnEliminarE.Click += btnEliminarE_Click;
            // 
            // btnFinalizarE
            // 
            btnFinalizarE.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnFinalizarE.BackColor = Color.DarkOrange;
            btnFinalizarE.BackgroundColor = Color.DarkOrange;
            btnFinalizarE.BorderColor = Color.PaleVioletRed;
            btnFinalizarE.BorderRadius = 7;
            btnFinalizarE.BorderSize = 0;
            btnFinalizarE.FlatAppearance.BorderSize = 0;
            btnFinalizarE.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnFinalizarE.FlatStyle = FlatStyle.Flat;
            btnFinalizarE.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnFinalizarE.ForeColor = Color.White;
            btnFinalizarE.Location = new Point(211, 647);
            btnFinalizarE.Margin = new Padding(3, 4, 3, 4);
            btnFinalizarE.Name = "btnFinalizarE";
            btnFinalizarE.Size = new Size(155, 40);
            btnFinalizarE.TabIndex = 100;
            btnFinalizarE.Text = "Finalizar entrada";
            btnFinalizarE.TextColor = Color.White;
            btnFinalizarE.UseVisualStyleBackColor = false;
            btnFinalizarE.Visible = false;
            btnFinalizarE.Click += btnFinalizarE_Click;
            // 
            // btnCrearM
            // 
            btnCrearM.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCrearM.BackColor = SystemColors.HotTrack;
            btnCrearM.BackgroundColor = SystemColors.HotTrack;
            btnCrearM.BorderColor = Color.PaleVioletRed;
            btnCrearM.BorderRadius = 7;
            btnCrearM.BorderSize = 0;
            btnCrearM.FlatAppearance.BorderSize = 0;
            btnCrearM.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnCrearM.FlatStyle = FlatStyle.Flat;
            btnCrearM.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrearM.ForeColor = Color.White;
            btnCrearM.Location = new Point(372, 647);
            btnCrearM.Margin = new Padding(3, 4, 3, 4);
            btnCrearM.Name = "btnCrearM";
            btnCrearM.Size = new Size(155, 40);
            btnCrearM.TabIndex = 105;
            btnCrearM.Text = "Crear movimiento";
            btnCrearM.TextColor = Color.White;
            btnCrearM.UseVisualStyleBackColor = false;
            btnCrearM.Visible = false;
            btnCrearM.Click += btnCrearM_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(158, 21);
            label4.TabIndex = 106;
            label4.Text = "Peso Teórico Unitario:";
            // 
            // lblPesoTeoricoUnit
            // 
            lblPesoTeoricoUnit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblPesoTeoricoUnit.AutoSize = true;
            lblPesoTeoricoUnit.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblPesoTeoricoUnit.Location = new Point(176, 157);
            lblPesoTeoricoUnit.Name = "lblPesoTeoricoUnit";
            lblPesoTeoricoUnit.Size = new Size(0, 21);
            lblPesoTeoricoUnit.TabIndex = 107;
            // 
            // EntradaPorPesoTeorico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1257, 704);
            Controls.Add(lblPesoTeoricoUnit);
            Controls.Add(label4);
            Controls.Add(btnCrearM);
            Controls.Add(btnFinalizarE);
            Controls.Add(btnEliminarE);
            Controls.Add(cbProductos);
            Controls.Add(cbPlates);
            Controls.Add(cbProveedores);
            Controls.Add(btnGuardar);
            Controls.Add(groupBox1);
            Controls.Add(btnCerrar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Name = "EntradaPorPesoTeorico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "wControl - Entrada de Materia Prima (Registro Peso Teórico)";
            WindowState = FormWindowState.Maximized;
            Load += EntradaPorPesoTeorico_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Controles.RoundedBtn btnGuardar;
        private GroupBox groupBox1;
        private Controles.CustomeTextBox txtNumeroBultosRecibidos;
        private Label label10;
        private Controles.CustomeTextBox txtPesoRecibido;
        private Label label9;
        private Controles.CustomeTextBox txtNumeroBultosTeorico;
        private Label label8;
        private Controles.CustomeTextBox txtPesoManifestado;
        private Label label6;
        private Controles.CustomeTextBox txtHora;
        private Label label7;
        private Controles.CustomeTextBox txtFecha;
        private Label label5;
        private Controles.RoundedBtn btnCerrar;
        private Label label3;
        private Label label2;
        private Label label1;
        private Controles.CustomerComboBox cbProveedores;
        private Controles.CustomerComboBox cbPlates;
        private Controles.CustomerComboBox cbProductos;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Controles.RoundedBtn btnEliminarE;
        private Controles.RoundedBtn btnFinalizarE;
        private Controles.RoundedBtn btnCrearM;
        private Label label4;
        private Label lblPesoTeoricoUnit;
    }
}