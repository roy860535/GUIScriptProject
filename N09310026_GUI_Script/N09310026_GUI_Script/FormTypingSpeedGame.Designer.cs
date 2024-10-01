
namespace N09310026_GUI_Script
{
    partial class FormTypingSpeedGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TopicBox = new System.Windows.Forms.TextBox();
            this.TestBox = new System.Windows.Forms.TextBox();
            this.TimerText = new System.Windows.Forms.Label();
            this.TestStartBtn = new System.Windows.Forms.Button();
            this.Lenguage = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 25F);
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "打字練習";
            // 
            // TopicBox
            // 
            this.TopicBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.TopicBox.Location = new System.Drawing.Point(12, 137);
            this.TopicBox.Multiline = true;
            this.TopicBox.Name = "TopicBox";
            this.TopicBox.Size = new System.Drawing.Size(349, 301);
            this.TopicBox.TabIndex = 7;
            this.TopicBox.TextChanged += new System.EventHandler(this.TopicBox_TextChanged);
            // 
            // TestBox
            // 
            this.TestBox.Location = new System.Drawing.Point(439, 137);
            this.TestBox.Multiline = true;
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(349, 301);
            this.TestBox.TabIndex = 8;
            this.TestBox.TextChanged += new System.EventHandler(this.TestBox_TextChanged);
            // 
            // TimerText
            // 
            this.TimerText.AutoSize = true;
            this.TimerText.Font = new System.Drawing.Font("新細明體", 20F);
            this.TimerText.Location = new System.Drawing.Point(436, 35);
            this.TimerText.Name = "TimerText";
            this.TimerText.Size = new System.Drawing.Size(129, 34);
            this.TimerText.TabIndex = 10;
            this.TimerText.Text = "00:00:00";
            this.TimerText.Click += new System.EventHandler(this.TimerText_Click);
            // 
            // TestStartBtn
            // 
            this.TestStartBtn.Font = new System.Drawing.Font("新細明體", 15F);
            this.TestStartBtn.Location = new System.Drawing.Point(439, 81);
            this.TestStartBtn.Name = "TestStartBtn";
            this.TestStartBtn.Size = new System.Drawing.Size(179, 40);
            this.TestStartBtn.TabIndex = 11;
            this.TestStartBtn.Text = "開始";
            this.TestStartBtn.UseVisualStyleBackColor = true;
            this.TestStartBtn.Click += new System.EventHandler(this.TestStartBtn_Click);
            // 
            // Lenguage
            // 
            this.Lenguage.Font = new System.Drawing.Font("新細明體", 20F);
            this.Lenguage.FormattingEnabled = true;
            this.Lenguage.Location = new System.Drawing.Point(34, 81);
            this.Lenguage.Name = "Lenguage";
            this.Lenguage.Size = new System.Drawing.Size(179, 41);
            this.Lenguage.TabIndex = 12;
            this.Lenguage.SelectedIndexChanged += new System.EventHandler(this.Lenguage_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimeText
            // 
            this.TimeText.Font = new System.Drawing.Font("新細明體", 15F);
            this.TimeText.Location = new System.Drawing.Point(617, 35);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(171, 37);
            this.TimeText.TabIndex = 13;
            this.TimeText.TextChanged += new System.EventHandler(this.TimeText_TextChanged);
            // 
            // FormTypingSpeedGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.Lenguage);
            this.Controls.Add(this.TestStartBtn);
            this.Controls.Add(this.TimerText);
            this.Controls.Add(this.TestBox);
            this.Controls.Add(this.TopicBox);
            this.Controls.Add(this.label1);
            this.Name = "FormTypingSpeedGame";
            this.Text = "FormTypingSpeedGane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TopicBox;
        private System.Windows.Forms.TextBox TestBox;
        private System.Windows.Forms.Label TimerText;
        private System.Windows.Forms.Button TestStartBtn;
        private System.Windows.Forms.ComboBox Lenguage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TimeText;
    }
}