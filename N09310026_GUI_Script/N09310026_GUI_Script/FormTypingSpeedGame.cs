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
    public partial class FormTypingSpeedGame : Form
    {
        private string testText = "這是一段測試用的隨機文本";
        private int second = 0;
        private DateTime startTime;
        private TimeSpan timeSpan;
        private bool isTestStarted = false;
        public FormTypingSpeedGame()
        {
            InitializeComponent();

            Lenguage.Items.AddRange(new string[] { "日文", "中文", "英文","測試" });
            Lenguage.SelectedIndex = 0;
        }

        private void TestStartBtn_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer1.Enabled = true;
            isTestStarted = true;
        }

        private void Lenguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Lenguage.SelectedItem.ToString())
            {
                case "日文":
                    testText = "このスピードが重要な時代では、速いタイピングの技術を習得することがますます大切になっています。仕事でも勉強でも、素早く文字を入力できることは、時間の節約だけでなく、効率も向上させます。速度だけでなく、正確さも同じくらい重要です。誤った入力があると、全体の進行が遅れることになります。タイピングの練習をする最も良い方法の一つは、定期的にテキスト入力の練習を行うことです。指の動きを訓練するだけでなく、言語の表現能力も向上します。";
                    TopicBox.Text = testText;
                    break;
                case "中文":
                    testText = "在這個快節奏的時代，掌握快速打字的技巧變得越來越重要。無論是工作還是學習，能夠快速地輸入文字，不僅能節省時間，還能提高效率。除了速度，準確性同樣重要，因為錯誤的輸入會拖慢整體進度。練習打字的最好方式之一是經常進行文字輸入練習，不僅可以鍛鍊手指靈活度，還能增強語言表達能力。";
                    TopicBox.Text = testText;
                    break;
                case "英文":
                    testText = "In this fast-paced era, mastering the skill of fast typing is becoming increasingly important. Whether for work or study, being able to type quickly not only saves time but also boosts efficiency. Besides speed, accuracy is equally crucial, as incorrect input can slow down the overall progress. One of the best ways to practice typing is to engage in regular text input exercises. This not only trains the agility of your fingers but also enhances your ability to express yourself in different languages.";
                    TopicBox.Text = testText;
                    break;
                case "測試":
                    testText = "這是一段測試文字";
                    TopicBox.Text = testText;
                    break;
            }
        }

        private void TestBox_TextChanged(object sender, EventArgs e)
        {
            if (isTestStarted && TestBox.Text == TopicBox.Text)
            {
                TimeSpan timeTaken = DateTime.Now - startTime;
                isTestStarted = false;
                second = 0;
                timer1.Enabled = false;
                MessageBox.Show($"你用了 {timeTaken.TotalSeconds} 秒完成測試！");
                
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            second--;
            timeSpan = TimeSpan.FromSeconds(second);
            TimerText.Text = timeSpan.ToString(@"hh\:mm\:ss");
        }

        private void TimeText_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(TimeText.Text,out int timeText))
            {
                second = timeText;
                timeSpan = TimeSpan.FromSeconds(second);
                TimerText.Text = timeSpan.ToString(@"hh\:mm\:ss");
            }
            else
            {
                MessageBox.Show("請輸入正常數值");
            }
        }
        private void TopicBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void TimerText_Click(object sender, EventArgs e)
        {

        }
    }
}
