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
    public partial class FormLastMenu : Form
    {
        public FormLastMenu()
        {
            InitializeComponent();
        }

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

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            List<string> mainDishes = new List<string>();
            List<string> sideDishes = new List<string>();

            // 主食區的 CheckBox
            if (checkBox1.Checked)
                mainDishes.Add(checkBox1.Text);
            if (checkBox2.Checked)
                mainDishes.Add(checkBox2.Text);
            if (checkBox3.Checked)
                mainDishes.Add(checkBox3.Text);

            // 副食區的 CheckBox
            if (checkBox4.Checked)
                sideDishes.Add(checkBox4.Text);
            if (checkBox5.Checked)
                sideDishes.Add(checkBox5.Text);
            if (checkBox6.Checked)
                sideDishes.Add(checkBox6.Text);

            // 設定 CSV 檔案路徑
            string filePath = @"F:\Orders.csv";

            // 取得當前時間
            string currentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // 建立一個 StreamWriter 來寫入 CSV 文件
            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8)) // 使用 true 以附加模式寫入
            {
                // 檢查文件是否為空，若是則寫入表頭
                if (writer.BaseStream.Length == 0)
                {
                    writer.WriteLine("時間,類型,餐點名稱,數量,價格");
                }

                // 寫入選中的主食訊息
                foreach (var item in mainDishes)
                {
                    writer.WriteLine($"{currentTime},主食,{item},1,{item.Length}"); // 這裡可以依照需求修改數量和價格
                }

                // 寫入選中的副食訊息
                foreach (var item in sideDishes)
                {
                    writer.WriteLine($"{currentTime},副食,{item},1,{item.Length}"); // 這裡可以依照需求修改數量和價格
                }
            }

            // 顯示當前點餐訊息
            string message = "您已點選的餐點:\n\n主食:\n" + string.Join("\n", mainDishes) + "\n\n副食:\n" + string.Join("\n", sideDishes);
            MessageBox.Show(message, "點餐資訊");

            MessageBox.Show("訂單已儲存至 " + filePath);
        }
    }
}
