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
    public partial class FormValueConverter : Form
    {

        private Dictionary<(string, string), Func<double, double>> temperatureConversions;
        private Dictionary<(string, string), Func<double, double>> lengthConversions;
        private Dictionary<(string, string), Func<double, double>> WeightConversions;
        private Dictionary<(string, string), Func<double, double>> CapacityConversions;

        public FormValueConverter()
        {
            InitializeComponent();
            InitializeUnitConverters();
            // 溫度選項
            FCHostOptions.Items.AddRange(new string[] { "攝氏(C)", "華氏(F)", "開爾文(K)" });
            FCObjectOptions.Items.AddRange(new string[] { "攝氏(C)", "華氏(F)", "開爾文(K)" });
            FCHostOptions.SelectedIndex = 0;
            FCObjectOptions.SelectedIndex = 0;

            // 長度選項
            LengthHostOptions.Items.AddRange(new string[] { "公分", "公尺", "公里", "英里" });
            LengthObjectOptions.Items.AddRange(new string[] { "公分", "公尺", "公里", "英里" });
            LengthHostOptions.SelectedIndex = 0;
            LengthObjectOptions.SelectedIndex = 0;

            //重量選項
            WeightHostOptions.Items.AddRange(new string[] { "公克", "公斤", "磅" });
            WeightObjectOptions.Items.AddRange(new string[] { "公克", "公斤", "磅" });
            WeightHostOptions.SelectedIndex = 0;
            WeightObjectOptions.SelectedIndex = 0;

            //容量選項
            CapacityHostOptions.Items.AddRange(new string[] { "毫升", "公升", "加侖" });
            CapacityObjectOptions.Items.AddRange(new string[] { "毫升", "公升", "加侖" });
            CapacityHostOptions.SelectedIndex = 0;
            CapacityObjectOptions.SelectedIndex = 0;

        }
        private void InitializeUnitConverters()
        {
            // 溫度轉換
            temperatureConversions = new Dictionary<(string, string), Func<double, double>>
            {
                { ("攝氏(C)", "華氏(F)"), c => c * 9 / 5 + 32 },
                { ("攝氏(C)", "開爾文(K)"), c => c + 273.15 },
                { ("華氏(F)", "攝氏(C)"), f => (f - 32) * 5 / 9 },
                { ("華氏(F)", "開爾文(K)"), f => (f + 459.67) * 5 / 9 },
                { ("開爾文(K)", "攝氏(C)"), k => k - 273.15 },
                { ("開爾文(K)", "華氏(F)"), k => k * 9 / 5 - 459.67 }
            };

            // 長度轉換
            lengthConversions = new Dictionary<(string, string), Func<double, double>>
            {
                { ("公分", "公尺"), cm => cm / 100 },
                { ("公分", "公里"), cm => cm / 100000 },
                { ("公分", "英里"), cm => cm / 160934.4 },
                { ("公尺", "公分"), m => m * 100 },
                { ("公尺", "公里"), m => m / 1000 },
                { ("公尺", "英里"), m => m / 1609.34 },
                { ("公里", "公分"), km => km * 100000 },
                { ("公里", "公尺"), km => km * 1000 },
                { ("公里", "英里"), km => km / 1.60934 },
                { ("英里", "公分"), mi => mi * 160934.4 },
                { ("英里", "公尺"), mi => mi * 1609.34 },
                { ("英里", "公里"), mi => mi * 1.60934 }
            };
            WeightConversions = new Dictionary<(string, string), Func<double, double>>
            {
                { ("公克","公斤"), g => g/1000 },
                { ("公克","磅"), g => g*0.00220462 },
                { ("公斤","公克"), kg => kg*1000 },
                { ("公斤","磅"), kg => kg * 2.20462 },
                { ("磅","公克"), ib => ib*453.592 },
                { ("磅","公斤"), ib => ib*0.453592 }
            };
            CapacityConversions = new Dictionary<(string, string), Func<double, double>>
            {
                { ("毫升","公升"), ml => ml/1000 },
                { ("毫升","加侖"), ml => ml*0.000264172 },
                { ("公升","毫升"), l => l*1000 },
                { ("公升","加侖"), l => l*0.264172 },
                { ("加侖","毫升"), gal => gal*3785.41 },
                { ("加侖","公升"), gal => gal*3.78541 },
            };

        }

        private void ChangeTemperatureBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(CTextBox.Text, out double input))
            {
                string hostUnit = FCHostOptions.SelectedItem.ToString();
                string objectUnit = FCObjectOptions.SelectedItem.ToString();
                ValueConvert(hostUnit, objectUnit, input, temperatureConversions, OutputTemperatureText);
            }
            else
            {
                OutputTemperatureText.Text = "請輸入有效的數值";
            }

        }
        private void ChangeLengthBtn_Click(object sender, EventArgs e)
        {
            if(double.TryParse(InputLengthText.Text,out double input))
            {
                string hostUnit = LengthHostOptions.SelectedItem.ToString();
                string objectUnit = LengthObjectOptions.SelectedItem.ToString();
                ValueConvert(hostUnit, objectUnit, input, lengthConversions, OutputLengthText);
            }
            else
            {
                OutputLengthText.Text = "請輸入有效的數值";
            }
        }
        private void ChangeCapacityBtn_Click(object sender, EventArgs e)
        {
            if(double.TryParse(InputCapacityText.Text,out double input))
            {
                string hostUnit = CapacityHostOptions.SelectedItem.ToString();
                string objectUnit = CapacityObjectOptions.SelectedItem.ToString();
                ValueConvert(hostUnit, objectUnit, input, CapacityConversions, OutputCapacityText);
            }
            else
            {
                OutputCapacityText.Text = "請輸入有效的數值";
            }
        }
        private void ChangeWeightBtn_Click(object sender, EventArgs e)
        {
            if (double.TryParse(InputWeightText.Text, out double input))
            {
                string hostUnit = WeightHostOptions.SelectedItem.ToString();
                string objectUnit = WeightObjectOptions.SelectedItem.ToString();
                ValueConvert(hostUnit, objectUnit, input, WeightConversions, OutputWeightText);
            }
            else
            {
                OutputWeightText.Text = "請輸入有效的數值";
            }
        }

        public void ValueConvert(string hostUnit, string objectUnit, double inputValue, Dictionary<(string, string), Func<double, double>> conversionDict, Label outputLabel)
        {
            if (hostUnit == objectUnit)
            {
                outputLabel.Text = inputValue.ToString();
            }
            else if (conversionDict.ContainsKey((hostUnit, objectUnit)))
            {
                double result = conversionDict[(hostUnit, objectUnit)](inputValue);
                outputLabel.Text = result.ToString();
            }
            else
            {
                outputLabel.Text = "無法轉換";
            }
        }

        #region NoneUsed
        private void CTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void FCHostOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FCObjectOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void WeightHostOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void WeightObjectOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CapacityHostOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CapacityObjectOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LengthObjectOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void OutputLengthText_Click(object sender, EventArgs e)
        {

        }
        private void OutputWeightText_Click(object sender, EventArgs e)
        {

        }
        private void OutputCapacityText_Click(object sender, EventArgs e)
        {

        }
        private void FormFCConverter_Load(object sender, EventArgs e)
        {

        }
        private void OutputTemperatureText_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
