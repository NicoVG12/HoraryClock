namespace HoraryClockUI.Controls.SettingsWindow
{
    partial class LanguageControl
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
            grpLanguages = new GroupBox();
            lblBackground = new Label();
            grpLanguages.SuspendLayout();
            SuspendLayout();
            // 
            // grpLanguages
            // 
            grpLanguages.Controls.Add(lblBackground);
            grpLanguages.Location = new Point(-15, -15);
            grpLanguages.Margin = new Padding(0);
            grpLanguages.Name = "grpLanguages";
            grpLanguages.Padding = new Padding(0);
            grpLanguages.Size = new Size(411, 319);
            grpLanguages.TabIndex = 1;
            grpLanguages.TabStop = false;
            grpLanguages.Enter += groupBox1_Enter;
            // 
            // lblBackground
            // 
            lblBackground.Image = Properties.Resources.settings_control_bg;
            lblBackground.Location = new Point(15, 15);
            lblBackground.Margin = new Padding(0);
            lblBackground.Name = "lblBackground";
            lblBackground.Size = new Size(326, 257);
            lblBackground.TabIndex = 1;
            // 
            // LanguageControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(grpLanguages);
            Margin = new Padding(0);
            Name = "LanguageControl";
            Size = new Size(326, 257);
            grpLanguages.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpLanguages;
        private Label lblBackground;
    }
}
