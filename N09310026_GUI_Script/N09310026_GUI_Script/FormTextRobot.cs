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
    public partial class FormTextRobot : Form
    {
        public FormTextRobot()
        {
            InitializeComponent();
            comboBox1.Items.Add("+");
            comboBox1.Items.Add("-");
            comboBox1.Items.Add("*");
            comboBox1.Items.Add("/");
            comboBox1.SelectedIndex = 0;
        }


        private void TextRobot_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeText_Click(object sender, EventArgs e)
        {

        }

        private void InputBtn_Click(object sender, EventArgs e)
        {
            string input = TextRobot.Text;
            int numbers=0;
            if(int.TryParse(input,out numbers))
            {
                
            }
            ChangeText.Text = TextRobot.Text;
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

        private void RunBTN_Click(object sender, EventArgs e)
        {
            

            double numbers1 = Convert.ToDouble(number1.Text);
            double numbers2 = Convert.ToDouble(number2.Text);

            switch(comboBox1.SelectedItem.ToString())
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

        private void Answer_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
