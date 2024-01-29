namespace Presentacion.Controles
{
    partial class CustomeTextBox
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
            txtCustom = new TextBox();
            SuspendLayout();
            // 
            // txtCustom
            // 
            txtCustom.BorderStyle = BorderStyle.None;
            txtCustom.Dock = DockStyle.Fill;
            txtCustom.Location = new Point(10, 7);
            txtCustom.Name = "txtCustom";
            txtCustom.Size = new Size(230, 27);
            txtCustom.TabIndex = 0;
            // 
            // CustomeTextBox
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Window;
            Controls.Add(txtCustom);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DimGray;
            Margin = new Padding(4);
            Name = "CustomeTextBox";
            Padding = new Padding(10, 7, 10, 7);
            Size = new Size(250, 42);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustom;
    }
}
