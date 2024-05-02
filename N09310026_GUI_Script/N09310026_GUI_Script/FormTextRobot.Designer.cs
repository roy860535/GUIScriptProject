namespace N09310026_GUI_Script
{
    partial class FormTextRobot
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
            this.ChangeText = new System.Windows.Forms.Label();
            this.TextRobot = new System.Windows.Forms.TextBox();
            this.InputBtn = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.TextBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.RunBTN = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ChangeText
            // 
            this.ChangeText.AutoSize = true;
            this.ChangeText.Font = new System.Drawing.Font("新細明體", 12F);
            this.ChangeText.Location = new System.Drawing.Point(40, 32);
            this.ChangeText.Name = "ChangeText";
            this.ChangeText.Size = new System.Drawing.Size(103, 16);
            this.ChangeText.TabIndex = 0;
            this.ChangeText.Text = "請讓我幫助你";
            this.ChangeText.Click += new System.EventHandler(this.ChangeText_Click);
            // 
            // TextRobot
            // 
            this.TextRobot.Location = new System.Drawing.Point(43, 64);
            this.TextRobot.Name = "TextRobot";
            this.TextRobot.Size = new System.Drawing.Size(100, 22);
            this.TextRobot.TabIndex = 1;
            this.TextRobot.TextChanged += new System.EventHandler(this.TextRobot_TextChanged);
            // 
            // InputBtn
            // 
            this.InputBtn.Font = new System.Drawing.Font("新細明體", 12F);
            this.InputBtn.Location = new System.Drawing.Point(43, 103);
            this.InputBtn.Name = "InputBtn";
            this.InputBtn.Size = new System.Drawing.Size(80, 26);
            this.InputBtn.TabIndex = 2;
            this.InputBtn.Text = "搜尋";
            this.InputBtn.UseVisualStyleBackColor = true;
            this.InputBtn.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(43, 169);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 22);
            this.number1.TabIndex = 3;
            this.number1.TextChanged += new System.EventHandler(this.number1_TextChanged);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(322, 169);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 22);
            this.number2.TabIndex = 5;
            this.number2.TextChanged += new System.EventHandler(this.number2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(472, 172);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(15, 12);
            this.Answer.TabIndex = 7;
            this.Answer.Text = "??";
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // RunBTN
            // 
            this.RunBTN.Location = new System.Drawing.Point(43, 212);
            this.RunBTN.Name = "RunBTN";
            this.RunBTN.Size = new System.Drawing.Size(75, 23);
            this.RunBTN.TabIndex = 8;
            this.RunBTN.Text = "計算";
            this.RunBTN.UseVisualStyleBackColor = true;
            this.RunBTN.Click += new System.EventHandler(this.RunBTN_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 169);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormTextRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RunBTN);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.InputBtn);
            this.Controls.Add(this.TextRobot);
            this.Controls.Add(this.ChangeText);
            this.Name = "FormTextRobot";
            this.Text = "FormTextRobot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChangeText;
        private System.Windows.Forms.TextBox TextRobot;
        private System.Windows.Forms.Button InputBtn;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Button RunBTN;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}