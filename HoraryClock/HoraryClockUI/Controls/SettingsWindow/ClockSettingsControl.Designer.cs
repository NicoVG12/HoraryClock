namespace HoraryClockUI.Controls.SettingsWindow
{
    partial class ClockSettingsControl
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
            lblPvPOffsetTitle = new Label();
            lblStartClockOnReset = new Label();
            lblOpacity = new Label();
            lblAlwaysOnTop = new Label();
            lblOffsetDescription = new Label();
            lblStartClockOnResetDescription = new Label();
            lblOpacityDescription = new Label();
            lblAlwaysOnTopDescription = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPvPOffsetTitle
            // 
            lblPvPOffsetTitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPvPOffsetTitle.ForeColor = Color.White;
            lblPvPOffsetTitle.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblPvPOffsetTitle.Location = new Point(4, 0);
            lblPvPOffsetTitle.Margin = new Padding(0);
            lblPvPOffsetTitle.Name = "lblPvPOffsetTitle";
            lblPvPOffsetTitle.Size = new Size(317, 49);
            lblPvPOffsetTitle.TabIndex = 0;
            lblPvPOffsetTitle.Text = "PvP Offset";
            // 
            // lblStartClockOnReset
            // 
            lblStartClockOnReset.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartClockOnReset.ForeColor = Color.White;
            lblStartClockOnReset.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblStartClockOnReset.Location = new Point(4, 54);
            lblStartClockOnReset.Margin = new Padding(0);
            lblStartClockOnReset.Name = "lblStartClockOnReset";
            lblStartClockOnReset.Size = new Size(317, 49);
            lblStartClockOnReset.TabIndex = 1;
            lblStartClockOnReset.Text = "Start Clock on Reset";
            // 
            // lblOpacity
            // 
            lblOpacity.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpacity.ForeColor = Color.White;
            lblOpacity.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblOpacity.Location = new Point(4, 108);
            lblOpacity.Margin = new Padding(0);
            lblOpacity.Name = "lblOpacity";
            lblOpacity.Size = new Size(317, 49);
            lblOpacity.TabIndex = 2;
            lblOpacity.Text = "Window Opacity";
            // 
            // lblAlwaysOnTop
            // 
            lblAlwaysOnTop.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlwaysOnTop.ForeColor = Color.White;
            lblAlwaysOnTop.Image = Properties.Resources.setting_specific_opaque_bg_new2;
            lblAlwaysOnTop.Location = new Point(4, 162);
            lblAlwaysOnTop.Margin = new Padding(0);
            lblAlwaysOnTop.Name = "lblAlwaysOnTop";
            lblAlwaysOnTop.Size = new Size(317, 49);
            lblAlwaysOnTop.TabIndex = 3;
            lblAlwaysOnTop.Text = "Window Always on Top";
            // 
            // lblOffsetDescription
            // 
            lblOffsetDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOffsetDescription.ForeColor = Color.Black;
            lblOffsetDescription.Location = new Point(7, 16);
            lblOffsetDescription.Margin = new Padding(0);
            lblOffsetDescription.Name = "lblOffsetDescription";
            lblOffsetDescription.Size = new Size(255, 31);
            lblOffsetDescription.TabIndex = 4;
            lblOffsetDescription.Text = "Adds a 3 second offset to the clock. \r\n(The clock will start on 17s)";
            lblOffsetDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStartClockOnResetDescription
            // 
            lblStartClockOnResetDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartClockOnResetDescription.ForeColor = Color.Black;
            lblStartClockOnResetDescription.Location = new Point(7, 70);
            lblStartClockOnResetDescription.Margin = new Padding(0);
            lblStartClockOnResetDescription.Name = "lblStartClockOnResetDescription";
            lblStartClockOnResetDescription.Size = new Size(255, 31);
            lblStartClockOnResetDescription.TabIndex = 5;
            lblStartClockOnResetDescription.Text = "Automatically start the clock upon reset.";
            lblStartClockOnResetDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOpacityDescription
            // 
            lblOpacityDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpacityDescription.ForeColor = Color.Black;
            lblOpacityDescription.Location = new Point(7, 124);
            lblOpacityDescription.Margin = new Padding(0);
            lblOpacityDescription.Name = "lblOpacityDescription";
            lblOpacityDescription.Size = new Size(255, 31);
            lblOpacityDescription.TabIndex = 6;
            lblOpacityDescription.Text = "Set the window opacity.";
            lblOpacityDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAlwaysOnTopDescription
            // 
            lblAlwaysOnTopDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlwaysOnTopDescription.ForeColor = Color.Black;
            lblAlwaysOnTopDescription.Location = new Point(7, 178);
            lblAlwaysOnTopDescription.Margin = new Padding(0);
            lblAlwaysOnTopDescription.Name = "lblAlwaysOnTopDescription";
            lblAlwaysOnTopDescription.Size = new Size(255, 31);
            lblAlwaysOnTopDescription.TabIndex = 7;
            lblAlwaysOnTopDescription.Text = "The window will always stay on top.";
            lblAlwaysOnTopDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.settings_control_bg1;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(326, 257);
            label1.TabIndex = 8;
            label1.Text = "PvP Offset";
            // 
            // ClockSettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAlwaysOnTopDescription);
            Controls.Add(lblOpacityDescription);
            Controls.Add(lblStartClockOnResetDescription);
            Controls.Add(lblOffsetDescription);
            Controls.Add(lblAlwaysOnTop);
            Controls.Add(lblOpacity);
            Controls.Add(lblStartClockOnReset);
            Controls.Add(lblPvPOffsetTitle);
            Controls.Add(label1);
            Name = "ClockSettingsControl";
            Size = new Size(326, 257);
            ResumeLayout(false);
        }

        #endregion

        private Label lblPvPOffsetTitle;
        private Label lblStartClockOnReset;
        private Label lblOpacity;
        private Label lblAlwaysOnTop;
        private Label lblOffsetDescription;
        private Label lblStartClockOnResetDescription;
        private Label lblOpacityDescription;
        private Label lblAlwaysOnTopDescription;
        private Label label1;
    }
}
