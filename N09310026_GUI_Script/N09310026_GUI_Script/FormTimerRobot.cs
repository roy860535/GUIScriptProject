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
        int elapsedSeconds = 0;
        int labelIndex = 0;
        TimeSpan timeSpan;
        public FormTimerRobot()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //TimeOne.Text=second.ToString()+"秒";
            second++;
            timeSpan = TimeSpan.FromSeconds(second);
            TimeOne.Text = timeSpan.ToString(@"hh\:mm\:ss");
            
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void StopBTN_Click(object sender, EventArgs e)
        {
            timeSpan = TimeSpan.FromSeconds(second);
            string formattedTime = timeSpan.ToString(@"hh\:mm\:ss");
            switch (labelIndex)
            {
                case 0:
                    TimeKeep1.Text = formattedTime;
                    break;
                case 1:
                    TimeKeep2.Text = formattedTime;
                    break;
                case 2:
                    TimeKeep3.Text = formattedTime;
                    break;
            }

            labelIndex = (labelIndex + 1) % 3;

        }

        private void EndWorldBTN_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            second = 0;
            TimeOne.Text = "00:00:00";
            labelIndex = 0;
            timer1.Enabled = false;
        }
        private void Stopwatch_Tick(object sender, EventArgs e)
        {
            elapsedSeconds--;
            timeSpan = TimeSpan.FromSeconds(elapsedSeconds);
            StopWatchLable.Text = timeSpan.ToString(@"hh\:mm\:ss");
        }

        private void StopWatchStart_Click(object sender, EventArgs e)
        {
            
            if (elapsedSeconds > 0)
            {
                Stopwatch.Enabled = true;
            }
            
        }

        private void StopWatchStop_Click(object sender, EventArgs e)
        {
            Stopwatch.Enabled = false;
        }

        private void StopWatcClear_Click(object sender, EventArgs e)
        {
            elapsedSeconds = 0;
            Stopwatch.Enabled = false;
            Stopwatch.Stop();
            StopWatchLable.Text = "00:00:00";
        }
        private void SetTimeBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SetTimerBox.Text, out int timer))
            {
                elapsedSeconds = timer;
                timeSpan = TimeSpan.FromSeconds(elapsedSeconds);
                StopWatchLable.Text = timeSpan.ToString(@"hh\:mm\:ss");
            }
        }
        #region NoneUsed
        private void TimeOne_Click(object sender, EventArgs e)
        {

        }

        private void StopWatchLable_Click(object sender, EventArgs e)
        {

        }

        private void SetStopTimerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lable2_Click(object sender, EventArgs e)
        {

        }

        private void TimeKeep1_Click(object sender, EventArgs e)
        {

        }

        private void TimeKeep2_Click(object sender, EventArgs e)
        {

        }

        private void TimeKeep3_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
