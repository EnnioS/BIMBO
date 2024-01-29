namespace Presentacion.Vistas
{
    partial class GestionarMateriaPrima
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
            label5 = new Label();
            proveedoresDropDown = new Controles.CustomerComboBox();
            label1 = new Label();
            txtDescripcion = new Controles.CustomeTextBox();
            label2 = new Label();
            txtTara = new Controles.CustomeTextBox();
            label3 = new Label();
            txtNeto = new Controles.CustomeTextBox();
            label4 = new Label();
            txtPrecio = new Controles.CustomeTextBox();
            label6 = new Label();
            listViewMateriaPrima = new ListView();
            chlvCodigoProd = new ColumnHeader();
            chlvdescrProd = new ColumnHeader();
            chlvNomProv = new ColumnHeader();
            chlvProvIsActive = new ColumnHeader();
            btnNuevo = new Controles.RoundedBtn();
            btnCerrar = new Controles.RoundedBtn();
            btnGuardar = new Controles.RoundedBtn();
            listViewMateriaPrimaTop = new ListView();
            chCodigoProdXProv = new ColumnHeader();
            chDescProdXProv = new ColumnHeader();
            chlvEstado = new ColumnHeader();
            gbBuscarPor = new GroupBox();
            txtSeach = new Controles.CustomeTextBox();
            btnBuscar = new Controles.RoundedBtn();
            rbCodigo = new RadioButton();
            rbDescripcion = new RadioButton();
            ccbProducto = new Controles.CustomerComboBox();
            gbBuscarPor.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(11, 24);
            label5.Name = "label5";
            label5.Size = new Size(136, 21);
            label5.TabIndex = 55;
            label5.Text = "Código Proveedor";
            // 
            // proveedoresDropDown
            // 
            proveedoresDropDown.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            proveedoresDropDown.BackColor = SystemColors.Window;
            proveedoresDropDown.BorderColor = Color.RoyalBlue;
            proveedoresDropDown.BorderSize = 1;
            proveedoresDropDown.DropDownStyle = ComboBoxStyle.DropDown;
            proveedoresDropDown.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            proveedoresDropDown.ForeColor = Color.DimGray;
            proveedoresDropDown.IconColor = Color.RoyalBlue;
            proveedoresDropDown.ListBackColor = SystemColors.Window;
            proveedoresDropDown.ListTextColor = Color.DimGray;
            proveedoresDropDown.Location = new Point(11, 51);
            proveedoresDropDown.MinimumSize = new Size(200, 29);
            proveedoresDropDown.Name = "proveedoresDropDown";
            proveedoresDropDown.Padding = new Padding(1);
            proveedoresDropDown.Size = new Size(432, 36);
            proveedoresDropDown.TabIndex = 54;
            proveedoresDropDown.Texts = "";
            proveedoresDropDown.OnSelectedIndexChanged += proveedoresDropDown_OnSelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 95);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 56;
            label1.Text = "Código Producto";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.Window;
            txtDescripcion.BorderColor = Color.RoyalBlue;
            txtDescripcion.BorderFocusColor = Color.SteelBlue;
            txtDescripcion.BorderRadius = 7;
            txtDescripcion.BorderSize = 1;
            txtDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.ForeColor = Color.DimGray;
            txtDescripcion.Location = new Point(15, 197);
            txtDescripcion.Margin = new Padding(5, 4, 5, 4);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Padding = new Padding(7);
            txtDescripcion.PasswordChar = false;
            txtDescripcion.PlaceholderColor = Color.DarkGray;
            txtDescripcion.PlaceholderText = "";
            txtDescripcion.Size = new Size(429, 93);
            txtDescripcion.TabIndex = 59;
            txtDescripcion.Texts = "";
            txtDescripcion.UnderlinedStyle = false;
            txtDescripcion.Leave += txtDescripcion_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 172);
            label2.Name = "label2";
            label2.Size = new Size(183, 21);
            label2.TabIndex = 58;
            label2.Text = "Descripción del Producto";
            // 
            // txtTara
            // 
            txtTara.BackColor = SystemColors.Window;
            txtTara.BorderColor = Color.RoyalBlue;
            txtTara.BorderFocusColor = Color.SteelBlue;
            txtTara.BorderRadius = 7;
            txtTara.BorderSize = 1;
            txtTara.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTara.ForeColor = Color.DimGray;
            txtTara.Location = new Point(453, 248);
            txtTara.Margin = new Padding(5, 4, 5, 4);
            txtTara.Multiline = false;
            txtTara.Name = "txtTara";
            txtTara.Padding = new Padding(7);
            txtTara.PasswordChar = false;
            txtTara.PlaceholderColor = Color.DarkGray;
            txtTara.PlaceholderText = "";
            txtTara.Size = new Size(254, 43);
            txtTara.TabIndex = 61;
            txtTara.Texts = "0.0000000000";
            txtTara.UnderlinedStyle = false;
            txtTara.KeyPress += txtTara_KeyPress;
            txtTara.Leave += txtTara_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(453, 223);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 60;
            label3.Text = "Tara de Embalaje";
            // 
            // txtNeto
            // 
            txtNeto.BackColor = SystemColors.Window;
            txtNeto.BorderColor = Color.RoyalBlue;
            txtNeto.BorderFocusColor = Color.SteelBlue;
            txtNeto.BorderRadius = 7;
            txtNeto.BorderSize = 1;
            txtNeto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNeto.ForeColor = Color.DimGray;
            txtNeto.Location = new Point(714, 248);
            txtNeto.Margin = new Padding(5, 4, 5, 4);
            txtNeto.Multiline = false;
            txtNeto.Name = "txtNeto";
            txtNeto.Padding = new Padding(7);
            txtNeto.PasswordChar = false;
            txtNeto.PlaceholderColor = Color.DarkGray;
            txtNeto.PlaceholderText = "";
            txtNeto.Size = new Size(254, 43);
            txtNeto.TabIndex = 63;
            txtNeto.Texts = "0.0000000000";
            txtNeto.UnderlinedStyle = false;
            txtNeto.Leave += txtNeto_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(714, 223);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 62;
            label4.Text = "Peso Neto Teórico";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = SystemColors.Window;
            txtPrecio.BorderColor = Color.RoyalBlue;
            txtPrecio.BorderFocusColor = Color.SteelBlue;
            txtPrecio.BorderRadius = 7;
            txtPrecio.BorderSize = 1;
            txtPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.ForeColor = Color.DimGray;
            txtPrecio.Location = new Point(976, 248);
            txtPrecio.Margin = new Padding(5, 4, 5, 4);
            txtPrecio.Multiline = false;
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Padding = new Padding(7);
            txtPrecio.PasswordChar = false;
            txtPrecio.PlaceholderColor = Color.DarkGray;
            txtPrecio.PlaceholderText = "";
            txtPrecio.Size = new Size(267, 43);
            txtPrecio.TabIndex = 65;
            txtPrecio.Texts = "0.0000000000";
            txtPrecio.UnderlinedStyle = false;
            txtPrecio.Leave += txtPrecio_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(975, 223);
            label6.Name = "label6";
            label6.Size = new Size(157, 21);
            label6.TabIndex = 64;
            label6.Text = "Precio por Kilogramo";
            // 
            // listViewMateriaPrima
            // 
            listViewMateriaPrima.BackColor = Color.WhiteSmoke;
            listViewMateriaPrima.Columns.AddRange(new ColumnHeader[] { chlvCodigoProd, chlvdescrProd, chlvNomProv, chlvProvIsActive });
            listViewMateriaPrima.FullRowSelect = true;
            listViewMateriaPrima.GridLines = true;
            listViewMateriaPrima.HoverSelection = true;
            listViewMateriaPrima.Location = new Point(10, 403);
            listViewMateriaPrima.Name = "listViewMateriaPrima";
            listViewMateriaPrima.Size = new Size(1230, 432);
            listViewMateriaPrima.TabIndex = 72;
            listViewMateriaPrima.UseCompatibleStateImageBehavior = false;
            listViewMateriaPrima.View = View.Details;
            listViewMateriaPrima.MouseDown += listViewMateriaPrima_MouseDown;
            // 
            // chlvCodigoProd
            // 
            chlvCodigoProd.Text = "Código";
            chlvCodigoProd.Width = 150;
            // 
            // chlvdescrProd
            // 
            chlvdescrProd.Text = "Descripción";
            chlvdescrProd.Width = 650;
            // 
            // chlvNomProv
            // 
            chlvNomProv.Text = "Proveedor";
            chlvNomProv.Width = 250;
            // 
            // chlvProvIsActive
            // 
            chlvProvIsActive.Text = "Estado del Proveedor";
            chlvProvIsActive.Width = 176;
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
            btnNuevo.Location = new Point(13, 841);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(101, 40);
            btnNuevo.TabIndex = 72;
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
            btnCerrar.Location = new Point(225, 841);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(101, 40);
            btnCerrar.TabIndex = 75;
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
            btnGuardar.Location = new Point(119, 841);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 40);
            btnGuardar.TabIndex = 74;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // listViewMateriaPrimaTop
            // 
            listViewMateriaPrimaTop.BackColor = Color.WhiteSmoke;
            listViewMateriaPrimaTop.Columns.AddRange(new ColumnHeader[] { chCodigoProdXProv, chDescProdXProv, chlvEstado });
            listViewMateriaPrimaTop.HoverSelection = true;
            listViewMateriaPrimaTop.Location = new Point(448, 49);
            listViewMateriaPrimaTop.Name = "listViewMateriaPrimaTop";
            listViewMateriaPrimaTop.Size = new Size(791, 169);
            listViewMateriaPrimaTop.TabIndex = 66;
            listViewMateriaPrimaTop.UseCompatibleStateImageBehavior = false;
            listViewMateriaPrimaTop.View = View.Details;
            // 
            // chCodigoProdXProv
            // 
            chCodigoProdXProv.Text = "Código";
            chCodigoProdXProv.Width = 150;
            // 
            // chDescProdXProv
            // 
            chDescProdXProv.Text = "Descripción";
            chDescProdXProv.Width = 476;
            // 
            // chlvEstado
            // 
            chlvEstado.Text = "Estado del Producto";
            chlvEstado.Width = 200;
            // 
            // gbBuscarPor
            // 
            gbBuscarPor.Controls.Add(txtSeach);
            gbBuscarPor.Controls.Add(btnBuscar);
            gbBuscarPor.Controls.Add(rbCodigo);
            gbBuscarPor.Controls.Add(rbDescripcion);
            gbBuscarPor.Location = new Point(15, 309);
            gbBuscarPor.Name = "gbBuscarPor";
            gbBuscarPor.Size = new Size(1224, 88);
            gbBuscarPor.TabIndex = 67;
            gbBuscarPor.TabStop = false;
            gbBuscarPor.Text = "Buscar por";
            // 
            // txtSeach
            // 
            txtSeach.BackColor = SystemColors.Window;
            txtSeach.BorderColor = Color.RoyalBlue;
            txtSeach.BorderFocusColor = Color.SteelBlue;
            txtSeach.BorderRadius = 7;
            txtSeach.BorderSize = 1;
            txtSeach.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSeach.ForeColor = Color.DimGray;
            txtSeach.Location = new Point(209, 31);
            txtSeach.Margin = new Padding(4);
            txtSeach.Multiline = false;
            txtSeach.Name = "txtSeach";
            txtSeach.Padding = new Padding(7);
            txtSeach.PasswordChar = false;
            txtSeach.PlaceholderColor = Color.DarkGray;
            txtSeach.PlaceholderText = "";
            txtSeach.Size = new Size(736, 43);
            txtSeach.TabIndex = 70;
            txtSeach.Texts = "";
            txtSeach.UnderlinedStyle = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.HotTrack;
            btnBuscar.BackgroundColor = SystemColors.HotTrack;
            btnBuscar.BorderColor = Color.PaleVioletRed;
            btnBuscar.BorderRadius = 7;
            btnBuscar.BorderSize = 0;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Image = Properties.Resources.search_20x20px;
            btnBuscar.Location = new Point(952, 32);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 40);
            btnBuscar.TabIndex = 71;
            btnBuscar.TextColor = Color.White;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // rbCodigo
            // 
            rbCodigo.AutoSize = true;
            rbCodigo.Location = new Point(15, 54);
            rbCodigo.Name = "rbCodigo";
            rbCodigo.Size = new Size(79, 24);
            rbCodigo.TabIndex = 69;
            rbCodigo.Text = "Código";
            rbCodigo.UseVisualStyleBackColor = true;
            // 
            // rbDescripcion
            // 
            rbDescripcion.AutoSize = true;
            rbDescripcion.Checked = true;
            rbDescripcion.Location = new Point(15, 28);
            rbDescripcion.Name = "rbDescripcion";
            rbDescripcion.Size = new Size(108, 24);
            rbDescripcion.TabIndex = 68;
            rbDescripcion.TabStop = true;
            rbDescripcion.Text = "Descripción";
            rbDescripcion.UseVisualStyleBackColor = true;
            // 
            // ccbProducto
            // 
            ccbProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ccbProducto.BackColor = SystemColors.Window;
            ccbProducto.BorderColor = Color.RoyalBlue;
            ccbProducto.BorderSize = 1;
            ccbProducto.DropDownStyle = ComboBoxStyle.DropDown;
            ccbProducto.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ccbProducto.ForeColor = Color.DimGray;
            ccbProducto.IconColor = Color.RoyalBlue;
            ccbProducto.ListBackColor = SystemColors.Window;
            ccbProducto.ListTextColor = Color.DimGray;
            ccbProducto.Location = new Point(10, 121);
            ccbProducto.MinimumSize = new Size(200, 29);
            ccbProducto.Name = "ccbProducto";
            ccbProducto.Padding = new Padding(1);
            ccbProducto.Size = new Size(432, 36);
            ccbProducto.TabIndex = 57;
            ccbProducto.Texts = "";
            ccbProducto.OnSelectedIndexChanged += ccbProducto_OnSelectedIndexChanged;
            // 
            // GestionarMateriaPrima
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1257, 904);
            Controls.Add(ccbProducto);
            Controls.Add(gbBuscarPor);
            Controls.Add(listViewMateriaPrimaTop);
            Controls.Add(listViewMateriaPrima);
            Controls.Add(btnNuevo);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(label6);
            Controls.Add(txtNeto);
            Controls.Add(label4);
            Controls.Add(txtTara);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(proveedoresDropDown);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GestionarMateriaPrima";
            Text = "Gestionar Materia Prima";
            WindowState = FormWindowState.Maximized;
            Load += GestionarMateriaPrima_Load;
            gbBuscarPor.ResumeLayout(false);
            gbBuscarPor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Controles.CustomerComboBox customerComboBox1;
        private Label label1;
        private Controles.CustomeTextBox txtDescripcion;
        private Label label2;
        private Controles.CustomeTextBox txtTara;
        private Label label3;
        private Controles.CustomeTextBox txtNeto;
        private Label label4;
        private Controles.CustomeTextBox txtPrecio;
        private Label label6;
        private ListView listViewMateriaPrima;
        private ColumnHeader chlvCodigoProd;
        private ColumnHeader chlvNomProv;
        private ColumnHeader chlvdescrProd;
        private Controles.RoundedBtn btnNuevo;
        private Controles.RoundedBtn btnCerrar;
        private Controles.RoundedBtn btnGuardar;
        private ListView listViewMateriaPrimaTop;
        private ColumnHeader chCodigoProdXProv;
        private ColumnHeader chDescProdXProv;
        private Controles.CustomerComboBox proveedoresDropDown;
        private GroupBox gbBuscarPor;
        private Controles.CustomeTextBox txtSeach;
        private Controles.RoundedBtn btnBuscar;
        private RadioButton rbCodigo;
        private RadioButton rbDescripcion;
        private ColumnHeader chlvProvIsActive;
        private ColumnHeader chlvEstado;
        private Controles.CustomerComboBox ccbProducto;
    }
}