namespace HoraryClockUI.Controls.SettingsWindow
{
    partial class ResolutionControl
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
            lblBackground = new Label();
            lblSave = new Label();
            lblLanguageSampleMessage = new Label();
            lblSampleDescription = new Label();
            lblSampleResolution = new Label();
            btnSample = new RadioButton();
            SuspendLayout();
            // 
            // lblBackground
            // 
            lblBackground.Image = Properties.Resources.keys_settings_control_bg1;
            lblBackground.Location = new Point(0, 0);
            lblBackground.Margin = new Padding(0);
            lblBackground.Name = "lblBackground";
            lblBackground.Size = new Size(326, 257);
            lblBackground.TabIndex = 1;
            lblBackground.Click += lblBackground_Click;
            // 
            // lblSave
            // 
            lblSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSave.ForeColor = Color.White;
            lblSave.Image = Properties.Resources.btnSave;
            lblSave.Location = new Point(112, 224);
            lblSave.Margin = new Padding(0);
            lblSave.Name = "lblSave";
            lblSave.Size = new Size(103, 27);
            lblSave.TabIndex = 16;
            lblSave.Text = "Save";
            lblSave.TextAlign = ContentAlignment.MiddleCenter;
            lblSave.Click += lblSave_Click;
            // 
            // lblLanguageSampleMessage
            // 
            lblLanguageSampleMessage.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLanguageSampleMessage.ForeColor = Color.White;
            lblLanguageSampleMessage.Image = Properties.Resources.keys_settings_label_bg;
            lblLanguageSampleMessage.Location = new Point(35, 171);
            lblLanguageSampleMessage.Margin = new Padding(0);
            lblLanguageSampleMessage.Name = "lblLanguageSampleMessage";
            lblLanguageSampleMessage.Size = new Size(255, 38);
            lblLanguageSampleMessage.TabIndex = 18;
            lblLanguageSampleMessage.Text = "This feature is experimental.";
            lblLanguageSampleMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSampleDescription
            // 
            lblSampleDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSampleDescription.ForeColor = Color.Black;
            lblSampleDescription.Location = new Point(7, 16);
            lblSampleDescription.Margin = new Padding(0);
            lblSampleDescription.Name = "lblSampleDescription";
            lblSampleDescription.Size = new Size(300, 31);
            lblSampleDescription.TabIndex = 20;
            lblSampleDescription.Text = "Recommended for 1920x1080 Screen Resolution.";
            lblSampleDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSampleResolution
            // 
            lblSampleResolution.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSampleResolution.ForeColor = Color.White;
            lblSampleResolution.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblSampleResolution.Location = new Point(4, 0);
            lblSampleResolution.Margin = new Padding(0);
            lblSampleResolution.Name = "lblSampleResolution";
            lblSampleResolution.Size = new Size(317, 49);
            lblSampleResolution.TabIndex = 19;
            lblSampleResolution.Text = "200x100";
            // 
            // btnSample
            // 
            btnSample.Location = new Point(292, 16);
            btnSample.Name = "btnSample";
            btnSample.Size = new Size(28, 31);
            btnSample.TabIndex = 21;
            btnSample.TabStop = true;
            btnSample.UseVisualStyleBackColor = true;
            // 
            // ResolutionControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(btnSample);
            Controls.Add(lblSampleDescription);
            Controls.Add(lblSampleResolution);
            Controls.Add(lblLanguageSampleMessage);
            Controls.Add(lblSave);
            Controls.Add(lblBackground);
            Margin = new Padding(0);
            Name = "ResolutionControl";
            Size = new Size(326, 257);
            ResumeLayout(false);
        }

        #endregion

        private Label lblBackground;
        private Label lblSave;
        private Label lblLanguageSampleMessage;
        private Label lblSampleDescription;
        private Label lblSampleResolution;
        private RadioButton btnSample;
    }
}
