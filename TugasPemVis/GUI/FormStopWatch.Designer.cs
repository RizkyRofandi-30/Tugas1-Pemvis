namespace TugasPemVis.GUI
{
    partial class FormStopWatch
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
            label1 = new Label();
            buttonMulai = new Button();
            buttonBerhenti = new Button();
            labelMinutes = new Label();
            labelSeconds = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 57);
            label1.Name = "label1";
            label1.Size = new Size(167, 37);
            label1.TabIndex = 0;
            label1.Text = "STOPWATCH";
            // 
            // buttonMulai
            // 
            buttonMulai.Location = new Point(130, 293);
            buttonMulai.Name = "buttonMulai";
            buttonMulai.Size = new Size(170, 60);
            buttonMulai.TabIndex = 1;
            buttonMulai.Text = "Mulai";
            buttonMulai.UseVisualStyleBackColor = true;
            buttonMulai.Click += buttonMulai_Click;
            // 
            // buttonBerhenti
            // 
            buttonBerhenti.Location = new Point(520, 293);
            buttonBerhenti.Name = "buttonBerhenti";
            buttonBerhenti.Size = new Size(170, 60);
            buttonBerhenti.TabIndex = 2;
            buttonBerhenti.Text = "Berhenti";
            buttonBerhenti.UseVisualStyleBackColor = true;
            buttonBerhenti.Click += buttonBerhenti_Click;
            // 
            // labelMinutes
            // 
            labelMinutes.AutoSize = true;
            labelMinutes.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMinutes.Location = new Point(303, 154);
            labelMinutes.Name = "labelMinutes";
            labelMinutes.Size = new Size(65, 78);
            labelMinutes.TabIndex = 3;
            labelMinutes.Text = "0";
            labelMinutes.Click += labelMinutes_Click;
            // 
            // labelSeconds
            // 
            labelSeconds.AutoSize = true;
            labelSeconds.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSeconds.Location = new Point(471, 154);
            labelSeconds.Name = "labelSeconds";
            labelSeconds.Size = new Size(65, 78);
            labelSeconds.TabIndex = 4;
            labelSeconds.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(392, 154);
            label3.Name = "label3";
            label3.Size = new Size(46, 78);
            label3.TabIndex = 5;
            label3.Text = ":";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormStopWatch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(labelSeconds);
            Controls.Add(labelMinutes);
            Controls.Add(buttonBerhenti);
            Controls.Add(buttonMulai);
            Controls.Add(label1);
            Name = "FormStopWatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormStopWatch";
            Load += FormStopWatch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonMulai;
        private Button buttonBerhenti;
        private Label labelMinutes;
        private Label labelSeconds;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}