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
    public partial class MainForm : Form
    {
        // Buat form menjadi objek
        FormTimer timer;
        FormStopWatch stopWatch;

        // Buat prosuder closed
        void subMenuFormClosed(Object sender, FormClosedEventArgs e)
        {
            timer = null;
            stopWatch = null;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void pilihMenu_Click(object sender, EventArgs e)
        {

        }

        private void subMenuStopWatch_Click(object sender, EventArgs e)
        {
            if (stopWatch == null)
            {
                if (timer != null)
                {
                    timer.Close();
                }
                stopWatch = new FormStopWatch();
                stopWatch.MdiParent = this;
                stopWatch.FormClosed += new FormClosedEventHandler(subMenuFormClosed);
                stopWatch.Show();
            }
            else
            {
                stopWatch.Activate();
            }
        }

        private void subMenuTimer_Click(object sender, EventArgs e)
        {
            if (timer == null)
            {
                if (stopWatch != null)
                {
                    stopWatch.Close(); 
                }
                timer = new FormTimer();
                timer.MdiParent = this;
                timer.FormClosed += new FormClosedEventHandler(subMenuFormClosed);
                timer.Show();
            }
            else
            {
                timer.Activate();
            }
        }
    }
}
