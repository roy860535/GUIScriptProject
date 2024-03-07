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
    public partial class Form1 : Form
    {
        public Form1()
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
            if(Rabbitfighttime >= 3)
            {
                btnRabbit.Text = "你被他的蓬鬆外表給欺騙了，你受了重傷";
            }
            if(Rabbitfighttime >= 5)
            {
                btnRabbit.Text = "兔子:驕傲吧，你很強";
            }
            if(Rabbitfighttime >= 6)
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

            if (Crocodilefighttime >= 3)
            {
                BtnCrocodile.Text = "你有天與鱷魚正在逛街時偶遇了隨機殺人魔兔子";
            }

            if (Crocodilefighttime >= 5)
            {
                BtnCrocodile.Text = "鱷魚為了保護你，留下來殿後";
            }

            if(Crocodilefighttime >= 6)
            {
                BtnCrocodile.Text = "你存活了下來，但是鱷魚的犧牲卻給你帶來了永遠的夢魘，" +
                    "你為了復仇開始了刻苦的鍛鍊，心中充滿了決心";
            }
            if (Crocodilefighttime >= 6)
            {
                BtnCrocodile.Text = "日後你與兔子頂上決戰，同歸於盡了";
                Crocodilefighttime = 0;
            }
            Crocodilefighttime++;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
