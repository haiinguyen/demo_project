using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TimerClick
{
    public partial class Form1 : Form
    {
        private Stopwatch stopWatch;
        public Form1()
        {
            InitializeComponent();
        }
        bool kt = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!kt)
            {
                stopWatch.Start();
                button1.Text = "Stop";
                kt = true;
            }
            else
            {
                stopWatch.Stop();
                button1.Text = "Start";
                kt = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }
    }
}
