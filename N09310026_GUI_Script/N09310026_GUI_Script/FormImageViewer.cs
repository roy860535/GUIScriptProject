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
    public partial class FormImageViewer : Form
    {
        private List<string> imageFiles = new List<string>();
        private int currentImageIndex = 0;

        public FormImageViewer()
        {
            InitializeComponent();
        }

        private void SelectFolderBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // 支持多種圖片格式
                    string[] supportedFormats = new[] { "*.jpg", "*.jpeg", "*.png", "*.bmp", "*.gif" };

                    // 將所有格式的圖片加入列表
                    imageFiles = supportedFormats.SelectMany(format =>
                                    Directory.GetFiles(folderDialog.SelectedPath, format))
                                    .ToList();

                    if (imageFiles.Count > 0)
                    {
                        currentImageIndex = 0;
                        DisplayImage(imageFiles[currentImageIndex]);
                    }
                    else
                    {
                        MessageBox.Show("所選文件夾中沒有圖片。", "無圖片", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            if (imageFiles.Count > 0)
            {
                currentImageIndex = (currentImageIndex - 1 + imageFiles.Count) % imageFiles.Count;
                DisplayImage(imageFiles[currentImageIndex]);
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (imageFiles.Count > 0)
            {
                currentImageIndex = (currentImageIndex + 1) % imageFiles.Count;
                DisplayImage(imageFiles[currentImageIndex]);
            }
        }
        private void DisplayImage(string filePath)
        {
            try
            {
                // 加載圖片並設置圖片框自適應
                Image img = Image.FromFile(filePath);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // 自適應圖片框
            }
            catch (Exception ex)
            {
                MessageBox.Show($"無法加載圖片: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
