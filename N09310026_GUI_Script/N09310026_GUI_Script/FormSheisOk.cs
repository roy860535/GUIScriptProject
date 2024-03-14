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
    }
}
