namespace HoraryClockUI.Controls
{
    partial class MiniClockControl
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
            lblCloseWindow = new Label();
            lblMaximize = new Label();
            lblReset = new Label();
            lblCurrentEffectIcon = new Label();
            lblRemainingTimeValue = new Label();
            lblPlay = new Label();
            lblBackground = new Label();
            SuspendLayout();
            // 
            // lblCloseWindow
            // 
            lblCloseWindow.Image = Properties.Resources.btnMiniClose;
            lblCloseWindow.Location = new Point(208, 2);
            lblCloseWindow.Name = "lblCloseWindow";
            lblCloseWindow.Size = new Size(29, 28);
            lblCloseWindow.TabIndex = 4;
            lblCloseWindow.Click += lblCloseWindow_Click;
            // 
            // lblMaximize
            // 
            lblMaximize.Image = Properties.Resources.btnMaximize;
            lblMaximize.Location = new Point(182, 2);
            lblMaximize.Name = "lblMaximize";
            lblMaximize.Size = new Size(22, 13);
            lblMaximize.TabIndex = 12;
            lblMaximize.Click += lblMaximize_Click;
            // 
            // lblReset
            // 
            lblReset.Image = Properties.Resources.miniReset;
            lblReset.Location = new Point(197, 53);
            lblReset.Name = "lblReset";
            lblReset.Size = new Size(36, 35);
            lblReset.TabIndex = 14;
            // 
            // lblCurrentEffectIcon
            // 
            lblCurrentEffectIcon.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentEffectIcon.ForeColor = Color.Black;
            lblCurrentEffectIcon.Image = Properties.Resources._04noeffect;
            lblCurrentEffectIcon.Location = new Point(12, 48);
            lblCurrentEffectIcon.Name = "lblCurrentEffectIcon";
            lblCurrentEffectIcon.Size = new Size(45, 45);
            lblCurrentEffectIcon.TabIndex = 15;
            lblCurrentEffectIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRemainingTimeValue
            // 
            lblRemainingTimeValue.Font = new Font("Consolas", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblRemainingTimeValue.ForeColor = Color.Black;
            lblRemainingTimeValue.Location = new Point(59, 54);
            lblRemainingTimeValue.Name = "lblRemainingTimeValue";
            lblRemainingTimeValue.Size = new Size(95, 32);
            lblRemainingTimeValue.TabIndex = 16;
            lblRemainingTimeValue.Text = "-";
            lblRemainingTimeValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPlay
            // 
            lblPlay.Image = Properties.Resources.miniPlay;
            lblPlay.Location = new Point(155, 53);
            lblPlay.Name = "lblPlay";
            lblPlay.Size = new Size(36, 35);
            lblPlay.TabIndex = 18;
            lblPlay.Click += label1_Click;
            // 
            // lblBackground
            // 
            lblBackground.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBackground.ForeColor = Color.White;
            lblBackground.Image = Properties.Resources.MiniClockwindow;
            lblBackground.Location = new Point(0, 0);
            lblBackground.Margin = new Padding(0);
            lblBackground.Name = "lblBackground";
            lblBackground.Padding = new Padding(10);
            lblBackground.Size = new Size(239, 104);
            lblBackground.TabIndex = 19;
            lblBackground.Text = "Horary Clock Tool v2.0";
            lblBackground.Click += lblBackground_Click;
            lblBackground.MouseDown += lblBackground_MouseDown;
            // 
            // MiniClockControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lblCurrentEffectIcon);
            Controls.Add(lblMaximize);
            Controls.Add(lblPlay);
            Controls.Add(lblRemainingTimeValue);
            Controls.Add(lblReset);
            Controls.Add(lblCloseWindow);
            Controls.Add(lblBackground);
            Margin = new Padding(0);
            Name = "MiniClockControl";
            Size = new Size(239, 104);
            ResumeLayout(false);
        }

        #endregion

        private Label lblCloseWindow;
        private Label lblMaximize;
        private Label lblReset;
        private Label lblCurrentEffectIcon;
        private Label lblRemainingTimeValue;
        private Label lblPlay;
        private Label lblBackground;
    }
}
