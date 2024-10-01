using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310026_GUI_Script
{
    public partial class FormFirstMenu : Form
    {
        public FormFirstMenu()
        {
            InitializeComponent();
        }

        int SheisOk=0;
        bool SheisOKFromisopen=false;
        private void TchHer_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TouchMe.Text ="你通過了測試，" +
                    "在按一次試試看?";
                SheisOk++;
                if (SheisOk >= 2&& SheisOKFromisopen == false)
                {
                    SheisOKFromisopen = FormChange(SheisOKFromisopen, new FormCount());
                }

            }
            else if(checkBox1.Checked == false)
            {
                TouchMe.Text ="你不能碰我你知道嗎";
            }

        }
        private void Form_Closed(object sender, System.EventArgs e)
        {
            SheisOKFromisopen = false;
            CalculatorisOpen = false;
            TestChangeRobot = false;
            TimerRobot = false;
            FinalCodegame = false;
            LastMenuBtn = false;
            TextChangeToolBtn = false;
            TypingSpeedGameBtn = false;
            ImageViewerBtn = false;
        }

        private bool FormChange(bool thisbool,Form form)
        {
            if (!thisbool)
            {
                form.FormClosed += Form_Closed;
                form.Show();
                return true;
            }
            return thisbool;

        }

        bool CalculatorisOpen = false;
        private void TextRobot_Click(object sender, EventArgs e)
        {
            CalculatorisOpen = FormChange(CalculatorisOpen, new FormCalculatorRobot());
            
        }

        bool TestChangeRobot = false;
        private void ChangeRobot_Click(object sender, EventArgs e)
        {
            TestChangeRobot = FormChange(TestChangeRobot, new FormValueConverter());
        }

        bool TimerRobot = false;
        private void Timer_Click(object sender, EventArgs e)
        {
            TimerRobot = FormChange(TimerRobot, new FormTimerRobot());
        }

        bool FinalCodegame = false;
        private void FinalCodeGame_Click(object sender, EventArgs e)
        {
            FinalCodegame = FormChange(FinalCodegame, new FormFinalCodeGame());
        }

        bool LastMenuBtn = false;
        private void LastMenuBTN_Click(object sender, EventArgs e)
        {
            LastMenuBtn = FormChange(LastMenuBtn, new FormOrderMenu());
        }

        bool TextChangeToolBtn = false;
        private void TextChangeTool_Click(object sender, EventArgs e)
        {
            TextChangeToolBtn = FormChange(TextChangeToolBtn, new FormTextChangeTool());
        }

        bool TypingSpeedGameBtn = false;
        private void TypingSpeedGame_Click(object sender, EventArgs e)
        {
            TypingSpeedGameBtn = FormChange(TypingSpeedGameBtn, new FormTypingSpeedGame());
        }

        bool ImageViewerBtn = false;
        private void ImageViewer_Click(object sender, EventArgs e)
        {
            ImageViewerBtn = FormChange(ImageViewerBtn, new FormImageViewer());
        }
        #region NoneUsed
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TouchMe_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        
    }
}
