namespace HoraryClockUI.Controls.SettingsWindow
{
    partial class KeyBindingsControl
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
            lblStartKey = new Label();
            lblStartKeyDescription = new Label();
            txtStartKey = new TextBox();
            txtPauseKey = new TextBox();
            lblPauseKeyDescription = new Label();
            lblPauseKey = new Label();
            txtResetKey = new TextBox();
            lblResetKeyDescription = new Label();
            lblResetKey = new Label();
            lblSave = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblStartKey
            // 
            lblStartKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartKey.ForeColor = Color.White;
            lblStartKey.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblStartKey.Location = new Point(4, 0);
            lblStartKey.Margin = new Padding(0);
            lblStartKey.Name = "lblStartKey";
            lblStartKey.Size = new Size(317, 49);
            lblStartKey.TabIndex = 1;
            lblStartKey.Text = "Start Key";
            // 
            // lblStartKeyDescription
            // 
            lblStartKeyDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartKeyDescription.ForeColor = Color.Black;
            lblStartKeyDescription.Location = new Point(7, 16);
            lblStartKeyDescription.Margin = new Padding(0);
            lblStartKeyDescription.Name = "lblStartKeyDescription";
            lblStartKeyDescription.Size = new Size(255, 31);
            lblStartKeyDescription.TabIndex = 5;
            lblStartKeyDescription.Text = "The clock will start when this key is pressed.\r\n(Also pauses the clock when minimized)";
            lblStartKeyDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStartKey
            // 
            txtStartKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStartKey.Location = new Point(264, 17);
            txtStartKey.Name = "txtStartKey";
            txtStartKey.Size = new Size(49, 29);
            txtStartKey.TabIndex = 6;
            txtStartKey.TextAlign = HorizontalAlignment.Center;
            txtStartKey.KeyPress += txtStartKey_KeyPress;
            txtStartKey.KeyUp += txtStartKey_KeyUp;
            // 
            // txtPauseKey
            // 
            txtPauseKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPauseKey.Location = new Point(264, 71);
            txtPauseKey.Name = "txtPauseKey";
            txtPauseKey.Size = new Size(49, 29);
            txtPauseKey.TabIndex = 9;
            txtPauseKey.TextAlign = HorizontalAlignment.Center;
            // 
            // lblPauseKeyDescription
            // 
            lblPauseKeyDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPauseKeyDescription.ForeColor = Color.Black;
            lblPauseKeyDescription.Location = new Point(7, 70);
            lblPauseKeyDescription.Margin = new Padding(0);
            lblPauseKeyDescription.Name = "lblPauseKeyDescription";
            lblPauseKeyDescription.Size = new Size(255, 31);
            lblPauseKeyDescription.TabIndex = 8;
            lblPauseKeyDescription.Text = "The clock will stop when this key is pressed.\r\n(Also starts the clock when minimized)";
            lblPauseKeyDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPauseKey
            // 
            lblPauseKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPauseKey.ForeColor = Color.White;
            lblPauseKey.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblPauseKey.Location = new Point(4, 54);
            lblPauseKey.Margin = new Padding(0);
            lblPauseKey.Name = "lblPauseKey";
            lblPauseKey.Size = new Size(317, 49);
            lblPauseKey.TabIndex = 7;
            lblPauseKey.Text = "Pause Key";
            // 
            // txtResetKey
            // 
            txtResetKey.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtResetKey.Location = new Point(264, 125);
            txtResetKey.Name = "txtResetKey";
            txtResetKey.Size = new Size(49, 29);
            txtResetKey.TabIndex = 12;
            txtResetKey.TextAlign = HorizontalAlignment.Center;
            // 
            // lblResetKeyDescription
            // 
            lblResetKeyDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResetKeyDescription.ForeColor = Color.Black;
            lblResetKeyDescription.Location = new Point(7, 124);
            lblResetKeyDescription.Margin = new Padding(0);
            lblResetKeyDescription.Name = "lblResetKeyDescription";
            lblResetKeyDescription.Size = new Size(255, 31);
            lblResetKeyDescription.TabIndex = 11;
            lblResetKeyDescription.Text = "The clock will be reset when this key is pressed.";
            lblResetKeyDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblResetKey
            // 
            lblResetKey.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblResetKey.ForeColor = Color.White;
            lblResetKey.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblResetKey.Location = new Point(4, 108);
            lblResetKey.Margin = new Padding(0);
            lblResetKey.Name = "lblResetKey";
            lblResetKey.Size = new Size(317, 49);
            lblResetKey.TabIndex = 10;
            lblResetKey.Text = "Reset Key";
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
            lblSave.TabIndex = 15;
            lblSave.Text = "Save";
            lblSave.TextAlign = ContentAlignment.MiddleCenter;
            lblSave.Click += lblSave_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.keys_settings_control_bg1;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(326, 257);
            label1.TabIndex = 14;
            label1.Text = "PvP Offset";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Image = Properties.Resources.keys_settings_label_bg;
            label2.Location = new Point(35, 171);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(255, 38);
            label2.TabIndex = 16;
            label2.Text = "Only F1~F12 Keys are allowed.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KeyBindingsControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(label2);
            Controls.Add(txtResetKey);
            Controls.Add(lblResetKeyDescription);
            Controls.Add(lblResetKey);
            Controls.Add(txtPauseKey);
            Controls.Add(lblPauseKeyDescription);
            Controls.Add(lblPauseKey);
            Controls.Add(txtStartKey);
            Controls.Add(lblStartKeyDescription);
            Controls.Add(lblStartKey);
            Controls.Add(lblSave);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "KeyBindingsControl";
            Size = new Size(326, 257);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStartKey;
        private Label lblStartKeyDescription;
        private TextBox txtStartKey;
        private TextBox txtPauseKey;
        private Label lblPauseKeyDescription;
        private Label lblPauseKey;
        private TextBox txtResetKey;
        private Label lblResetKeyDescription;
        private Label lblResetKey;
        private Label lblSave;
        private Label label1;
        private Label label2;
    }
}
