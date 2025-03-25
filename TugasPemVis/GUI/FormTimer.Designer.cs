namespace TugasPemVis.GUI
{
    partial class FormTimer
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
            labelTimer = new Label();
            buttonMulai = new Button();
            buttonBerhenti = new Button();
            labelMinutes = new Label();
            label3 = new Label();
            labelSeconds = new Label();
            textBoxMinutes = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTimer.Location = new Point(118, 45);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(125, 50);
            labelTimer.TabIndex = 0;
            labelTimer.Text = "TIMER";
            // 
            // buttonMulai
            // 
            buttonMulai.Location = new Point(118, 300);
            buttonMulai.Name = "buttonMulai";
            buttonMulai.RightToLeft = RightToLeft.No;
            buttonMulai.Size = new Size(190, 50);
            buttonMulai.TabIndex = 1;
            buttonMulai.Text = "MULAI";
            buttonMulai.UseVisualStyleBackColor = true;
            buttonMulai.Click += buttonMulai_Click;
            // 
            // buttonBerhenti
            // 
            buttonBerhenti.Location = new Point(483, 300);
            buttonBerhenti.Name = "buttonBerhenti";
            buttonBerhenti.RightToLeft = RightToLeft.No;
            buttonBerhenti.Size = new Size(190, 50);
            buttonBerhenti.TabIndex = 2;
            buttonBerhenti.Text = "BERHENTI";
            buttonBerhenti.UseVisualStyleBackColor = true;
            buttonBerhenti.Click += buttonBerhenti_Click;
            // 
            // labelMinutes
            // 
            labelMinutes.AutoSize = true;
            labelMinutes.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMinutes.Location = new Point(283, 100);
            labelMinutes.Name = "labelMinutes";
            labelMinutes.Size = new Size(97, 78);
            labelMinutes.TabIndex = 4;
            labelMinutes.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(375, 100);
            label3.Name = "label3";
            label3.Size = new Size(46, 78);
            label3.TabIndex = 6;
            label3.Text = ":";
            // 
            // labelSeconds
            // 
            labelSeconds.AutoSize = true;
            labelSeconds.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSeconds.Location = new Point(427, 100);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(97, 78);
            labelSeconds.TabIndex = 7;
            labelSeconds.Text = "00";
            // 
            // textBoxMinutes
            // 
            textBoxMinutes.ForeColor = SystemColors.ActiveBorder;
            textBoxMinutes.Location = new Point(247, 207);
            textBoxMinutes.Name = "textBoxMinutes";
            textBoxMinutes.PlaceholderText = "Time In Minutes";
            textBoxMinutes.Size = new Size(300, 39);
            textBoxMinutes.TabIndex = 8;
            textBoxMinutes.TextAlign = HorizontalAlignment.Center;
            textBoxMinutes.TextChanged += textBoxMinutes_TextChanged;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormTimer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxMinutes);
            Controls.Add(labelSeconds);
            Controls.Add(label3);
            Controls.Add(labelMinutes);
            Controls.Add(buttonBerhenti);
            Controls.Add(buttonMulai);
            Controls.Add(labelTimer);
            Name = "FormTimer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTimer";
            Load += FormTimer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTimer;
        private Button buttonMulai;
        private Button buttonBerhenti;
        private Label labelMinutes;
        private Label label3;
        private Label labelSeconds;
        private TextBox textBoxMinutes;
        private System.Windows.Forms.Timer timer1;
    }
}