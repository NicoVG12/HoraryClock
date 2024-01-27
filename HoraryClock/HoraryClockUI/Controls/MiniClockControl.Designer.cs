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
            label2 = new Label();
            lblCurrentEffectIcon = new Label();
            lblRemainingTimeValue = new Label();
            label1 = new Label();
            lblBackground = new Label();
            SuspendLayout();
            // 
            // lblCloseWindow
            // 
            lblCloseWindow.Image = Properties.Resources.btnClose_normal;
            lblCloseWindow.Location = new Point(208, 2);
            lblCloseWindow.Name = "lblCloseWindow";
            lblCloseWindow.Size = new Size(29, 28);
            lblCloseWindow.TabIndex = 4;
            // 
            // lblMaximize
            // 
            lblMaximize.Image = Properties.Resources.btnMaximizeDarkBackground;
            lblMaximize.Location = new Point(202, 47);
            lblMaximize.Name = "lblMaximize";
            lblMaximize.Size = new Size(35, 46);
            lblMaximize.TabIndex = 12;
            lblMaximize.Click += lblMaximize_Click;
            // 
            // label2
            // 
            label2.Image = Properties.Resources.btnClose_normal;
            label2.Location = new Point(157, 71);
            label2.Name = "label2";
            label2.Size = new Size(40, 27);
            label2.TabIndex = 14;
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
            lblRemainingTimeValue.Location = new Point(67, 54);
            lblRemainingTimeValue.Name = "lblRemainingTimeValue";
            lblRemainingTimeValue.Size = new Size(81, 32);
            lblRemainingTimeValue.TabIndex = 16;
            lblRemainingTimeValue.Text = "-";
            lblRemainingTimeValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Image = Properties.Resources.btnClose_normal;
            label1.Location = new Point(157, 41);
            label1.Name = "label1";
            label1.Size = new Size(40, 27);
            label1.TabIndex = 18;
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
            // 
            // MiniClockControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(label1);
            Controls.Add(lblRemainingTimeValue);
            Controls.Add(lblCurrentEffectIcon);
            Controls.Add(label2);
            Controls.Add(lblMaximize);
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
        private Label label2;
        private Label lblCurrentEffectIcon;
        private Label lblRemainingTimeValue;
        private Label label1;
        private Label lblBackground;
    }
}
