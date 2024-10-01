namespace N09310026_GUI_Script
{
    partial class FormCalculatorRobot
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
            this.BtnCrocodile = new System.Windows.Forms.Button();
            this.btnRabbit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChangeText
            // 
            this.ChangeText.AutoSize = true;
            this.ChangeText.Font = new System.Drawing.Font("新細明體", 12F);
            this.ChangeText.Location = new System.Drawing.Point(53, 40);
            this.ChangeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangeText.Name = "ChangeText";
            this.ChangeText.Size = new System.Drawing.Size(249, 20);
            this.ChangeText.TabIndex = 0;
            this.ChangeText.Text = "嘗試輸入文字可以更改內容";
            this.ChangeText.Click += new System.EventHandler(this.ChangeText_Click);
            // 
            // TextRobot
            // 
            this.TextRobot.Location = new System.Drawing.Point(57, 80);
            this.TextRobot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextRobot.Name = "TextRobot";
            this.TextRobot.Size = new System.Drawing.Size(132, 25);
            this.TextRobot.TabIndex = 1;
            this.TextRobot.TextChanged += new System.EventHandler(this.TextRobot_TextChanged);
            // 
            // InputBtn
            // 
            this.InputBtn.Font = new System.Drawing.Font("新細明體", 12F);
            this.InputBtn.Location = new System.Drawing.Point(57, 122);
            this.InputBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.InputBtn.Name = "InputBtn";
            this.InputBtn.Size = new System.Drawing.Size(107, 32);
            this.InputBtn.TabIndex = 2;
            this.InputBtn.Text = "更改";
            this.InputBtn.UseVisualStyleBackColor = true;
            this.InputBtn.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(57, 186);
            this.number1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(132, 25);
            this.number1.TabIndex = 3;
            this.number1.TextChanged += new System.EventHandler(this.number1_TextChanged);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(337, 186);
            this.number2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(132, 25);
            this.number2.TabIndex = 5;
            this.number2.TextChanged += new System.EventHandler(this.number2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 189);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Location = new System.Drawing.Point(500, 189);
            this.Answer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(19, 15);
            this.Answer.TabIndex = 7;
            this.Answer.Text = "??";
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // RunBTN
            // 
            this.RunBTN.Font = new System.Drawing.Font("新細明體", 12F);
            this.RunBTN.Location = new System.Drawing.Point(57, 231);
            this.RunBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RunBTN.Name = "RunBTN";
            this.RunBTN.Size = new System.Drawing.Size(107, 32);
            this.RunBTN.TabIndex = 8;
            this.RunBTN.Text = "計算";
            this.RunBTN.UseVisualStyleBackColor = true;
            this.RunBTN.Click += new System.EventHandler(this.RunBTN_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(197, 186);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 23);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnCrocodile
            // 
            this.BtnCrocodile.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnCrocodile.Location = new System.Drawing.Point(57, 372);
            this.BtnCrocodile.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCrocodile.Name = "BtnCrocodile";
            this.BtnCrocodile.Size = new System.Drawing.Size(460, 110);
            this.BtnCrocodile.TabIndex = 18;
            this.BtnCrocodile.Text = "鱷魚";
            this.BtnCrocodile.UseVisualStyleBackColor = true;
            this.BtnCrocodile.Click += new System.EventHandler(this.BtnCrocodile_Click_1);
            // 
            // btnRabbit
            // 
            this.btnRabbit.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRabbit.Location = new System.Drawing.Point(583, 372);
            this.btnRabbit.Margin = new System.Windows.Forms.Padding(4);
            this.btnRabbit.Name = "btnRabbit";
            this.btnRabbit.Size = new System.Drawing.Size(460, 110);
            this.btnRabbit.TabIndex = 17;
            this.btnRabbit.Text = "兔子";
            this.btnRabbit.UseVisualStyleBackColor = true;
            this.btnRabbit.Click += new System.EventHandler(this.btnRabbit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(744, 318);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "你決定??";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(321, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "你可以選擇你要搏鬥的動物";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(53, 318);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "這裡是動物園";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormTextRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCrocodile);
            this.Controls.Add(this.btnRabbit);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RunBTN);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.InputBtn);
            this.Controls.Add(this.TextRobot);
            this.Controls.Add(this.ChangeText);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button BtnCrocodile;
        private System.Windows.Forms.Button btnRabbit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}