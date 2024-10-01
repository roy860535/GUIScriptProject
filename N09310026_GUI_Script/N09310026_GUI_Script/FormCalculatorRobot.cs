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
    public partial class FormCalculatorRobot : Form
    {
        int Rabbitfighttime = 0;
        int Crocodilefighttime = 0;
        public FormCalculatorRobot()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.SelectedIndex = 0;
        }
        private void InputBtn_Click(object sender, EventArgs e)
        {
            string input = TextRobot.Text;
            int numbers = 0;
            if (int.TryParse(input, out numbers))
            {

            }
            ChangeText.Text = TextRobot.Text;
        }
        private void RunBTN_Click(object sender, EventArgs e)
        {


            double numbers1 = Convert.ToDouble(number1.Text);
            double numbers2 = Convert.ToDouble(number2.Text);

            switch (comboBox1.SelectedItem.ToString())
            {
                case "+":
                    Answer.Text = (numbers1 + numbers2).ToString();
                    break;
                case "-":
                    Answer.Text = (numbers1 - numbers2).ToString();
                    break;
                case "*":
                    Answer.Text = (numbers1 * numbers2).ToString();
                    break;
                case "/":
                    if (numbers2 != 0)
                    {
                        Answer.Text = (numbers1 / numbers2).ToString();
                    }
                    else
                    {
                        Answer.Text = "分母不能等於0";
                    }
                    break;
            }

        }
        
        private void btnRabbit_Click(object sender, EventArgs e)
        {
            switch (Rabbitfighttime)
            {
                case 0:
                    btnRabbit.Text = "你與兔子狠狠的纏鬥在了一起";
                    break;
                case 1:
                    btnRabbit.Text = "你被他的蓬鬆外表給欺騙了，你受了重傷";
                    break;
                case 2:
                    btnRabbit.Text = "兔子:驕傲吧，你很強";
                    break;
                case 3:
                    btnRabbit.Text = "你在兔子稱讚的眼光中，慢慢闔上了雙眼";
                    Rabbitfighttime = 0;
                    break;
            }

            Rabbitfighttime++;
        }

        
        private void BtnCrocodile_Click_1(object sender, EventArgs e)
        {
            switch (Crocodilefighttime)
            {
                case 0:
                    BtnCrocodile.Text = "你在與鱷魚的戰鬥中變成了朋友";
                    break;
                case 1:
                    BtnCrocodile.Text = "你有天與鱷魚正在逛街時偶遇了隨機殺人魔兔子";
                    break;
                case 2:
                    BtnCrocodile.Text = "鱷魚為了保護你，留下來殿後";
                    break;
                case 3:
                    BtnCrocodile.Text = "你存活了下來，但是鱷魚的犧牲卻給你帶來了永遠的夢魘，" +
                    "你為了復仇開始了刻苦的鍛鍊，心中充滿了決心";
                    break;
                case 4:
                    BtnCrocodile.Text = "日後你與兔子頂上決戰，同歸於盡了";
                    Crocodilefighttime = 0;
                    break;
            }
            Crocodilefighttime++;
        }

        #region NoneUsed
        private void TextRobot_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeText_Click(object sender, EventArgs e)
        {

        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void number2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void Answer_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        #endregion
    }
}
