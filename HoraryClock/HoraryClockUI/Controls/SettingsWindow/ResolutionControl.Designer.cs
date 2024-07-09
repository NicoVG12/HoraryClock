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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResolutionControl));
            lblSave = new Label();
            lblWarning = new Label();
            lblSampleDescription = new Label();
            lblSampleResolution = new Label();
            btnSample = new RadioButton();
            pnlMain = new Panel();
            pnlMain.SuspendLayout();
            SuspendLayout();
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
            // lblWarning
            // 
            lblWarning.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblWarning.ForeColor = Color.White;
            lblWarning.Location = new Point(0, 171);
            lblWarning.Margin = new Padding(0);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(326, 38);
            lblWarning.TabIndex = 18;
            lblWarning.Text = "This feature is experimental.\r\nRestart required upon resolution change.";
            lblWarning.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSampleDescription
            // 
            lblSampleDescription.BackColor = Color.White;
            lblSampleDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSampleDescription.ForeColor = Color.Black;
            lblSampleDescription.Location = new Point(7, 16);
            lblSampleDescription.Margin = new Padding(0);
            lblSampleDescription.Name = "lblSampleDescription";
            lblSampleDescription.Size = new Size(313, 31);
            lblSampleDescription.TabIndex = 20;
            lblSampleDescription.Text = "Recommended for 1920x1080 Screen Resolution.";
            lblSampleDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSampleResolution
            // 
            lblSampleResolution.BackColor = Color.Transparent;
            lblSampleResolution.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSampleResolution.ForeColor = Color.White;
            lblSampleResolution.Image = (Image)resources.GetObject("lblSampleResolution.Image");
            lblSampleResolution.Location = new Point(4, 0);
            lblSampleResolution.Margin = new Padding(0);
            lblSampleResolution.Name = "lblSampleResolution";
            lblSampleResolution.Size = new Size(317, 49);
            lblSampleResolution.TabIndex = 19;
            lblSampleResolution.Text = "200x100";
            // 
            // btnSample
            // 
            btnSample.BackColor = Color.White;
            btnSample.Location = new Point(292, 16);
            btnSample.Name = "btnSample";
            btnSample.Size = new Size(28, 31);
            btnSample.TabIndex = 21;
            btnSample.TabStop = true;
            btnSample.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Transparent;
            pnlMain.BackgroundImage = Properties.Resources.keys_settings_control_bg1;
            pnlMain.Controls.Add(btnSample);
            pnlMain.Controls.Add(lblSampleDescription);
            pnlMain.Controls.Add(lblSave);
            pnlMain.Controls.Add(lblWarning);
            pnlMain.Controls.Add(lblSampleResolution);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(326, 257);
            pnlMain.TabIndex = 22;
            // 
            // ResolutionControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(pnlMain);
            Margin = new Padding(0);
            Name = "ResolutionControl";
            Size = new Size(326, 257);
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblSave;
        private Label lblWarning;
        private Label lblSampleDescription;
        private Label lblSampleResolution;
        private RadioButton btnSample;
        private Panel pnlMain;
    }
}
