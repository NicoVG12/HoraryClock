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
            groupBox1 = new GroupBox();
            btnSpanish = new RadioButton();
            lblBackground = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEnglish
            // 
            btnEnglish.AutoSize = true;
            btnEnglish.BackColor = Color.Silver;
            btnEnglish.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnglish.Location = new Point(28, 22);
            btnEnglish.Name = "btnEnglish";
            btnEnglish.Size = new Size(84, 25);
            btnEnglish.TabIndex = 0;
            btnEnglish.TabStop = true;
            btnEnglish.Text = "English";
            btnEnglish.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSpanish);
            groupBox1.Controls.Add(btnEnglish);
            groupBox1.Controls.Add(lblBackground);
            groupBox1.Location = new Point(-15, -15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 319);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSpanish
            // 
            btnSpanish.AutoSize = true;
            btnSpanish.BackColor = Color.Silver;
            btnSpanish.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSpanish.Location = new Point(28, 53);
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
            Controls.Add(groupBox1);
            Name = "LanguageControl";
            Size = new Size(326, 257);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton btnEnglish;
        private GroupBox groupBox1;
        private RadioButton btnSpanish;
        private Label lblBackground;
    }
}
