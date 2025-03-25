namespace TugasPemVis.GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            pilihMenu = new ToolStripMenuItem();
            subMenuStopWatch = new ToolStripMenuItem();
            subMenuTimer = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(32, 32);
            menuStrip.Items.AddRange(new ToolStripItem[] { pilihMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(13, 5, 0, 5);
            menuStrip.Size = new Size(1369, 48);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // pilihMenu
            // 
            pilihMenu.DropDownItems.AddRange(new ToolStripItem[] { subMenuStopWatch, subMenuTimer });
            pilihMenu.Name = "pilihMenu";
            pilihMenu.Size = new Size(149, 38);
            pilihMenu.Text = "Pilih Menu";
            pilihMenu.Click += pilihMenu_Click;
            // 
            // subMenuStopWatch
            // 
            subMenuStopWatch.Name = "subMenuStopWatch";
            subMenuStopWatch.Size = new Size(359, 44);
            subMenuStopWatch.Text = "Stop Watch";
            subMenuStopWatch.Click += subMenuStopWatch_Click;
            // 
            // subMenuTimer
            // 
            subMenuTimer.Name = "subMenuTimer";
            subMenuTimer.Size = new Size(359, 44);
            subMenuTimer.Text = "Timer";
            subMenuTimer.Click += subMenuTimer_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(32, 32);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 1073);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 30, 0);
            statusStrip.Size = new Size(1369, 42);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(78, 32);
            toolStripStatusLabel.Text = "Status";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 1115);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(6, 7, 6, 7);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        public ToolStripMenuItem pilihMenu;
        private ToolStripMenuItem subMenuStopWatch;
        private ToolStripMenuItem subMenuTimer;
    }
}



