using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310026_GUI_Script
{
    public partial class FormTextChangeTool : Form
    {
        public FormTextChangeTool()
        {
            InitializeComponent();
            ChangeTextOptions.Items.Add("反轉字串");
            ChangeTextOptions.Items.Add("移除空格");
            ChangeTextOptions.Items.Add("首字母大寫");
            ChangeTextOptions.Items.Add("全字母大寫");
            ChangeTextOptions.Items.Add("計算單字總數");
            ChangeTextOptions.SelectedIndex = 0;
        }


        private void ChangeTextBtn_Click(object sender, EventArgs e)
        {
            string inputText = InputArea.Text;
            string outputText = OutputArea.Text;

            switch (ChangeTextOptions.SelectedItem.ToString())
            {
                case "反轉字串":
                    outputText = new string(inputText.Reverse().ToArray());
                    break;
                case "移除空格":
                    outputText = inputText.Replace(" ","");
                    break;
                case "首字母大寫":
                    outputText = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(inputText.ToLower());
                    break;
                case "全字母大寫":
                    outputText = inputText.ToUpper();
                    break;
                case "計算單字總數":
                    outputText = CountWords(outputText,inputText).ToString();
                    break;
            }
            OutputArea.Text = outputText;
        }

        public int CountWords(string inputText, string keyword)
        {
            int count = 0;
            int index = 0;

            while((index = inputText.IndexOf(keyword, index, StringComparison.OrdinalIgnoreCase)) != -1){
                count++;
                index += keyword.Length;
            }
            return count;
        }

        private void ReverseBtn_Click(object sender, EventArgs e)
        {
            string temp = InputArea.Text;
            InputArea.Text = OutputArea.Text;
            OutputArea.Text = temp;
        }

        private void ChangeTextOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InputArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputArea_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
