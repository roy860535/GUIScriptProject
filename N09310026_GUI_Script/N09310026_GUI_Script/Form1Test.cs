using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310026_GUI_Script
{
    public partial class Form1Test : Form
    {
        public Form1Test()
        {
            InitializeComponent();
        }

        private void CTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            double c = double.Parse(CTextBox.Text);
            double cha = 9.0 / 5.0;
            double f = c * cha + 32;
            FText.Text = f.ToString();

        }

        private void FText_Click(object sender, EventArgs e)
        {

        }
    }
}
