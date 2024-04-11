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

        private void Symbol_TextChanged(object sender, EventArgs e)
        {
            string input = Symbol.Text;
            if(input == "+")
            {

            }
        }

        private void number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void number2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RunBTN_Click(object sender, EventArgs e)
        {
            string input = Symbol.Text;

            int numbers1 = int.Parse(number1.Text);
            int numbers2 = int.Parse(number2.Text);
            if (input == "+")
            {
               Answer.Text =(numbers1+numbers2).ToString();
            }
            if (input == "-")
            {
                Answer.Text = (numbers1 - numbers2).ToString();
            }
            if (input == "*")
            {
                Answer.Text = (numbers1 * numbers2).ToString();
            }
            if (input == "/")
            {
                Answer.Text = (numbers1 / numbers2).ToString();
            }
        }

        private void Answer_Click(object sender, EventArgs e)
        {

        }
    }
}
