using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace N09310026_GUI_Script
{
    public partial class FormSheisOk : Form
    {
        public FormSheisOk()
        {
            InitializeComponent();
        }

        private void TrueLove_Click(object sender, EventArgs e)
        {
            if(TrueLove.Text == "曾經有一份真摯的感情擺在我面前")
            {
                TrueLove.Text = "我信你個鬼，你這個人壞得很";
            }
            else if (TrueLove.Text == "我信你個鬼，你這個人壞得很")
            {
                TrueLove.Text = "曾經有一份真摯的感情擺在我面前";
            }
        }
        int LableText = 0;
        private void TextChangeButton_Click(object sender, EventArgs e)
        {
            ChangeText.Text= "+" + LableText;
            LableText++;
        }

        private void ChangeText_Click(object sender, EventArgs e)
        {
            

        }

        private void ResetBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ResetBox.Checked)
            {
                LableText = 0;
                ChangeText.Text ="+" + LableText;
            }
        }
    }
}
