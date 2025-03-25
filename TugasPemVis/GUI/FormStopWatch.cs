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
    public partial class FormStopWatch : Form
    {
        public FormStopWatch()
        {
            InitializeComponent();
        }

        int timeMin, timeSec;
        bool isActive;

        private void FormStopWatch_Load(object sender, EventArgs e)
        {
            timeSec = 0;
            timeMin = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMulai_Click(object sender, EventArgs e)
        {
            if (isActive == false)
            {
                timeSec = 0;
                timeMin = 0;
                isActive = true;
            }
        }

        private void buttonBerhenti_Click(object sender, EventArgs e)
        {
            isActive = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeSec++;
                if (timeSec >= 60)
                {
                    timeMin++;
                    timeSec = 0;
                }
            }
            DrawTime();
        }

        private void DrawTime()
        {
            labelSeconds.Text = String.Format("{0:0}", timeSec);
            labelMinutes.Text = String.Format("{0:0}", timeMin);
        }

        private void labelMinutes_Click(object sender, EventArgs e)
        {

        }
    }
}
