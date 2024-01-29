namespace Presentacion.Controles
{
    partial class CustomeMaskedTextBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtMaskedCustom = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtMaskedCustom
            // 
            txtMaskedCustom.BorderStyle = BorderStyle.None;
            txtMaskedCustom.Dock = DockStyle.Fill;
            txtMaskedCustom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaskedCustom.Location = new Point(7, 7);
            txtMaskedCustom.Mask = "(999)0000-0000";
            txtMaskedCustom.Name = "txtMaskedCustom";
            txtMaskedCustom.Size = new Size(236, 27);
            txtMaskedCustom.TabIndex = 0;
            // 
            // CustomeMaskedTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(txtMaskedCustom);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            Name = "CustomeMaskedTextBox";
            Padding = new Padding(7);
            Size = new Size(250, 42);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtMaskedCustom;
    }
}
