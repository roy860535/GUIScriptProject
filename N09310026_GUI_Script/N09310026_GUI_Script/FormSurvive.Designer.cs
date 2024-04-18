namespace N09310026_GUI_Script
{
    partial class FormSurvive
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRabbit = new System.Windows.Forms.Button();
            this.BtnCrocodile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TouchMe = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TchHer = new System.Windows.Forms.Button();
            this.TextRobot = new System.Windows.Forms.Button();
            this.ChangeRobot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "這裡是動物園";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(258, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "你可以選擇你要搏鬥的動物";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(575, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "你決定??";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnRabbit
            // 
            this.btnRabbit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRabbit.Location = new System.Drawing.Point(61, 246);
            this.btnRabbit.Name = "btnRabbit";
            this.btnRabbit.Size = new System.Drawing.Size(113, 90);
            this.btnRabbit.TabIndex = 4;
            this.btnRabbit.Text = "兔子";
            this.btnRabbit.UseVisualStyleBackColor = true;
            this.btnRabbit.Click += new System.EventHandler(this.btnrabbit_Click);
            // 
            // BtnCrocodile
            // 
            this.BtnCrocodile.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCrocodile.Location = new System.Drawing.Point(61, 124);
            this.BtnCrocodile.Name = "BtnCrocodile";
            this.BtnCrocodile.Size = new System.Drawing.Size(113, 87);
            this.BtnCrocodile.TabIndex = 5;
            this.BtnCrocodile.Text = "鱷魚";
            this.BtnCrocodile.UseVisualStyleBackColor = true;
            this.BtnCrocodile.Click += new System.EventHandler(this.BtnCrocodile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(527, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "多遊四甲  N09310026 魏暐哲";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TouchMe
            // 
            this.TouchMe.AutoSize = true;
            this.TouchMe.Location = new System.Drawing.Point(577, 93);
            this.TouchMe.Name = "TouchMe";
            this.TouchMe.Size = new System.Drawing.Size(70, 12);
            this.TouchMe.TabIndex = 7;
            this.TouchMe.Text = "你想按我嗎?";
            this.TouchMe.Click += new System.EventHandler(this.TouchMe_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(579, 124);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "允許";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // TchHer
            // 
            this.TchHer.Location = new System.Drawing.Point(579, 157);
            this.TchHer.Name = "TchHer";
            this.TchHer.Size = new System.Drawing.Size(75, 23);
            this.TchHer.TabIndex = 9;
            this.TchHer.Text = "碰她";
            this.TchHer.UseVisualStyleBackColor = true;
            this.TchHer.Click += new System.EventHandler(this.TchHer_Click);
            // 
            // TextRobot
            // 
            this.TextRobot.Font = new System.Drawing.Font("新細明體", 12F);
            this.TextRobot.Location = new System.Drawing.Point(195, 124);
            this.TextRobot.Name = "TextRobot";
            this.TextRobot.Size = new System.Drawing.Size(111, 87);
            this.TextRobot.TabIndex = 10;
            this.TextRobot.Text = "對話機器人";
            this.TextRobot.UseVisualStyleBackColor = true;
            this.TextRobot.Click += new System.EventHandler(this.TextRobot_Click);
            // 
            // ChangeRobot
            // 
            this.ChangeRobot.Font = new System.Drawing.Font("新細明體", 12F);
            this.ChangeRobot.Location = new System.Drawing.Point(195, 246);
            this.ChangeRobot.Name = "ChangeRobot";
            this.ChangeRobot.Size = new System.Drawing.Size(111, 90);
            this.ChangeRobot.TabIndex = 11;
            this.ChangeRobot.Text = "華攝氏轉換機器人";
            this.ChangeRobot.UseVisualStyleBackColor = true;
            this.ChangeRobot.Click += new System.EventHandler(this.ChangeRobot_Click);
            // 
            // FormSurvive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeRobot);
            this.Controls.Add(this.TextRobot);
            this.Controls.Add(this.TchHer);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TouchMe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCrocodile);
            this.Controls.Add(this.btnRabbit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSurvive";
            this.Text = "你能不能活下來?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRabbit;
        private System.Windows.Forms.Button BtnCrocodile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TouchMe;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button TchHer;
        private System.Windows.Forms.Button TextRobot;
        private System.Windows.Forms.Button ChangeRobot;
    }
}

