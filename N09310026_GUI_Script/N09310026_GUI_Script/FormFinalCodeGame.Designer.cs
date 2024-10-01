namespace N09310026_GUI_Script
{
    partial class FormFinalCodeGame
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
            this.GameStartBTN = new System.Windows.Forms.Button();
            this.GameIntroduction = new System.Windows.Forms.Label();
            this.GuessText = new System.Windows.Forms.Label();
            this.AnswerText = new System.Windows.Forms.TextBox();
            this.GuessBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameStartBTN
            // 
            this.GameStartBTN.Font = new System.Drawing.Font("新細明體", 15F);
            this.GameStartBTN.Location = new System.Drawing.Point(59, 219);
            this.GameStartBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameStartBTN.Name = "GameStartBTN";
            this.GameStartBTN.Size = new System.Drawing.Size(247, 36);
            this.GameStartBTN.TabIndex = 0;
            this.GameStartBTN.Text = "GameStart";
            this.GameStartBTN.UseVisualStyleBackColor = true;
            this.GameStartBTN.Click += new System.EventHandler(this.GameStartBTN_Click);
            // 
            // GameIntroduction
            // 
            this.GameIntroduction.AutoSize = true;
            this.GameIntroduction.Font = new System.Drawing.Font("新細明體", 25F);
            this.GameIntroduction.Location = new System.Drawing.Point(52, 289);
            this.GameIntroduction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameIntroduction.Name = "GameIntroduction";
            this.GameIntroduction.Size = new System.Drawing.Size(228, 42);
            this.GameIntroduction.TabIndex = 1;
            this.GameIntroduction.Text = "請開始遊戲";
            this.GameIntroduction.Click += new System.EventHandler(this.GameIntroduction_Click);
            // 
            // GuessText
            // 
            this.GuessText.AutoSize = true;
            this.GuessText.Font = new System.Drawing.Font("新細明體", 25F);
            this.GuessText.Location = new System.Drawing.Point(52, 353);
            this.GuessText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GuessText.Name = "GuessText";
            this.GuessText.Size = new System.Drawing.Size(228, 42);
            this.GuessText.TabIndex = 2;
            this.GuessText.Text = "請開始遊戲";
            this.GuessText.Click += new System.EventHandler(this.GuessText_Click);
            // 
            // AnswerText
            // 
            this.AnswerText.Font = new System.Drawing.Font("新細明體", 22.5F);
            this.AnswerText.Location = new System.Drawing.Point(59, 416);
            this.AnswerText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(170, 52);
            this.AnswerText.TabIndex = 3;
            this.AnswerText.TextChanged += new System.EventHandler(this.AnswerText_TextChanged);
            // 
            // GuessBTN
            // 
            this.GuessBTN.Font = new System.Drawing.Font("新細明體", 20F);
            this.GuessBTN.Location = new System.Drawing.Point(294, 415);
            this.GuessBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GuessBTN.Name = "GuessBTN";
            this.GuessBTN.Size = new System.Drawing.Size(122, 54);
            this.GuessBTN.TabIndex = 4;
            this.GuessBTN.Text = "猜";
            this.GuessBTN.UseVisualStyleBackColor = true;
            this.GuessBTN.Click += new System.EventHandler(this.GuessBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 25F);
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "終極遊戲";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(54, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 75);
            this.label2.TabIndex = 6;
            this.label2.Text = "按下按鈕後會隨機產生數字，\r\n請在方塊中輸入你猜的答案，\r\n輸入數值和答案相同為勝利條件";
            // 
            // FormFinalCodeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuessBTN);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.GuessText);
            this.Controls.Add(this.GameIntroduction);
            this.Controls.Add(this.GameStartBTN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFinalCodeGame";
            this.Text = "FormFinalCodeGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GameStartBTN;
        private System.Windows.Forms.Label GameIntroduction;
        private System.Windows.Forms.Label GuessText;
        private System.Windows.Forms.TextBox AnswerText;
        private System.Windows.Forms.Button GuessBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}