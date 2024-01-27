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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            lblLanguage = new Label();
            lblPvPOffset = new Label();
            lblKeyBindings = new Label();
            lblOther = new Label();
            lblBackground = new Label();
            pnlSpecificSettings = new FlowLayoutPanel();
            label1 = new Label();
            lblGoBack = new Label();
            SuspendLayout();
            // 
            // lblLanguage
            // 
            lblLanguage.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLanguage.ForeColor = Color.White;
            lblLanguage.Image = Properties.Resources.btnSettingNotSelected;
            lblLanguage.Location = new Point(22, 80);
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
            lblPvPOffset.Location = new Point(22, 111);
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
            lblKeyBindings.Location = new Point(22, 142);
            lblKeyBindings.Name = "lblKeyBindings";
            lblKeyBindings.Size = new Size(127, 27);
            lblKeyBindings.TabIndex = 2;
            lblKeyBindings.Text = "Key Bindings";
            lblKeyBindings.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOther
            // 
            lblOther.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOther.ForeColor = Color.White;
            lblOther.Image = Properties.Resources.btnSettingNotSelected;
            lblOther.Location = new Point(22, 173);
            lblOther.Name = "lblOther";
            lblOther.Size = new Size(127, 27);
            lblOther.TabIndex = 3;
            lblOther.Text = "Other";
            lblOther.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBackground
            // 
            lblBackground.Image = (Image)resources.GetObject("lblBackground.Image");
            lblBackground.Location = new Point(0, 0);
            lblBackground.Margin = new Padding(0);
            lblBackground.Name = "lblBackground";
            lblBackground.Size = new Size(525, 292);
            lblBackground.TabIndex = 4;
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
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(22, 17);
            label1.Name = "label1";
            label1.Size = new Size(127, 34);
            label1.TabIndex = 6;
            label1.Text = "Settings";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGoBack
            // 
            lblGoBack.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblGoBack.ForeColor = Color.MidnightBlue;
            lblGoBack.Image = Properties.Resources.btnGoBack;
            lblGoBack.Location = new Point(0, 0);
            lblGoBack.Name = "lblGoBack";
            lblGoBack.Size = new Size(27, 27);
            lblGoBack.TabIndex = 7;
            lblGoBack.TextAlign = ContentAlignment.MiddleCenter;
            lblGoBack.Click += lblGoBack_Click;
            // 
            // SettingsControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lblGoBack);
            Controls.Add(label1);
            Controls.Add(pnlSpecificSettings);
            Controls.Add(lblOther);
            Controls.Add(lblKeyBindings);
            Controls.Add(lblPvPOffset);
            Controls.Add(lblLanguage);
            Controls.Add(lblBackground);
            Margin = new Padding(0);
            Name = "SettingsControl";
            Size = new Size(525, 292);
            ResumeLayout(false);
        }

        #endregion

        private Label lblLanguage;
        private Label lblPvPOffset;
        private Label lblKeyBindings;
        private Label lblOther;
        private Label lblBackground;
        private FlowLayoutPanel pnlSpecificSettings;
        private Label label1;
        private Label lblGoBack;
    }
}
