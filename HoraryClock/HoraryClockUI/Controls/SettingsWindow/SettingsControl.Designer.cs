namespace HoraryClockUI.Controls.SettingsWindow
{
    partial class SettingsControl
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
            lblLanguage = new Label();
            lblPvPOffset = new Label();
            lblKeyBindings = new Label();
            lblOther = new Label();
            pnlSpecificSettings = new FlowLayoutPanel();
            lblGoBack = new Label();
            lblResolution = new Label();
            pnlMain = new Panel();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblLanguage
            // 
            lblLanguage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLanguage.ForeColor = Color.White;
            lblLanguage.Image = Properties.Resources.btnSettingNotSelected;
            lblLanguage.Location = new Point(27, 19);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(127, 27);
            lblLanguage.TabIndex = 0;
            lblLanguage.Text = "Language";
            lblLanguage.TextAlign = ContentAlignment.MiddleCenter;
            lblLanguage.Click += lblLanguage_Click;
            // 
            // lblPvPOffset
            // 
            lblPvPOffset.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPvPOffset.ForeColor = Color.White;
            lblPvPOffset.Image = Properties.Resources.btnSettingNotSelected;
            lblPvPOffset.Location = new Point(27, 50);
            lblPvPOffset.Name = "lblPvPOffset";
            lblPvPOffset.Size = new Size(127, 27);
            lblPvPOffset.TabIndex = 1;
            lblPvPOffset.Text = "Clock";
            lblPvPOffset.TextAlign = ContentAlignment.MiddleCenter;
            lblPvPOffset.Click += lblPvPOffset_Click;
            // 
            // lblKeyBindings
            // 
            lblKeyBindings.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblKeyBindings.ForeColor = Color.White;
            lblKeyBindings.Image = Properties.Resources.btnSettingNotSelected;
            lblKeyBindings.Location = new Point(27, 81);
            lblKeyBindings.Name = "lblKeyBindings";
            lblKeyBindings.Size = new Size(127, 27);
            lblKeyBindings.TabIndex = 2;
            lblKeyBindings.Text = "Key Bindings";
            lblKeyBindings.TextAlign = ContentAlignment.MiddleCenter;
            lblKeyBindings.Click += lblKeyBindings_Click;
            // 
            // lblOther
            // 
            lblOther.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOther.ForeColor = Color.White;
            lblOther.Image = Properties.Resources.btnSettingNotSelected;
            lblOther.Location = new Point(27, 143);
            lblOther.Name = "lblOther";
            lblOther.Size = new Size(127, 27);
            lblOther.TabIndex = 3;
            lblOther.Text = "Other";
            lblOther.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlSpecificSettings
            // 
            pnlSpecificSettings.BackColor = Color.Transparent;
            pnlSpecificSettings.Location = new Point(181, 17);
            pnlSpecificSettings.Margin = new Padding(0);
            pnlSpecificSettings.Name = "pnlSpecificSettings";
            pnlSpecificSettings.Size = new Size(326, 257);
            pnlSpecificSettings.TabIndex = 5;
            // 
            // lblGoBack
            // 
            lblGoBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblGoBack.ForeColor = Color.White;
            lblGoBack.Image = Properties.Resources.btnRectangle;
            lblGoBack.Location = new Point(33, 245);
            lblGoBack.Name = "lblGoBack";
            lblGoBack.Size = new Size(107, 29);
            lblGoBack.TabIndex = 7;
            lblGoBack.Text = "Return";
            lblGoBack.TextAlign = ContentAlignment.MiddleCenter;
            lblGoBack.Click += lblGoBack_Click;
            // 
            // lblResolution
            // 
            lblResolution.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblResolution.ForeColor = Color.White;
            lblResolution.Image = Properties.Resources.btnSettingNotSelected;
            lblResolution.Location = new Point(27, 112);
            lblResolution.Name = "lblResolution";
            lblResolution.Size = new Size(127, 27);
            lblResolution.TabIndex = 8;
            lblResolution.Text = "Resolution";
            lblResolution.TextAlign = ContentAlignment.MiddleCenter;
            lblResolution.Click += lblResolution_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Transparent;
            pnlMain.BackgroundImage = Properties.Resources.background_control_settings;
            pnlMain.Controls.Add(lblResolution);
            pnlMain.Controls.Add(lblLanguage);
            pnlMain.Controls.Add(lblGoBack);
            pnlMain.Controls.Add(lblPvPOffset);
            pnlMain.Controls.Add(pnlSpecificSettings);
            pnlMain.Controls.Add(lblKeyBindings);
            pnlMain.Controls.Add(lblOther);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(525, 292);
            pnlMain.TabIndex = 9;
            // 
            // SettingsControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(pnlMain);
            Margin = new Padding(0);
            Name = "SettingsControl";
            Size = new Size(525, 292);
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblLanguage;
        private Label lblPvPOffset;
        private Label lblKeyBindings;
        private Label lblOther;
        private FlowLayoutPanel pnlSpecificSettings;
        private Label lblGoBack;
        private Label lblResolution;
        private Panel pnlMain;
    }
}
