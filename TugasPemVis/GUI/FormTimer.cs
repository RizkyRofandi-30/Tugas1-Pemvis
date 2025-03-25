    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace TugasPemVis.GUI
    {
        public partial class FormTimer : Form
        {
            int remainingTime;
            public FormTimer()
            {
                InitializeComponent();
            }

            private void FormTimer_Load(object sender, EventArgs e)
            {

            }

            private void buttonMulai_Click(object sender, EventArgs e)
            {
                if (int.TryParse(textBoxMinutes.Text, out int minutes) && minutes > 0)
                {
                    remainingTime = minutes * 60;
                    timer1.Start();
                    buttonMulai.Enabled = false;
                    textBoxMinutes.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Masukan bilangan int");
                }
            }

            private void buttonBerhenti_Click(object sender, EventArgs e)
            {
                timer1.Stop();
                buttonMulai.Enabled = true;
                textBoxMinutes.Enabled = true;
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                if (remainingTime > 0)
                {
                    remainingTime--;
                    DrawTime();
                }
                else
                {
                    timer1.Stop();
                    buttonMulai.Enabled = true;
                    textBoxMinutes.Enabled = true;
                }
            }

            private void DrawTime()
            {
                int seconds = remainingTime % 60;
                int minutes = remainingTime / 60;
                labelMinutes.Text = minutes.ToString("D2"); 
                labelSeconds.Text = seconds.ToString("D2");
        }

            private void textBoxMinutes_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
