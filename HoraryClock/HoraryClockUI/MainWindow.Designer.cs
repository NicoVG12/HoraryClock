namespace HoraryClockUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBackground = new Label();
            pnlFlow = new FlowLayoutPanel();
            lblCloseWindow = new Label();
            lblMinimize = new Label();
            pnlMain = new Panel();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblBackground
            // 
            lblBackground.BackColor = Color.Transparent;
            lblBackground.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblBackground.ForeColor = Color.White;
            lblBackground.Image = Properties.Resources.background;
            lblBackground.Location = new Point(0, 0);
            lblBackground.Margin = new Padding(0);
            lblBackground.Name = "lblBackground";
            lblBackground.Padding = new Padding(10);
            lblBackground.Size = new Size(529, 332);
            lblBackground.TabIndex = 1;
            lblBackground.Text = "Horary Clock Tool v2.0";
            lblBackground.MouseDown += lblBackground_MouseDown;
            // 
            // mainPanel
            // 
            pnlFlow.BackColor = Color.Transparent;
            pnlFlow.Location = new Point(2, 38);
            pnlFlow.Margin = new Padding(0);
            pnlFlow.Name = "mainPanel";
            pnlFlow.Size = new Size(525, 292);
            pnlFlow.TabIndex = 2;
            // 
            // lblCloseWindow
            // 
            lblCloseWindow.BackColor = Color.Transparent;
            lblCloseWindow.Image = Properties.Resources.btnClose;
            lblCloseWindow.Location = new Point(498, 2);
            lblCloseWindow.Name = "lblCloseWindow";
            lblCloseWindow.Size = new Size(29, 28);
            lblCloseWindow.TabIndex = 3;
            lblCloseWindow.Click += lblCloseWindow_Click;
            // 
            // lblMinimize
            // 
            lblMinimize.BackColor = Color.Transparent;
            lblMinimize.Image = Properties.Resources.btnMinimize;
            lblMinimize.Location = new Point(471, 2);
            lblMinimize.Name = "lblMinimize";
            lblMinimize.Size = new Size(22, 13);
            lblMinimize.TabIndex = 4;
            lblMinimize.Click += lblMinimize_Click;
            // 
            // panel1
            // 
            pnlMain.BackColor = Color.Transparent;
            pnlMain.BackgroundImage = Properties.Resources.background;
            pnlMain.Controls.Add(lblCloseWindow);
            pnlMain.Controls.Add(lblBackground);
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "panel1";
            pnlMain.Size = new Size(529, 332);
            pnlMain.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(529, 332);
            Controls.Add(lblMinimize);
            Controls.Add(pnlFlow);
            Controls.Add(pnlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblBackground;
        private FlowLayoutPanel pnlFlow;
        private Label lblCloseWindow;
        private Label lblMinimize;
        private Panel pnlMain;
    }
}