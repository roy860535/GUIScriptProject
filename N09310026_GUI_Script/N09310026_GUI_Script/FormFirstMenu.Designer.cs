namespace N09310026_GUI_Script
{
    partial class FormFirstMenu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.TouchMe = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TchHer = new System.Windows.Forms.Button();
            this.TextRobot = new System.Windows.Forms.Button();
            this.ChangeRobot = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Button();
            this.FinalCodeGame = new System.Windows.Forms.Button();
            this.LastMenuBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextChangeTool = new System.Windows.Forms.Button();
            this.TypingSpeedGame = new System.Windows.Forms.Button();
            this.ImageViewer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(703, 528);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "多遊四甲  N09310026 魏暐哲";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TouchMe
            // 
            this.TouchMe.AutoSize = true;
            this.TouchMe.Location = new System.Drawing.Point(876, 116);
            this.TouchMe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TouchMe.Name = "TouchMe";
            this.TouchMe.Size = new System.Drawing.Size(82, 15);
            this.TouchMe.TabIndex = 7;
            this.TouchMe.Text = "通關有需求";
            this.TouchMe.Click += new System.EventHandler(this.TouchMe_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(879, 155);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(59, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "允許";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TchHer
            // 
            this.TchHer.Location = new System.Drawing.Point(879, 196);
            this.TchHer.Margin = new System.Windows.Forms.Padding(4);
            this.TchHer.Name = "TchHer";
            this.TchHer.Size = new System.Drawing.Size(100, 29);
            this.TchHer.TabIndex = 9;
            this.TchHer.Text = "碰它";
            this.TchHer.UseVisualStyleBackColor = true;
            this.TchHer.Click += new System.EventHandler(this.TchHer_Click);
            // 
            // TextRobot
            // 
            this.TextRobot.Font = new System.Drawing.Font("新細明體", 12F);
            this.TextRobot.Location = new System.Drawing.Point(52, 132);
            this.TextRobot.Margin = new System.Windows.Forms.Padding(4);
            this.TextRobot.Name = "TextRobot";
            this.TextRobot.Size = new System.Drawing.Size(148, 109);
            this.TextRobot.TabIndex = 10;
            this.TextRobot.Text = "計算機&&點擊式小遊戲";
            this.TextRobot.UseVisualStyleBackColor = true;
            this.TextRobot.Click += new System.EventHandler(this.TextRobot_Click);
            // 
            // ChangeRobot
            // 
            this.ChangeRobot.Font = new System.Drawing.Font("新細明體", 12F);
            this.ChangeRobot.Location = new System.Drawing.Point(52, 307);
            this.ChangeRobot.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeRobot.Name = "ChangeRobot";
            this.ChangeRobot.Size = new System.Drawing.Size(148, 112);
            this.ChangeRobot.TabIndex = 11;
            this.ChangeRobot.Text = "數值轉換機器人";
            this.ChangeRobot.UseVisualStyleBackColor = true;
            this.ChangeRobot.Click += new System.EventHandler(this.ChangeRobot_Click);
            // 
            // Timer
            // 
            this.Timer.Font = new System.Drawing.Font("新細明體", 12F);
            this.Timer.Location = new System.Drawing.Point(231, 132);
            this.Timer.Margin = new System.Windows.Forms.Padding(4);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(148, 109);
            this.Timer.TabIndex = 12;
            this.Timer.Text = "計時器";
            this.Timer.UseVisualStyleBackColor = true;
            this.Timer.Click += new System.EventHandler(this.Timer_Click);
            // 
            // FinalCodeGame
            // 
            this.FinalCodeGame.Font = new System.Drawing.Font("新細明體", 12F);
            this.FinalCodeGame.Location = new System.Drawing.Point(231, 307);
            this.FinalCodeGame.Margin = new System.Windows.Forms.Padding(4);
            this.FinalCodeGame.Name = "FinalCodeGame";
            this.FinalCodeGame.Size = new System.Drawing.Size(148, 109);
            this.FinalCodeGame.TabIndex = 13;
            this.FinalCodeGame.Text = "終極遊戲";
            this.FinalCodeGame.UseVisualStyleBackColor = true;
            this.FinalCodeGame.Click += new System.EventHandler(this.FinalCodeGame_Click);
            // 
            // LastMenuBTN
            // 
            this.LastMenuBTN.Font = new System.Drawing.Font("新細明體", 12F);
            this.LastMenuBTN.Location = new System.Drawing.Point(412, 307);
            this.LastMenuBTN.Margin = new System.Windows.Forms.Padding(4);
            this.LastMenuBTN.Name = "LastMenuBTN";
            this.LastMenuBTN.Size = new System.Drawing.Size(148, 109);
            this.LastMenuBTN.TabIndex = 14;
            this.LastMenuBTN.Text = "點餐系統";
            this.LastMenuBTN.UseVisualStyleBackColor = true;
            this.LastMenuBTN.Click += new System.EventHandler(this.LastMenuBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(46, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "WinForm簡易能力展示品";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TextChangeTool
            // 
            this.TextChangeTool.Font = new System.Drawing.Font("新細明體", 12F);
            this.TextChangeTool.Location = new System.Drawing.Point(412, 132);
            this.TextChangeTool.Margin = new System.Windows.Forms.Padding(4);
            this.TextChangeTool.Name = "TextChangeTool";
            this.TextChangeTool.Size = new System.Drawing.Size(148, 109);
            this.TextChangeTool.TabIndex = 16;
            this.TextChangeTool.Text = "文字反轉工具";
            this.TextChangeTool.UseVisualStyleBackColor = true;
            this.TextChangeTool.Click += new System.EventHandler(this.TextChangeTool_Click);
            // 
            // TypingSpeedGame
            // 
            this.TypingSpeedGame.Font = new System.Drawing.Font("新細明體", 12F);
            this.TypingSpeedGame.Location = new System.Drawing.Point(594, 132);
            this.TypingSpeedGame.Margin = new System.Windows.Forms.Padding(4);
            this.TypingSpeedGame.Name = "TypingSpeedGame";
            this.TypingSpeedGame.Size = new System.Drawing.Size(148, 109);
            this.TypingSpeedGame.TabIndex = 17;
            this.TypingSpeedGame.Text = "速打測試";
            this.TypingSpeedGame.UseVisualStyleBackColor = true;
            this.TypingSpeedGame.Click += new System.EventHandler(this.TypingSpeedGame_Click);
            // 
            // ImageViewer
            // 
            this.ImageViewer.Font = new System.Drawing.Font("新細明體", 12F);
            this.ImageViewer.Location = new System.Drawing.Point(594, 307);
            this.ImageViewer.Margin = new System.Windows.Forms.Padding(4);
            this.ImageViewer.Name = "ImageViewer";
            this.ImageViewer.Size = new System.Drawing.Size(148, 109);
            this.ImageViewer.TabIndex = 18;
            this.ImageViewer.Text = "圖片瀏覽器";
            this.ImageViewer.UseVisualStyleBackColor = true;
            this.ImageViewer.Click += new System.EventHandler(this.ImageViewer_Click);
            // 
            // FormFirstMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.ImageViewer);
            this.Controls.Add(this.TypingSpeedGame);
            this.Controls.Add(this.TextChangeTool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LastMenuBTN);
            this.Controls.Add(this.FinalCodeGame);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.ChangeRobot);
            this.Controls.Add(this.TextRobot);
            this.Controls.Add(this.TchHer);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TouchMe);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFirstMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "你能不能活下來?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TouchMe;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button TchHer;
        private System.Windows.Forms.Button TextRobot;
        private System.Windows.Forms.Button ChangeRobot;
        private System.Windows.Forms.Button Timer;
        private System.Windows.Forms.Button FinalCodeGame;
        private System.Windows.Forms.Button LastMenuBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TextChangeTool;
        private System.Windows.Forms.Button TypingSpeedGame;
        private System.Windows.Forms.Button ImageViewer;
    }
}

