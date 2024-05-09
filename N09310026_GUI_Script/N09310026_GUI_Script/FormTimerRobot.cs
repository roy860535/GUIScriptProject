using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310026_GUI_Script
{
    public partial class FormTimerRobot : Form
    {
        int second = 0;
        public FormTimerRobot()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //TimeOne.Text=second.ToString()+"秒";

            TimeOne.Text=string.Format("{0}秒",this.second);
            second++;
        }

        private void TimeOne_Click(object sender, EventArgs e)
        {

        }

        private void HelloWorldBTN_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void TheWorldBTN_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void EndWorldBTN_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            second = 0;
            timer1.Enabled = false;
        }
    }
}
