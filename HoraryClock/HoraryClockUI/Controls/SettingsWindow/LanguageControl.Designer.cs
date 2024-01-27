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
            btnEnglish = new RadioButton();
            grpLanguages = new GroupBox();
            btnSpanish = new RadioButton();
            lblBackground = new Label();
            grpLanguages.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnglish
            // 
            btnEnglish.AutoSize = true;
            btnEnglish.BackColor = Color.Silver;
            btnEnglish.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnglish.Location = new Point(25, 19);
            btnEnglish.Name = "btnEnglish";
            btnEnglish.Size = new Size(84, 25);
            btnEnglish.TabIndex = 0;
            btnEnglish.TabStop = true;
            btnEnglish.Text = "English";
            btnEnglish.UseVisualStyleBackColor = false;
            // 
            // grpLanguages
            // 
            grpLanguages.Controls.Add(btnSpanish);
            grpLanguages.Controls.Add(btnEnglish);
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
            // btnSpanish
            // 
            btnSpanish.AutoSize = true;
            btnSpanish.BackColor = Color.Silver;
            btnSpanish.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSpanish.Location = new Point(25, 50);
            btnSpanish.Name = "btnSpanish";
            btnSpanish.Size = new Size(88, 25);
            btnSpanish.TabIndex = 2;
            btnSpanish.TabStop = true;
            btnSpanish.Text = "Español";
            btnSpanish.UseVisualStyleBackColor = false;
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
            grpLanguages.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton btnEnglish;
        private GroupBox grpLanguages;
        private RadioButton btnSpanish;
        private Label lblBackground;
    }
}
