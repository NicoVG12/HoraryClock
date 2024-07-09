namespace HoraryClockUI.Controls
{
    partial class ClockControl
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
            lblSettings = new Label();
            lblStart = new Label();
            lblPause = new Label();
            lblReset = new Label();
            lblRemainingTime = new Label();
            lblRemainingTimeValue = new Label();
            lblCurrentEffect = new Label();
            lblCurrentEffectIcon = new Label();
            lblFirstDescription = new Label();
            lblSecondDescription = new Label();
            pnlMain = new Panel();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblSettings
            // 
            lblSettings.BackColor = Color.Transparent;
            lblSettings.Image = Properties.Resources.btnConfig;
            lblSettings.Location = new Point(469, 13);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(35, 46);
            lblSettings.TabIndex = 0;
            lblSettings.Click += lblSettings_Click;
            // 
            // lblStart
            // 
            lblStart.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStart.ForeColor = Color.White;
            lblStart.Image = Properties.Resources.btnRectangle;
            lblStart.Location = new Point(19, 240);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(146, 40);
            lblStart.TabIndex = 1;
            lblStart.Text = "Start";
            lblStart.TextAlign = ContentAlignment.MiddleCenter;
            lblStart.Click += lblStart_Click;
            // 
            // lblPause
            // 
            lblPause.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPause.ForeColor = Color.White;
            lblPause.Image = Properties.Resources.btnRectangle;
            lblPause.Location = new Point(190, 240);
            lblPause.Name = "lblPause";
            lblPause.Size = new Size(146, 40);
            lblPause.TabIndex = 2;
            lblPause.Text = "Pause";
            lblPause.TextAlign = ContentAlignment.MiddleCenter;
            lblPause.Click += lblPause_Click;
            // 
            // lblReset
            // 
            lblReset.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblReset.ForeColor = Color.White;
            lblReset.Image = Properties.Resources.btnRectangle;
            lblReset.Location = new Point(361, 240);
            lblReset.Name = "lblReset";
            lblReset.Size = new Size(146, 40);
            lblReset.TabIndex = 3;
            lblReset.Text = "Reset";
            lblReset.TextAlign = ContentAlignment.MiddleCenter;
            lblReset.Click += lblReset_Click;
            // 
            // lblRemainingTime
            // 
            lblRemainingTime.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRemainingTime.ForeColor = Color.White;
            lblRemainingTime.Location = new Point(22, 194);
            lblRemainingTime.Name = "lblRemainingTime";
            lblRemainingTime.Size = new Size(218, 32);
            lblRemainingTime.TabIndex = 4;
            lblRemainingTime.Text = "Remaining Time: ";
            lblRemainingTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRemainingTimeValue
            // 
            lblRemainingTimeValue.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRemainingTimeValue.ForeColor = Color.White;
            lblRemainingTimeValue.Location = new Point(255, 194);
            lblRemainingTimeValue.Name = "lblRemainingTimeValue";
            lblRemainingTimeValue.Size = new Size(240, 32);
            lblRemainingTimeValue.TabIndex = 5;
            lblRemainingTimeValue.Text = "-";
            lblRemainingTimeValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurrentEffect
            // 
            lblCurrentEffect.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentEffect.ForeColor = Color.White;
            lblCurrentEffect.Location = new Point(39, 17);
            lblCurrentEffect.Name = "lblCurrentEffect";
            lblCurrentEffect.Size = new Size(448, 30);
            lblCurrentEffect.TabIndex = 6;
            lblCurrentEffect.Text = "Current Effect";
            lblCurrentEffect.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentEffectIcon
            // 
            lblCurrentEffectIcon.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentEffectIcon.ForeColor = Color.Black;
            lblCurrentEffectIcon.Image = Properties.Resources._04noeffect;
            lblCurrentEffectIcon.Location = new Point(240, 56);
            lblCurrentEffectIcon.Name = "lblCurrentEffectIcon";
            lblCurrentEffectIcon.Size = new Size(45, 45);
            lblCurrentEffectIcon.TabIndex = 7;
            lblCurrentEffectIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFirstDescription
            // 
            lblFirstDescription.BackColor = Color.Transparent;
            lblFirstDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstDescription.ForeColor = Color.White;
            lblFirstDescription.Location = new Point(39, 101);
            lblFirstDescription.Name = "lblFirstDescription";
            lblFirstDescription.Size = new Size(448, 40);
            lblFirstDescription.TabIndex = 8;
            lblFirstDescription.Text = "First Effect Line";
            lblFirstDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSecondDescription
            // 
            lblSecondDescription.BackColor = Color.Transparent;
            lblSecondDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecondDescription.ForeColor = Color.White;
            lblSecondDescription.Location = new Point(39, 131);
            lblSecondDescription.Name = "lblSecondDescription";
            lblSecondDescription.Size = new Size(448, 40);
            lblSecondDescription.TabIndex = 9;
            lblSecondDescription.Text = "Second Effect Line";
            lblSecondDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            pnlMain.BackgroundImage = Properties.Resources.background_control_clock;
            pnlMain.Controls.Add(lblSettings);
            pnlMain.Controls.Add(lblStart);
            pnlMain.Controls.Add(lblCurrentEffectIcon);
            pnlMain.Controls.Add(lblPause);
            pnlMain.Controls.Add(lblFirstDescription);
            pnlMain.Controls.Add(lblReset);
            pnlMain.Controls.Add(lblSecondDescription);
            pnlMain.Controls.Add(lblRemainingTime);
            pnlMain.Controls.Add(lblCurrentEffect);
            pnlMain.Controls.Add(lblRemainingTimeValue);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(525, 292);
            pnlMain.TabIndex = 11;
            // 
            // ClockControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Transparent;
            Controls.Add(pnlMain);
            Margin = new Padding(0);
            Name = "ClockControl";
            Size = new Size(525, 292);
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblSettings;
        private Label lblStart;
        private Label lblPause;
        private Label lblReset;
        private Label lblRemainingTime;
        private Label lblRemainingTimeValue;
        private Label lblCurrentEffect;
        private Label lblCurrentEffectIcon;
        private Label lblFirstDescription;
        private Label lblSecondDescription;
        private Panel pnlMain;
    }
}
