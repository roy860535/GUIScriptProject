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
    public partial class FormSurvive : Form
    {
        public FormSurvive()
        {
            InitializeComponent();
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

        int Rabbitfighttime = 0;
        private void btnrabbit_Click(object sender, EventArgs e)
        {
            if (Rabbitfighttime == 0)
            {
                btnRabbit.Text = "你與兔子狠狠的纏鬥在了一起";
            }
            if(Rabbitfighttime >= 1)
            {
                btnRabbit.Text = "你被他的蓬鬆外表給欺騙了，你受了重傷";
            }
            if(Rabbitfighttime >= 2)
            {
                btnRabbit.Text = "兔子:驕傲吧，你很強";
            }
            if(Rabbitfighttime >= 3)
            {
                btnRabbit.Text = "你在兔子稱讚的眼光中，慢慢闔上了雙眼";
                Rabbitfighttime = 0;
            }
            Rabbitfighttime++;
            
        }

        int Crocodilefighttime = 0;

        private void BtnCrocodile_Click(object sender, EventArgs e)
        {
            if (Crocodilefighttime == 0)
            {
                BtnCrocodile.Text = "你在與鱷魚的戰鬥中變成了朋友";
            }

            if (Crocodilefighttime >= 1)
            {
                BtnCrocodile.Text = "你有天與鱷魚正在逛街時偶遇了隨機殺人魔兔子";
            }

            if (Crocodilefighttime >= 2)
            {
                BtnCrocodile.Text = "鱷魚為了保護你，留下來殿後";
            }

            if(Crocodilefighttime >= 3)
            {
                BtnCrocodile.Text = "你存活了下來，但是鱷魚的犧牲卻給你帶來了永遠的夢魘，" +
                    "你為了復仇開始了刻苦的鍛鍊，心中充滿了決心";
            }
            if (Crocodilefighttime >= 4)
            {
                BtnCrocodile.Text = "日後你與兔子頂上決戰，同歸於盡了";
                Crocodilefighttime = 0;
            }
            Crocodilefighttime++;
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
        int SheisOk=0;
        bool SheisOKFromisopen=false;
        private void TchHer_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TouchMe.Text ="官人你好壞";
                SheisOk++;
                if (SheisOk >= 2&& SheisOKFromisopen == false)
                {
                    FormSheisOk formBTN = new FormSheisOk();
                    formBTN.FormClosed += Form_Closed;
                    formBTN.Show();
                    SheisOKFromisopen = true;
                }

            }
            else if(checkBox1.Checked == false)
            {
                TouchMe.Text ="你不能碰我你知道嗎";
            }

        }

        bool TextRobotisOpen=false;

        private void TextRobot_Click(object sender, EventArgs e)
        {
            if (!TextRobotisOpen)
            {
                FormTextRobot formBTN = new FormTextRobot();
                formBTN.FormClosed += Form_Closed;
                formBTN.Show();
                TextRobotisOpen = true;
            }
        }

        private void Form_Closed(object sender, System.EventArgs e)
        {
            SheisOKFromisopen = false;
            TextRobotisOpen = false;
            TestChangeRobot = false;
            TimerRobot = false;
            FinalCodegame = false;
        }

        bool TestChangeRobot = false;

        private void ChangeRobot_Click(object sender, EventArgs e)
        {
            if (!TestChangeRobot)
            {
                Form1Test formBTN = new Form1Test();
                formBTN.FormClosed += Form_Closed;
                formBTN.Show();
                TestChangeRobot = true;
            }
        }

        bool TimerRobot = false;
        private void Timer_Click(object sender, EventArgs e)
        {
            if (!TimerRobot)
            {
                FormTimerRobot formTimerRobot = new FormTimerRobot();
                formTimerRobot.FormClosed += Form_Closed;
                formTimerRobot.Show();
                TimerRobot = true;
            }
        }

        bool FinalCodegame = false;
        private void FinalCodeGame_Click(object sender, EventArgs e)
        {
            if (!FinalCodegame)
            {
                FormFinalCodeGame formFinalCodeGame = new FormFinalCodeGame();
                formFinalCodeGame.FormClosed += Form_Closed;
                formFinalCodeGame.Show();
                FinalCodegame = true;
            }
        }            
}
}
