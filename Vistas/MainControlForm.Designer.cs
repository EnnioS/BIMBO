namespace Presentacion.Vistas
{
    partial class mainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenuForm));
            mcMainBtnContainer = new MaterialSkin.Controls.MaterialCard();
            lblUserName = new Label();
            pictureBox1 = new PictureBox();
            grpGestionUser = new GroupBox();
            label6 = new Label();
            btnGestionUsuario = new Controles.RoundedBtn();
            grpGestionProveedores = new GroupBox();
            label4 = new Label();
            btnGestionProveedor = new Controles.RoundedBtn();
            grpReporte = new GroupBox();
            label3 = new Label();
            btnGestionReportes = new Controles.RoundedBtn();
            grpEntradaMateria = new GroupBox();
            label5 = new Label();
            roundedBtn4 = new Controles.RoundedBtn();
            grpGestionMateria = new GroupBox();
            label2 = new Label();
            btnGestionMP = new Controles.RoundedBtn();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            mcMainBtnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpGestionUser.SuspendLayout();
            grpGestionProveedores.SuspendLayout();
            grpReporte.SuspendLayout();
            grpEntradaMateria.SuspendLayout();
            grpGestionMateria.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // mcMainBtnContainer
            // 
            mcMainBtnContainer.BackColor = Color.FromArgb(255, 255, 255);
            mcMainBtnContainer.Controls.Add(lblUserName);
            mcMainBtnContainer.Controls.Add(pictureBox1);
            mcMainBtnContainer.Controls.Add(grpGestionUser);
            mcMainBtnContainer.Controls.Add(grpGestionProveedores);
            mcMainBtnContainer.Controls.Add(grpReporte);
            mcMainBtnContainer.Controls.Add(grpEntradaMateria);
            mcMainBtnContainer.Controls.Add(grpGestionMateria);
            mcMainBtnContainer.Controls.Add(menuStrip1);
            mcMainBtnContainer.Depth = 0;
            mcMainBtnContainer.Dock = DockStyle.Fill;
            mcMainBtnContainer.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcMainBtnContainer.Location = new Point(0, 0);
            mcMainBtnContainer.Margin = new Padding(14);
            mcMainBtnContainer.MouseState = MaterialSkin.MouseState.HOVER;
            mcMainBtnContainer.Name = "mcMainBtnContainer";
            mcMainBtnContainer.Padding = new Padding(14);
            mcMainBtnContainer.Size = new Size(1262, 909);
            mcMainBtnContainer.TabIndex = 19;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.Location = new Point(17, 55);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(0, 28);
            lblUserName.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Image = Properties.Resources.bimbo_logo;
            pictureBox1.Location = new Point(1041, 682);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // grpGestionUser
            // 
            grpGestionUser.BackColor = Color.LightGray;
            grpGestionUser.Controls.Add(label6);
            grpGestionUser.Controls.Add(btnGestionUsuario);
            grpGestionUser.FlatStyle = FlatStyle.Flat;
            grpGestionUser.Location = new Point(557, 424);
            grpGestionUser.Name = "grpGestionUser";
            grpGestionUser.Size = new Size(186, 168);
            grpGestionUser.TabIndex = 31;
            grpGestionUser.TabStop = false;
            // 
            // label6
            // 
            label6.BackColor = Color.LightGray;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(186, 62);
            label6.TabIndex = 1;
            label6.Text = "Gestión de Usuarios";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGestionUsuario
            // 
            btnGestionUsuario.BackColor = SystemColors.ButtonFace;
            btnGestionUsuario.BackgroundColor = SystemColors.ButtonFace;
            btnGestionUsuario.BorderColor = Color.PaleVioletRed;
            btnGestionUsuario.BorderRadius = 0;
            btnGestionUsuario.BorderSize = 0;
            btnGestionUsuario.Cursor = Cursors.Hand;
            btnGestionUsuario.FlatAppearance.BorderSize = 0;
            btnGestionUsuario.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnGestionUsuario.FlatStyle = FlatStyle.Flat;
            btnGestionUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionUsuario.ForeColor = Color.Black;
            btnGestionUsuario.Location = new Point(0, 65);
            btnGestionUsuario.Name = "btnGestionUsuario";
            btnGestionUsuario.Size = new Size(186, 103);
            btnGestionUsuario.TabIndex = 0;
            btnGestionUsuario.Text = "Gestionar y definir datos de usuarios";
            btnGestionUsuario.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionUsuario.TextColor = Color.Black;
            btnGestionUsuario.UseVisualStyleBackColor = false;
            btnGestionUsuario.Click += btnGestionUsuario_Click;
            // 
            // grpGestionProveedores
            // 
            grpGestionProveedores.BackColor = Color.LightGray;
            grpGestionProveedores.Controls.Add(label4);
            grpGestionProveedores.Controls.Add(btnGestionProveedor);
            grpGestionProveedores.FlatStyle = FlatStyle.Flat;
            grpGestionProveedores.Location = new Point(352, 424);
            grpGestionProveedores.Name = "grpGestionProveedores";
            grpGestionProveedores.Size = new Size(186, 168);
            grpGestionProveedores.TabIndex = 32;
            grpGestionProveedores.TabStop = false;
            // 
            // label4
            // 
            label4.BackColor = Color.LightGray;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(186, 62);
            label4.TabIndex = 1;
            label4.Text = "Gestión de Proveedores";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGestionProveedor
            // 
            btnGestionProveedor.BackColor = SystemColors.ButtonFace;
            btnGestionProveedor.BackgroundColor = SystemColors.ButtonFace;
            btnGestionProveedor.BorderColor = Color.PaleVioletRed;
            btnGestionProveedor.BorderRadius = 0;
            btnGestionProveedor.BorderSize = 0;
            btnGestionProveedor.Cursor = Cursors.Hand;
            btnGestionProveedor.FlatAppearance.BorderSize = 0;
            btnGestionProveedor.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnGestionProveedor.FlatStyle = FlatStyle.Flat;
            btnGestionProveedor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionProveedor.ForeColor = Color.Black;
            btnGestionProveedor.Location = new Point(0, 65);
            btnGestionProveedor.Name = "btnGestionProveedor";
            btnGestionProveedor.Size = new Size(186, 103);
            btnGestionProveedor.TabIndex = 0;
            btnGestionProveedor.Text = "Gestionar y definir datos de proveedores";
            btnGestionProveedor.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionProveedor.TextColor = Color.Black;
            btnGestionProveedor.UseVisualStyleBackColor = false;
            btnGestionProveedor.Click += btnGestionProveedor_Click;
            // 
            // grpReporte
            // 
            grpReporte.BackColor = Color.LightGray;
            grpReporte.Controls.Add(label3);
            grpReporte.Controls.Add(btnGestionReportes);
            grpReporte.FlatStyle = FlatStyle.Flat;
            grpReporte.Location = new Point(762, 238);
            grpReporte.Name = "grpReporte";
            grpReporte.Size = new Size(186, 168);
            grpReporte.TabIndex = 30;
            grpReporte.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.LightGray;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(186, 62);
            label3.TabIndex = 1;
            label3.Text = "Reportes";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGestionReportes
            // 
            btnGestionReportes.BackColor = SystemColors.ButtonFace;
            btnGestionReportes.BackgroundColor = SystemColors.ButtonFace;
            btnGestionReportes.BorderColor = Color.PaleVioletRed;
            btnGestionReportes.BorderRadius = 0;
            btnGestionReportes.BorderSize = 0;
            btnGestionReportes.Cursor = Cursors.Hand;
            btnGestionReportes.FlatAppearance.BorderSize = 0;
            btnGestionReportes.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnGestionReportes.FlatStyle = FlatStyle.Flat;
            btnGestionReportes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionReportes.ForeColor = Color.Black;
            btnGestionReportes.Location = new Point(0, 65);
            btnGestionReportes.Name = "btnGestionReportes";
            btnGestionReportes.Size = new Size(186, 103);
            btnGestionReportes.TabIndex = 0;
            btnGestionReportes.Text = "Gestión de Reportes";
            btnGestionReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionReportes.TextColor = Color.Black;
            btnGestionReportes.UseVisualStyleBackColor = false;
            btnGestionReportes.Click += btnGestionReportes_Click;
            // 
            // grpEntradaMateria
            // 
            grpEntradaMateria.BackColor = Color.LightGray;
            grpEntradaMateria.Controls.Add(label5);
            grpEntradaMateria.Controls.Add(roundedBtn4);
            grpEntradaMateria.FlatStyle = FlatStyle.Flat;
            grpEntradaMateria.Location = new Point(557, 238);
            grpEntradaMateria.Name = "grpEntradaMateria";
            grpEntradaMateria.Size = new Size(186, 168);
            grpEntradaMateria.TabIndex = 29;
            grpEntradaMateria.TabStop = false;
            // 
            // label5
            // 
            label5.BackColor = Color.LightGray;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(186, 62);
            label5.TabIndex = 1;
            label5.Text = "Entrada de Materia Prima";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // roundedBtn4
            // 
            roundedBtn4.BackColor = SystemColors.ButtonFace;
            roundedBtn4.BackgroundColor = SystemColors.ButtonFace;
            roundedBtn4.BorderColor = Color.PaleVioletRed;
            roundedBtn4.BorderRadius = 0;
            roundedBtn4.BorderSize = 0;
            roundedBtn4.Cursor = Cursors.Hand;
            roundedBtn4.FlatAppearance.BorderSize = 0;
            roundedBtn4.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            roundedBtn4.FlatStyle = FlatStyle.Flat;
            roundedBtn4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            roundedBtn4.ForeColor = Color.Black;
            roundedBtn4.Location = new Point(0, 65);
            roundedBtn4.Name = "roundedBtn4";
            roundedBtn4.Size = new Size(186, 103);
            roundedBtn4.TabIndex = 0;
            roundedBtn4.Text = "Registra un movimiento de Materia Prima";
            roundedBtn4.TextAlign = ContentAlignment.MiddleLeft;
            roundedBtn4.TextColor = Color.Black;
            roundedBtn4.UseVisualStyleBackColor = false;
            roundedBtn4.Click += roundedBtn4_Click;
            // 
            // grpGestionMateria
            // 
            grpGestionMateria.BackColor = Color.LightGray;
            grpGestionMateria.Controls.Add(label2);
            grpGestionMateria.Controls.Add(btnGestionMP);
            grpGestionMateria.FlatStyle = FlatStyle.Flat;
            grpGestionMateria.Location = new Point(352, 238);
            grpGestionMateria.Name = "grpGestionMateria";
            grpGestionMateria.Size = new Size(186, 168);
            grpGestionMateria.TabIndex = 28;
            grpGestionMateria.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(186, 62);
            label2.TabIndex = 1;
            label2.Text = "Gestion de Materia Prima";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnGestionMP
            // 
            btnGestionMP.BackColor = SystemColors.ButtonFace;
            btnGestionMP.BackgroundColor = SystemColors.ButtonFace;
            btnGestionMP.BorderColor = Color.PaleVioletRed;
            btnGestionMP.BorderRadius = 0;
            btnGestionMP.BorderSize = 0;
            btnGestionMP.Cursor = Cursors.Hand;
            btnGestionMP.FlatAppearance.BorderSize = 0;
            btnGestionMP.FlatAppearance.MouseOverBackColor = SystemColors.MenuHighlight;
            btnGestionMP.FlatStyle = FlatStyle.Flat;
            btnGestionMP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionMP.ForeColor = Color.Black;
            btnGestionMP.Location = new Point(0, 65);
            btnGestionMP.Name = "btnGestionMP";
            btnGestionMP.Size = new Size(186, 103);
            btnGestionMP.TabIndex = 0;
            btnGestionMP.Text = "Registrar entradas de Materia Prima";
            btnGestionMP.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionMP.TextColor = Color.Black;
            btnGestionMP.UseVisualStyleBackColor = false;
            btnGestionMP.Click += btnGestionMP_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Window;
            menuStrip1.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(14, 14);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1234, 29);
            menuStrip1.TabIndex = 34;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.RightToLeft = RightToLeft.No;
            toolStripMenuItem1.Size = new Size(163, 25);
            toolStripMenuItem1.Text = "Cerrar Aplicación";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // mainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1262, 909);
            Controls.Add(mcMainBtnContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "mainMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "wControl";
            Load += mainMenuForm_Load;
            mcMainBtnContainer.ResumeLayout(false);
            mcMainBtnContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpGestionUser.ResumeLayout(false);
            grpGestionProveedores.ResumeLayout(false);
            grpReporte.ResumeLayout(false);
            grpEntradaMateria.ResumeLayout(false);
            grpGestionMateria.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard mcMainBtnContainer;
        private PictureBox pictureBox1;
        private GroupBox grpGestionUser;
        private Label label6;
        private Controles.RoundedBtn btnGestionUsuario;
        private GroupBox grpGestionProveedores;
        private Label label4;
        private Controles.RoundedBtn btnGestionProveedor;
        private GroupBox grpReporte;
        private Label label3;
        private Controles.RoundedBtn btnGestionReportes;
        private GroupBox grpEntradaMateria;
        private Label label5;
        private Controles.RoundedBtn roundedBtn4;
        private GroupBox grpGestionMateria;
        private Label label2;
        private Controles.RoundedBtn btnGestionMP;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label lblUserName;
    }
}