namespace Presentacion.Vistas.Reportes
{
    partial class ReportesForm
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
            btnCerrar = new Controles.RoundedBtn();
            btnGuardar = new Controles.RoundedBtn();
            gbBuscarPor = new GroupBox();
            dpHasta = new Controles.CustomeDatePicker();
            dpDesde = new Controles.CustomeDatePicker();
            lblHasta = new Label();
            lblDesde = new Label();
            cbReportes = new Controles.CustomerComboBox();
            btnVerReporte = new Controles.RoundedBtn();
            rbPorFecha = new RadioButton();
            rbTodos = new RadioButton();
            chlvCodigoProd = new ColumnHeader();
            chlvdescrProd = new ColumnHeader();
            chlvNomProv = new ColumnHeader();
            chlvProvIsActive = new ColumnHeader();
            lvProvProduct = new ListView();
            chlvFechaRegistro = new ColumnHeader();
            lvProvider = new ListView();
            chlvCodigoProv = new ColumnHeader();
            chlvNameProv = new ColumnHeader();
            chlvDirProv = new ColumnHeader();
            chlvTel1Prov = new ColumnHeader();
            chlvEmailProv = new ColumnHeader();
            chlvContact = new ColumnHeader();
            chlvCreatedAt = new ColumnHeader();
            chlvActiveProv = new ColumnHeader();
            lvProduct = new ListView();
            chlvId = new ColumnHeader();
            chlvDescripcion = new ColumnHeader();
            chlvFechareg = new ColumnHeader();
            chlvPesoNeto = new ColumnHeader();
            chlvTara = new ColumnHeader();
            cllvPesoKg = new ColumnHeader();
            lvEntry = new ListView();
            chlvRecordateEntry = new ColumnHeader();
            chlvIdProd = new ColumnHeader();
            chlvDescProd = new ColumnHeader();
            chlvCodProv = new ColumnHeader();
            chlvProvider = new ColumnHeader();
            chlvPlacaEntry = new ColumnHeader();
            chlvPesadorEntry = new ColumnHeader();
            chlvBolsasManiEntry = new ColumnHeader();
            chlvPesoManiEntry = new ColumnHeader();
            chlvBolsasReciEntry = new ColumnHeader();
            chlvPesoRecEntry = new ColumnHeader();
            chlvPorcDesviacion = new ColumnHeader();
            chlvSePesoEntry = new ColumnHeader();
            chlvPorcDesvComent = new ColumnHeader();
            lvMovement = new ListView();
            chlvFechaRegMov = new ColumnHeader();
            chlvProdIdMov = new ColumnHeader();
            chlvDescMov = new ColumnHeader();
            chlvProvMov = new ColumnHeader();
            chlvPesadorMov = new ColumnHeader();
            chlvTaraIndMov = new ColumnHeader();
            chlvTaraExtraMov = new ColumnHeader();
            chlvPesoManiMov = new ColumnHeader();
            chlvEsPesadoMov = new ColumnHeader();
            gbBuscarPor.SuspendLayout();
            SuspendLayout();
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
            btnCerrar.Location = new Point(1144, 838);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(101, 40);
            btnCerrar.TabIndex = 85;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextColor = Color.White;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
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
            btnGuardar.Location = new Point(1038, 838);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 40);
            btnGuardar.TabIndex = 84;
            btnGuardar.Text = "Exportar";
            btnGuardar.TextColor = Color.White;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gbBuscarPor
            // 
            gbBuscarPor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbBuscarPor.Controls.Add(dpHasta);
            gbBuscarPor.Controls.Add(dpDesde);
            gbBuscarPor.Controls.Add(lblHasta);
            gbBuscarPor.Controls.Add(lblDesde);
            gbBuscarPor.Controls.Add(cbReportes);
            gbBuscarPor.Controls.Add(btnVerReporte);
            gbBuscarPor.Controls.Add(rbPorFecha);
            gbBuscarPor.Controls.Add(rbTodos);
            gbBuscarPor.Location = new Point(13, 22);
            gbBuscarPor.Name = "gbBuscarPor";
            gbBuscarPor.Size = new Size(1230, 94);
            gbBuscarPor.TabIndex = 78;
            gbBuscarPor.TabStop = false;
            gbBuscarPor.Text = "Reportes";
            // 
            // dpHasta
            // 
            dpHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dpHasta.BorderColor = SystemColors.HotTrack;
            dpHasta.BorderSize = 1;
            dpHasta.CustomFormat = "dd/MM/yyyy";
            dpHasta.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpHasta.Format = DateTimePickerFormat.Custom;
            dpHasta.Location = new Point(1046, 39);
            dpHasta.MinimumSize = new Size(0, 35);
            dpHasta.Name = "dpHasta";
            dpHasta.Size = new Size(145, 35);
            dpHasta.SkinColor = SystemColors.Window;
            dpHasta.TabIndex = 93;
            dpHasta.TextColor = Color.Black;
            dpHasta.Visible = false;
            // 
            // dpDesde
            // 
            dpDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dpDesde.BorderColor = SystemColors.HotTrack;
            dpDesde.BorderSize = 1;
            dpDesde.CustomFormat = "dd/MM/yyyy";
            dpDesde.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            dpDesde.Format = DateTimePickerFormat.Custom;
            dpDesde.Location = new Point(877, 39);
            dpDesde.MinimumSize = new Size(0, 35);
            dpDesde.Name = "dpDesde";
            dpDesde.Size = new Size(145, 35);
            dpDesde.SkinColor = SystemColors.Window;
            dpDesde.TabIndex = 92;
            dpDesde.TextColor = Color.Black;
            dpDesde.Visible = false;
            // 
            // lblHasta
            // 
            lblHasta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblHasta.Location = new Point(1044, 17);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(49, 21);
            lblHasta.TabIndex = 90;
            lblHasta.Text = "Hasta";
            lblHasta.Visible = false;
            // 
            // lblDesde
            // 
            lblDesde.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesde.Location = new Point(877, 17);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(53, 21);
            lblDesde.TabIndex = 89;
            lblDesde.Text = "Desde";
            lblDesde.Visible = false;
            // 
            // cbReportes
            // 
            cbReportes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbReportes.BackColor = SystemColors.Window;
            cbReportes.BorderColor = Color.RoyalBlue;
            cbReportes.BorderSize = 1;
            cbReportes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReportes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbReportes.ForeColor = Color.DimGray;
            cbReportes.IconColor = Color.RoyalBlue;
            cbReportes.Items.AddRange(new object[] { "Proveedores", "Productos", "Productos por Provedor", "Ingresos por peso Teórico", "Movimientos por Balanza" });
            cbReportes.ListBackColor = SystemColors.Window;
            cbReportes.ListTextColor = Color.DimGray;
            cbReportes.Location = new Point(80, 42);
            cbReportes.MinimumSize = new Size(200, 29);
            cbReportes.Name = "cbReportes";
            cbReportes.Padding = new Padding(1);
            cbReportes.Size = new Size(438, 36);
            cbReportes.TabIndex = 79;
            cbReportes.Texts = "";
            // 
            // btnVerReporte
            // 
            btnVerReporte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerReporte.BackColor = SystemColors.HotTrack;
            btnVerReporte.BackgroundColor = SystemColors.HotTrack;
            btnVerReporte.BorderColor = Color.PaleVioletRed;
            btnVerReporte.BorderRadius = 7;
            btnVerReporte.BorderSize = 0;
            btnVerReporte.FlatAppearance.BorderSize = 0;
            btnVerReporte.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnVerReporte.FlatStyle = FlatStyle.Flat;
            btnVerReporte.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerReporte.ForeColor = Color.White;
            btnVerReporte.Location = new Point(524, 39);
            btnVerReporte.Margin = new Padding(3, 4, 3, 4);
            btnVerReporte.Name = "btnVerReporte";
            btnVerReporte.Size = new Size(100, 40);
            btnVerReporte.TabIndex = 80;
            btnVerReporte.Text = "Ver";
            btnVerReporte.TextColor = Color.White;
            btnVerReporte.UseVisualStyleBackColor = false;
            btnVerReporte.Click += btnVerReporte_Click;
            // 
            // rbPorFecha
            // 
            rbPorFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbPorFecha.AutoSize = true;
            rbPorFecha.Location = new Point(734, 59);
            rbPorFecha.Name = "rbPorFecha";
            rbPorFecha.Size = new Size(91, 24);
            rbPorFecha.TabIndex = 82;
            rbPorFecha.Text = "Por fecha";
            rbPorFecha.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            rbTodos.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbTodos.AutoSize = true;
            rbTodos.Checked = true;
            rbTodos.Location = new Point(734, 33);
            rbTodos.Name = "rbTodos";
            rbTodos.Size = new Size(70, 24);
            rbTodos.TabIndex = 81;
            rbTodos.TabStop = true;
            rbTodos.Text = "Todos";
            rbTodos.UseVisualStyleBackColor = true;
            rbTodos.CheckedChanged += rbTodos_CheckedChanged;
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
            // lvProvProduct
            // 
            lvProvProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProvProduct.BackColor = Color.WhiteSmoke;
            lvProvProduct.Columns.AddRange(new ColumnHeader[] { chlvCodigoProd, chlvdescrProd, chlvNomProv, chlvFechaRegistro, chlvProvIsActive });
            lvProvProduct.FullRowSelect = true;
            lvProvProduct.GridLines = true;
            lvProvProduct.HoverSelection = true;
            lvProvProduct.Location = new Point(13, 122);
            lvProvProduct.Name = "lvProvProduct";
            lvProvProduct.Size = new Size(1230, 709);
            lvProvProduct.TabIndex = 83;
            lvProvProduct.UseCompatibleStateImageBehavior = false;
            lvProvProduct.View = View.Details;
            lvProvProduct.Visible = false;
            // 
            // chlvFechaRegistro
            // 
            chlvFechaRegistro.Text = "Fecha de registro";
            chlvFechaRegistro.Width = 140;
            // 
            // lvProvider
            // 
            lvProvider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProvider.BackColor = Color.WhiteSmoke;
            lvProvider.Columns.AddRange(new ColumnHeader[] { chlvCodigoProv, chlvNameProv, chlvDirProv, chlvTel1Prov, chlvEmailProv, chlvContact, chlvCreatedAt, chlvActiveProv });
            lvProvider.FullRowSelect = true;
            lvProvider.GridLines = true;
            lvProvider.HideSelection = true;
            lvProvider.HoverSelection = true;
            lvProvider.Location = new Point(13, 122);
            lvProvider.MultiSelect = false;
            lvProvider.Name = "lvProvider";
            lvProvider.RightToLeft = RightToLeft.No;
            lvProvider.Size = new Size(1230, 709);
            lvProvider.TabIndex = 86;
            lvProvider.UseCompatibleStateImageBehavior = false;
            lvProvider.View = View.Details;
            lvProvider.Visible = false;
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
            // chlvDirProv
            // 
            chlvDirProv.Text = "Dirección";
            chlvDirProv.Width = 450;
            // 
            // chlvTel1Prov
            // 
            chlvTel1Prov.Text = "Teléfonos";
            chlvTel1Prov.Width = 180;
            // 
            // chlvEmailProv
            // 
            chlvEmailProv.Text = "Email";
            chlvEmailProv.Width = 200;
            // 
            // chlvContact
            // 
            chlvContact.Text = "Contacto";
            chlvContact.Width = 160;
            // 
            // chlvCreatedAt
            // 
            chlvCreatedAt.Text = "Fecha de registro";
            chlvCreatedAt.Width = 140;
            // 
            // chlvActiveProv
            // 
            chlvActiveProv.Text = "Estado";
            chlvActiveProv.Width = 100;
            // 
            // lvProduct
            // 
            lvProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvProduct.BackColor = Color.WhiteSmoke;
            lvProduct.Columns.AddRange(new ColumnHeader[] { chlvId, chlvDescripcion, chlvFechareg, chlvPesoNeto, chlvTara, cllvPesoKg });
            lvProduct.FullRowSelect = true;
            lvProduct.GridLines = true;
            lvProduct.HoverSelection = true;
            lvProduct.Location = new Point(13, 122);
            lvProduct.Name = "lvProduct";
            lvProduct.Size = new Size(1230, 709);
            lvProduct.TabIndex = 87;
            lvProduct.UseCompatibleStateImageBehavior = false;
            lvProduct.View = View.Details;
            lvProduct.Visible = false;
            // 
            // chlvId
            // 
            chlvId.Text = "Código";
            chlvId.Width = 150;
            // 
            // chlvDescripcion
            // 
            chlvDescripcion.Text = "Descripción";
            chlvDescripcion.Width = 500;
            // 
            // chlvFechareg
            // 
            chlvFechareg.Text = "Fecha de registro";
            chlvFechareg.Width = 140;
            // 
            // chlvPesoNeto
            // 
            chlvPesoNeto.Text = "Peso neto";
            chlvPesoNeto.Width = 176;
            // 
            // chlvTara
            // 
            chlvTara.Text = "Tara";
            chlvTara.Width = 150;
            // 
            // cllvPesoKg
            // 
            cllvPesoKg.Text = "Peso por Kg";
            cllvPesoKg.Width = 140;
            // 
            // lvEntry
            // 
            lvEntry.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvEntry.BackColor = Color.WhiteSmoke;
            lvEntry.Columns.AddRange(new ColumnHeader[] { chlvRecordateEntry, chlvIdProd, chlvDescProd, chlvCodProv, chlvProvider, chlvPlacaEntry, chlvPesadorEntry, chlvBolsasManiEntry, chlvPesoManiEntry, chlvBolsasReciEntry, chlvPesoRecEntry, chlvPorcDesviacion, chlvSePesoEntry, chlvPorcDesvComent });
            lvEntry.FullRowSelect = true;
            lvEntry.GridLines = true;
            lvEntry.HoverSelection = true;
            lvEntry.Location = new Point(13, 122);
            lvEntry.Name = "lvEntry";
            lvEntry.Size = new Size(1230, 709);
            lvEntry.TabIndex = 88;
            lvEntry.UseCompatibleStateImageBehavior = false;
            lvEntry.View = View.Details;
            lvEntry.Visible = false;
            // 
            // chlvRecordateEntry
            // 
            chlvRecordateEntry.Text = "Fecha de registro";
            chlvRecordateEntry.Width = 140;
            // 
            // chlvIdProd
            // 
            chlvIdProd.Text = "Código Producto";
            chlvIdProd.Width = 140;
            // 
            // chlvDescProd
            // 
            chlvDescProd.Text = "Descripción";
            chlvDescProd.Width = 500;
            // 
            // chlvCodProv
            // 
            chlvCodProv.Text = "Código Proveedor";
            chlvCodProv.Width = 140;
            // 
            // chlvProvider
            // 
            chlvProvider.Text = "Proveedor";
            chlvProvider.Width = 400;
            // 
            // chlvPlacaEntry
            // 
            chlvPlacaEntry.Text = "Número de placa";
            chlvPlacaEntry.Width = 150;
            // 
            // chlvPesadorEntry
            // 
            chlvPesadorEntry.Text = "Pesador";
            chlvPesadorEntry.Width = 200;
            // 
            // chlvBolsasManiEntry
            // 
            chlvBolsasManiEntry.Text = "Número de Bultos Teórico";
            chlvBolsasManiEntry.Width = 150;
            // 
            // chlvPesoManiEntry
            // 
            chlvPesoManiEntry.Text = "Peso Manifestado";
            chlvPesoManiEntry.Width = 150;
            // 
            // chlvBolsasReciEntry
            // 
            chlvBolsasReciEntry.Text = "Número de Bultos";
            chlvBolsasReciEntry.Width = 150;
            // 
            // chlvPesoRecEntry
            // 
            chlvPesoRecEntry.Text = "Peso Neto Calculado";
            chlvPesoRecEntry.Width = 150;
            // 
            // chlvPorcDesviacion
            // 
            chlvPorcDesviacion.Text = "% Desv.";
            chlvPorcDesviacion.Width = 80;
            // 
            // chlvSePesoEntry
            // 
            chlvSePesoEntry.Text = "Pesado por balanza";
            chlvSePesoEntry.Width = 150;
            // 
            // chlvPorcDesvComent
            // 
            chlvPorcDesvComent.Text = "% Desv. Comentario";
            chlvPorcDesvComent.Width = 500;
            // 
            // lvMovement
            // 
            lvMovement.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvMovement.BackColor = Color.WhiteSmoke;
            lvMovement.Columns.AddRange(new ColumnHeader[] { chlvFechaRegMov, chlvProdIdMov, chlvDescMov, chlvProvMov, chlvPesadorMov, chlvTaraIndMov, chlvTaraExtraMov, chlvPesoManiMov, chlvEsPesadoMov });
            lvMovement.FullRowSelect = true;
            lvMovement.GridLines = true;
            lvMovement.HoverSelection = true;
            lvMovement.Location = new Point(12, 122);
            lvMovement.Name = "lvMovement";
            lvMovement.Size = new Size(1230, 611);
            lvMovement.TabIndex = 89;
            lvMovement.UseCompatibleStateImageBehavior = false;
            lvMovement.View = View.Details;
            lvMovement.Visible = false;
            // 
            // chlvFechaRegMov
            // 
            chlvFechaRegMov.Text = "Fecha de registro";
            chlvFechaRegMov.Width = 140;
            // 
            // chlvProdIdMov
            // 
            chlvProdIdMov.Text = "Código Producto";
            chlvProdIdMov.Width = 140;
            // 
            // chlvDescMov
            // 
            chlvDescMov.Text = "Descripción";
            chlvDescMov.Width = 500;
            // 
            // chlvProvMov
            // 
            chlvProvMov.Text = "Proveedor";
            chlvProvMov.Width = 300;
            // 
            // chlvPesadorMov
            // 
            chlvPesadorMov.Text = "Pesador";
            chlvPesadorMov.Width = 200;
            // 
            // chlvTaraIndMov
            // 
            chlvTaraIndMov.Text = "Tara Individual";
            chlvTaraIndMov.Width = 150;
            // 
            // chlvTaraExtraMov
            // 
            chlvTaraExtraMov.Text = "Tara Extra";
            chlvTaraExtraMov.Width = 150;
            // 
            // chlvPesoManiMov
            // 
            chlvPesoManiMov.Text = "Peso manifestado";
            chlvPesoManiMov.Width = 150;
            // 
            // chlvEsPesadoMov
            // 
            chlvEsPesadoMov.Text = "Pesado por balanza";
            chlvEsPesadoMov.Width = 150;
            // 
            // ReportesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1257, 904);
            Controls.Add(lvMovement);
            Controls.Add(lvEntry);
            Controls.Add(lvProduct);
            Controls.Add(lvProvider);
            Controls.Add(gbBuscarPor);
            Controls.Add(lvProvProduct);
            Controls.Add(btnCerrar);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ReportesForm";
            Text = "Reportes";
            WindowState = FormWindowState.Maximized;
            Load += ReportesForm_Load;
            gbBuscarPor.ResumeLayout(false);
            gbBuscarPor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Controles.RoundedBtn btnCerrar;
        private Controles.RoundedBtn btnGuardar;
        private GroupBox gbBuscarPor;
        private RadioButton rbPorFecha;
        private RadioButton rbTodos;
        private Controles.CustomerComboBox cbReportes;
        private Controles.RoundedBtn btnVerReporte;
        private Label lblHasta;
        private Label lblDesde;
        private ColumnHeader chlvCodigoProd;
        private ColumnHeader chlvdescrProd;
        private ColumnHeader chlvNomProv;
        private ColumnHeader chlvProvIsActive;
        private ListView lvProvProduct;
        private ListView lvProvider;
        private ColumnHeader chlvCodigoProv;
        private ColumnHeader chlvNameProv;
        private ColumnHeader chlvEmailProv;
        private ColumnHeader chlvTel1Prov;
        private ColumnHeader chlvDirProv;
        private ColumnHeader chlvActiveProv;
        private ColumnHeader chlvContact;
        private ColumnHeader chlvCreatedAt;
        private ColumnHeader chlvFechaRegistro;
        private ListView lvProduct;
        private ColumnHeader chlvId;
        private ColumnHeader chlvDescripcion;
        private ColumnHeader chlvFechareg;
        private ColumnHeader chlvPesoNeto;
        private ColumnHeader chlvTara;
        private ColumnHeader cllvPesoKg;
        private ListView lvEntry;
        private ColumnHeader chlvRecordateEntry;
        private ColumnHeader chlvIdProd;
        private ColumnHeader chlvDescProd;
        private ColumnHeader chlvCodProv;
        private ColumnHeader chlvProvider;
        private ColumnHeader chlvPesadorEntry;
        private ColumnHeader chlvPesoManiEntry;
        private ColumnHeader chlvPesoRecEntry;
        private ColumnHeader chlvBolsasManiEntry;
        private ColumnHeader chlvBolsasReciEntry;
        private ColumnHeader chlvSePesoEntry;
        private ColumnHeader chlvPlacaEntry;
        private ListView lvMovement;
        private ColumnHeader chlvFechaRegMov;
        private ColumnHeader chlvProdIdMov;
        private ColumnHeader chlvDescMov;
        private ColumnHeader chlvProvMov;
        private ColumnHeader chlvPesadorMov;
        private ColumnHeader chlvTaraIndMov;
        private ColumnHeader chlvPesoManiMov;
        private ColumnHeader chlvTaraExtraMov;
        private ColumnHeader chlvEsPesadoMov;
        private Controles.CustomeDatePicker dpDesde;
        private Controles.CustomeDatePicker dpHasta;
        private ColumnHeader chlvPorcDesviacion;
        private ColumnHeader chlvPorcDesvComent;
    }
}