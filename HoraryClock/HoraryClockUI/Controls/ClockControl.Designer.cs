namespace HoraryClockUI.Controls
{
    partial class ClockControl
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
            lblSettings = new Label();
            SuspendLayout();
            // 
            // lblSettings
            // 
            lblSettings.Image = Properties.Resources.btnSettings;
            lblSettings.Location = new Point(482, 239);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(35, 46);
            lblSettings.TabIndex = 0;
            lblSettings.Click += lblSettings_Click;
            // 
            // ClockControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lblSettings);
            Name = "ClockControl";
            Size = new Size(525, 292);
            ResumeLayout(false);
        }

        #endregion

        private Label lblSettings;
    }
}
