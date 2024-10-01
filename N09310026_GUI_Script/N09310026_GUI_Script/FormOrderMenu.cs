using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310026_GUI_Script
{
    public partial class FormOrderMenu : Form
    {
        public FormOrderMenu()
        {
            InitializeComponent();
        }

        

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            var mainDishes = GetSelectedItems(new[] { checkBox1, checkBox2, checkBox3 });
            var sideDishes = GetSelectedItems(new[] { checkBox4, checkBox5, checkBox6 });

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "Orders.csv");
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            SaveOrderToCsv(filePath, currentTime, mainDishes, sideDishes);
            ShowOrderSummary(mainDishes, sideDishes);

            MessageBox.Show("訂單已儲存至 " + filePath);
        }

        private List<string> GetSelectedItems(CheckBox[] checkBoxes)
        {
            var selectedItems = new List<string>();
            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    selectedItems.Add(checkBox.Text);
                }
            }
            return selectedItems;
        }

        private void SaveOrderToCsv(string filePath, string currentTime, List<string> mainDishes, List<string> sideDishes)
        {
            using (var writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                if (writer.BaseStream.Length == 0)
                {
                    writer.WriteLine("時間,類型,餐點名稱,數量,價格");
                }

                WriteItemsToCsv(writer, currentTime, "主食", mainDishes);
                WriteItemsToCsv(writer, currentTime, "副食", sideDishes);
            }
        }

        private void WriteItemsToCsv(StreamWriter writer, string currentTime, string type, List<string> items)
        {
            foreach (var item in items)
            {
                writer.WriteLine($"{currentTime},{type},{item},1,{item.Length}"); // 這裡可以依需求修改數量與價格
            }
        }

        private void ShowOrderSummary(List<string> mainDishes, List<string> sideDishes)
        {
            var message = $"您已點的餐點:\n\n主食:\n{string.Join("\n", mainDishes)}\n\n副食:\n{string.Join("\n ", sideDishes)}";
            MessageBox.Show(message, "點餐資訊");
        }
        #region NoneUsed
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion 
    }
}
