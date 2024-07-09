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
            chkOffset = new CheckBox();
            chkStartClockOnReset = new CheckBox();
            chkAlwaysOnTop = new CheckBox();
            lblSave = new Label();
            trkOpacity = new TrackBar();
            lblOpacityProgress = new Label();
            ((System.ComponentModel.ISupportInitialize)trkOpacity).BeginInit();
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
            lblOpacity.Text = "Window's Opacity";
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
            lblOffsetDescription.BackColor = Color.White;
            lblOffsetDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOffsetDescription.ForeColor = Color.Black;
            lblOffsetDescription.Location = new Point(7, 16);
            lblOffsetDescription.Margin = new Padding(0);
            lblOffsetDescription.Name = "lblOffsetDescription";
            lblOffsetDescription.Size = new Size(312, 31);
            lblOffsetDescription.TabIndex = 4;
            lblOffsetDescription.Text = "Adds a 3 second offset to the clock. \r\n(The clock will start on 17s)";
            lblOffsetDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStartClockOnResetDescription
            // 
            lblStartClockOnResetDescription.BackColor = Color.White;
            lblStartClockOnResetDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStartClockOnResetDescription.ForeColor = Color.Black;
            lblStartClockOnResetDescription.Location = new Point(7, 70);
            lblStartClockOnResetDescription.Margin = new Padding(0);
            lblStartClockOnResetDescription.Name = "lblStartClockOnResetDescription";
            lblStartClockOnResetDescription.Size = new Size(312, 31);
            lblStartClockOnResetDescription.TabIndex = 5;
            lblStartClockOnResetDescription.Text = "Automatically start the clock upon reset.";
            lblStartClockOnResetDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOpacityDescription
            // 
            lblOpacityDescription.BackColor = Color.White;
            lblOpacityDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpacityDescription.ForeColor = Color.Black;
            lblOpacityDescription.Location = new Point(7, 124);
            lblOpacityDescription.Margin = new Padding(0);
            lblOpacityDescription.Name = "lblOpacityDescription";
            lblOpacityDescription.Size = new Size(312, 31);
            lblOpacityDescription.TabIndex = 6;
            lblOpacityDescription.Text = "Set the window's opacity.\r\n(10%~100%)";
            lblOpacityDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAlwaysOnTopDescription
            // 
            lblAlwaysOnTopDescription.BackColor = Color.White;
            lblAlwaysOnTopDescription.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlwaysOnTopDescription.ForeColor = Color.Black;
            lblAlwaysOnTopDescription.Location = new Point(7, 178);
            lblAlwaysOnTopDescription.Margin = new Padding(0);
            lblAlwaysOnTopDescription.Name = "lblAlwaysOnTopDescription";
            lblAlwaysOnTopDescription.Size = new Size(312, 31);
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
            // chkOffset
            // 
            chkOffset.BackColor = Color.White;
            chkOffset.Location = new Point(291, 16);
            chkOffset.Name = "chkOffset";
            chkOffset.Size = new Size(28, 31);
            chkOffset.TabIndex = 9;
            chkOffset.UseVisualStyleBackColor = false;
            // 
            // chkStartClockOnReset
            // 
            chkStartClockOnReset.BackColor = Color.White;
            chkStartClockOnReset.Location = new Point(291, 70);
            chkStartClockOnReset.Name = "chkStartClockOnReset";
            chkStartClockOnReset.Size = new Size(28, 31);
            chkStartClockOnReset.TabIndex = 10;
            chkStartClockOnReset.UseVisualStyleBackColor = false;
            // 
            // chkAlwaysOnTop
            // 
            chkAlwaysOnTop.BackColor = Color.White;
            chkAlwaysOnTop.Location = new Point(291, 178);
            chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            chkAlwaysOnTop.Size = new Size(28, 31);
            chkAlwaysOnTop.TabIndex = 12;
            chkAlwaysOnTop.UseVisualStyleBackColor = false;
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
            lblSave.TabIndex = 13;
            lblSave.Text = "Save";
            lblSave.TextAlign = ContentAlignment.MiddleCenter;
            lblSave.Click += lblSave_Click;
            // 
            // trkOpacity
            // 
            trkOpacity.AutoSize = false;
            trkOpacity.BackColor = Color.White;
            trkOpacity.Location = new Point(215, 124);
            trkOpacity.Maximum = 9;
            trkOpacity.Name = "trkOpacity";
            trkOpacity.Size = new Size(104, 31);
            trkOpacity.TabIndex = 14;
            trkOpacity.Scroll += trkOpacity_Scroll;
            // 
            // lblOpacityProgress
            // 
            lblOpacityProgress.BackColor = Color.White;
            lblOpacityProgress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpacityProgress.ForeColor = Color.Black;
            lblOpacityProgress.Location = new Point(153, 124);
            lblOpacityProgress.Margin = new Padding(0);
            lblOpacityProgress.Name = "lblOpacityProgress";
            lblOpacityProgress.Size = new Size(62, 31);
            lblOpacityProgress.TabIndex = 15;
            lblOpacityProgress.Text = "100%";
            lblOpacityProgress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ClockSettingsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblOpacityProgress);
            Controls.Add(trkOpacity);
            Controls.Add(lblSave);
            Controls.Add(chkAlwaysOnTop);
            Controls.Add(chkStartClockOnReset);
            Controls.Add(chkOffset);
            Controls.Add(lblAlwaysOnTopDescription);
            Controls.Add(lblOpacityDescription);
            Controls.Add(lblStartClockOnResetDescription);
            Controls.Add(lblOffsetDescription);
            Controls.Add(lblAlwaysOnTop);
            Controls.Add(lblOpacity);
            Controls.Add(lblStartClockOnReset);
            Controls.Add(lblPvPOffsetTitle);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "ClockSettingsControl";
            Size = new Size(326, 257);
            ((System.ComponentModel.ISupportInitialize)trkOpacity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSave;
        private Label lblPvPOffsetTitle;
        private Label lblStartClockOnReset;
        private Label lblOpacity;
        private Label lblAlwaysOnTop;
        private Label lblOffsetDescription;
        private Label lblStartClockOnResetDescription;
        private Label lblOpacityDescription;
        private Label lblAlwaysOnTopDescription;
        private Label label1;
        private CheckBox chkOffset;
        private CheckBox chkStartClockOnReset;
        private CheckBox chkAlwaysOnTop;
        private TrackBar trkOpacity;
        private Label lblOpacityProgress;
    }
}
