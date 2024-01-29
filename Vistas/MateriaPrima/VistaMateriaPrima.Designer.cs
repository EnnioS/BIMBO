namespace Presentacion.Vistas.MateriaPrima
{
    partial class VistaMateriaPrima
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
            btnNuevoTeorico = new Controles.RoundedBtn();
            lvEntries = new ListView();
            chlvCodigoProd = new ColumnHeader();
            chlvdescrProd = new ColumnHeader();
            chlvNomProv = new ColumnHeader();
            chlvPlateNum = new ColumnHeader();
            chlvDateRecorded = new ColumnHeader();
            chlvTeoricWeight = new ColumnHeader();
            chlvBagNum = new ColumnHeader();
            chlvPesoRecibido = new ColumnHeader();
            chlvNumBagRecived = new ColumnHeader();
            chlvProvId = new ColumnHeader();
            chlvEntryCode = new ColumnHeader();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            lvMovements = new ListView();
            chlvCodigoBal = new ColumnHeader();
            chlvDescripcionBal = new ColumnHeader();
            chlvProveedorBal = new ColumnHeader();
            chlvPesoManifestado = new ColumnHeader();
            chlvMovementId = new ColumnHeader();
            chlvEntryId = new ColumnHeader();
            chlvPesoTeorico = new ColumnHeader();
            chlvPesoB = new ColumnHeader();
            chlvTaraE = new ColumnHeader();
            chlsTaraI = new ColumnHeader();
            btnCerrar = new Controles.RoundedBtn();
            btnPesoT = new Controles.RoundedBtn();
            txtPesoT = new Controles.CustomeTextBox();
            SuspendLayout();
            // 
            // btnNuevoTeorico
            // 
            btnNuevoTeorico.BackColor = SystemColors.HotTrack;
            btnNuevoTeorico.BackgroundColor = SystemColors.HotTrack;
            btnNuevoTeorico.BorderColor = Color.PaleVioletRed;
            btnNuevoTeorico.BorderRadius = 7;
            btnNuevoTeorico.BorderSize = 0;
            btnNuevoTeorico.FlatAppearance.BorderSize = 0;
            btnNuevoTeorico.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnNuevoTeorico.FlatStyle = FlatStyle.Flat;
            btnNuevoTeorico.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoTeorico.ForeColor = Color.White;
            btnNuevoTeorico.Location = new Point(1140, 845);
            btnNuevoTeorico.Margin = new Padding(3, 4, 3, 4);
            btnNuevoTeorico.Name = "btnNuevoTeorico";
            btnNuevoTeorico.Size = new Size(100, 40);
            btnNuevoTeorico.TabIndex = 86;
            btnNuevoTeorico.Text = "Nuevo";
            btnNuevoTeorico.TextColor = Color.White;
            btnNuevoTeorico.UseVisualStyleBackColor = false;
            btnNuevoTeorico.Click += btnNuevoTeorico_Click;
            // 
            // lvEntries
            // 
            lvEntries.BackColor = Color.WhiteSmoke;
            lvEntries.Columns.AddRange(new ColumnHeader[] { chlvCodigoProd, chlvdescrProd, chlvNomProv, chlvPlateNum, chlvDateRecorded, chlvTeoricWeight, chlvBagNum, chlvPesoRecibido, chlvNumBagRecived, chlvProvId, chlvEntryCode });
            lvEntries.FullRowSelect = true;
            lvEntries.GridLines = true;
            lvEntries.HideSelection = true;
            lvEntries.HoverSelection = true;
            lvEntries.Location = new Point(10, 101);
            lvEntries.MultiSelect = false;
            lvEntries.Name = "lvEntries";
            lvEntries.Size = new Size(1230, 336);
            lvEntries.TabIndex = 79;
            lvEntries.UseCompatibleStateImageBehavior = false;
            lvEntries.View = View.Details;
            lvEntries.MouseDoubleClick += lvEntries_MouseDoubleClick;
            // 
            // chlvCodigoProd
            // 
            chlvCodigoProd.Text = "Código";
            chlvCodigoProd.Width = 150;
            // 
            // chlvdescrProd
            // 
            chlvdescrProd.Text = "Descripción";
            chlvdescrProd.Width = 455;
            // 
            // chlvNomProv
            // 
            chlvNomProv.Text = "Proveedor";
            chlvNomProv.Width = 300;
            // 
            // chlvPlateNum
            // 
            chlvPlateNum.Text = "Número de placa";
            chlvPlateNum.Width = 0;
            // 
            // chlvDateRecorded
            // 
            chlvDateRecorded.Text = "Fecha";
            chlvDateRecorded.Width = 0;
            // 
            // chlvTeoricWeight
            // 
            chlvTeoricWeight.Text = "Peso Teórico";
            chlvTeoricWeight.Width = 160;
            // 
            // chlvBagNum
            // 
            chlvBagNum.Text = "Número de bolsas";
            chlvBagNum.Width = 160;
            // 
            // chlvPesoRecibido
            // 
            chlvPesoRecibido.Text = "Peso Balanza";
            chlvPesoRecibido.Width = 0;
            // 
            // chlvNumBagRecived
            // 
            chlvNumBagRecived.Text = "Bolsas x Balanza";
            chlvNumBagRecived.Width = 0;
            // 
            // chlvProvId
            // 
            chlvProvId.Text = "Código Proveedor";
            chlvProvId.Width = 0;
            // 
            // chlvEntryCode
            // 
            chlvEntryCode.Text = "Id Enrtrada";
            chlvEntryCode.Width = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(226, 21);
            label7.TabIndex = 76;
            label7.Text = "Buscar por Código de Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 77);
            label1.Name = "label1";
            label1.Size = new Size(457, 21);
            label1.TabIndex = 76;
            label1.Text = "Listado de Entrada de Materia Prima (Peso Teórico Manifestados)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 468);
            label2.Name = "label2";
            label2.Size = new Size(486, 21);
            label2.TabIndex = 83;
            label2.Text = "Listado a editar de Movimientos de Materia Prima (Peso por Balanza)";
            // 
            // lvMovements
            // 
            lvMovements.BackColor = Color.WhiteSmoke;
            lvMovements.Columns.AddRange(new ColumnHeader[] { chlvCodigoBal, chlvDescripcionBal, chlvProveedorBal, chlvPesoManifestado, chlvMovementId, chlvEntryId, chlvPesoTeorico, chlvPesoB, chlvTaraE, chlsTaraI });
            lvMovements.FullRowSelect = true;
            lvMovements.GridLines = true;
            lvMovements.HideSelection = true;
            lvMovements.HoverSelection = true;
            lvMovements.Location = new Point(10, 492);
            lvMovements.MultiSelect = false;
            lvMovements.Name = "lvMovements";
            lvMovements.Size = new Size(1230, 346);
            lvMovements.TabIndex = 84;
            lvMovements.UseCompatibleStateImageBehavior = false;
            lvMovements.View = View.Details;
            lvMovements.MouseDoubleClick += lvMovements_MouseDoubleClick;
            // 
            // chlvCodigoBal
            // 
            chlvCodigoBal.Text = "Código";
            chlvCodigoBal.Width = 150;
            // 
            // chlvDescripcionBal
            // 
            chlvDescripcionBal.Text = "Descripción";
            chlvDescripcionBal.Width = 400;
            // 
            // chlvProveedorBal
            // 
            chlvProveedorBal.Text = "Proveedor";
            chlvProveedorBal.Width = 300;
            // 
            // chlvPesoManifestado
            // 
            chlvPesoManifestado.Text = "Peso Manifestado";
            chlvPesoManifestado.Width = 150;
            // 
            // chlvMovementId
            // 
            chlvMovementId.Width = 0;
            // 
            // chlvEntryId
            // 
            chlvEntryId.Width = 0;
            // 
            // chlvPesoTeorico
            // 
            chlvPesoTeorico.Text = "Peso Teórico";
            chlvPesoTeorico.Width = 150;
            // 
            // chlvPesoB
            // 
            chlvPesoB.Text = "PesoBruto";
            chlvPesoB.Width = 150;
            // 
            // chlvTaraE
            // 
            chlvTaraE.Text = "Tara Extra";
            chlvTaraE.Width = 150;
            // 
            // chlsTaraI
            // 
            chlsTaraI.Text = "Tara individual";
            chlsTaraI.Width = 150;
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
            btnCerrar.Location = new Point(1034, 845);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 40);
            btnCerrar.TabIndex = 85;
            btnCerrar.Text = "Cerrar";
            btnCerrar.TextColor = Color.White;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnPesoT
            // 
            btnPesoT.BackColor = SystemColors.HotTrack;
            btnPesoT.BackgroundColor = SystemColors.HotTrack;
            btnPesoT.BorderColor = Color.PaleVioletRed;
            btnPesoT.BorderRadius = 7;
            btnPesoT.BorderSize = 0;
            btnPesoT.FlatAppearance.BorderSize = 0;
            btnPesoT.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnPesoT.FlatStyle = FlatStyle.Flat;
            btnPesoT.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnPesoT.ForeColor = Color.White;
            btnPesoT.Image = Properties.Resources.search_20x20px;
            btnPesoT.Location = new Point(442, 30);
            btnPesoT.Margin = new Padding(3, 4, 3, 4);
            btnPesoT.Name = "btnPesoT";
            btnPesoT.Size = new Size(100, 40);
            btnPesoT.TabIndex = 78;
            btnPesoT.TextColor = Color.White;
            btnPesoT.UseVisualStyleBackColor = false;
            btnPesoT.Click += btnPesoT_Click;
            // 
            // txtPesoT
            // 
            txtPesoT.BackColor = SystemColors.Window;
            txtPesoT.BorderColor = Color.RoyalBlue;
            txtPesoT.BorderFocusColor = Color.SteelBlue;
            txtPesoT.BorderRadius = 7;
            txtPesoT.BorderSize = 1;
            txtPesoT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPesoT.ForeColor = Color.DimGray;
            txtPesoT.Location = new Point(14, 30);
            txtPesoT.Margin = new Padding(4);
            txtPesoT.Multiline = false;
            txtPesoT.Name = "txtPesoT";
            txtPesoT.Padding = new Padding(7);
            txtPesoT.PasswordChar = false;
            txtPesoT.PlaceholderColor = Color.DarkGray;
            txtPesoT.PlaceholderText = "";
            txtPesoT.Size = new Size(421, 43);
            txtPesoT.TabIndex = 77;
            txtPesoT.Texts = "";
            txtPesoT.UnderlinedStyle = false;
            // 
            // VistaMateriaPrima
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1257, 904);
            Controls.Add(txtPesoT);
            Controls.Add(btnPesoT);
            Controls.Add(btnCerrar);
            Controls.Add(label2);
            Controls.Add(lvMovements);
            Controls.Add(label1);
            Controls.Add(btnNuevoTeorico);
            Controls.Add(lvEntries);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "VistaMateriaPrima";
            Text = "Entradas de  Materia Prima";
            WindowState = FormWindowState.Maximized;
            Load += VistaMateriaPrima_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controles.RoundedBtn btnNuevoTeorico;
        private ListView lvEntries;
        private ColumnHeader chlvCodigoProd;
        private ColumnHeader chlvdescrProd;
        private ColumnHeader chlvNomProv;
        private Label label7;
        private Label label1;
        private Label label2;
        private ListView lvMovements;
        private ColumnHeader chlvCodigoBal;
        private ColumnHeader chlvDescripcionBal;
        private ColumnHeader chlvProveedorBal;
        private Controles.RoundedBtn btnCerrar;
        private ColumnHeader chlvPesoManifestado;
        private Controles.RoundedBtn btnPesoT;
        private ColumnHeader chlvEntryId;
        private ColumnHeader chlvMovementId;
        private Controles.CustomeTextBox txtPesoT;
        private ColumnHeader chlvPlateNum;
        private ColumnHeader chlvDateRecorded;
        private ColumnHeader chlvTeoricWeight;
        private ColumnHeader chlvBagNum;
        private ColumnHeader chlvPesoRecibido;
        private ColumnHeader chlvNumBagRecived;
        private ColumnHeader chlvProvId;
        private ColumnHeader chlvPesoTeorico;
        private ColumnHeader chlvPesoB;
        private ColumnHeader chlvTaraE;
        private ColumnHeader chlsTaraI;
        private ColumnHeader chlvEntryCode;
    }
}