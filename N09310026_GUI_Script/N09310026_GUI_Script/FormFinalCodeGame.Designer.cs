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
            this.SuspendLayout();
            // 
            // GameStartBTN
            // 
            this.GameStartBTN.Font = new System.Drawing.Font("新細明體", 15F);
            this.GameStartBTN.Location = new System.Drawing.Point(79, 37);
            this.GameStartBTN.Name = "GameStartBTN";
            this.GameStartBTN.Size = new System.Drawing.Size(185, 29);
            this.GameStartBTN.TabIndex = 0;
            this.GameStartBTN.Text = "GameStart";
            this.GameStartBTN.UseVisualStyleBackColor = true;
            this.GameStartBTN.Click += new System.EventHandler(this.GameStartBTN_Click);
            // 
            // GameIntroduction
            // 
            this.GameIntroduction.AutoSize = true;
            this.GameIntroduction.Font = new System.Drawing.Font("新細明體", 25F);
            this.GameIntroduction.Location = new System.Drawing.Point(79, 82);
            this.GameIntroduction.Name = "GameIntroduction";
            this.GameIntroduction.Size = new System.Drawing.Size(185, 34);
            this.GameIntroduction.TabIndex = 1;
            this.GameIntroduction.Text = "請開始遊戲";
            this.GameIntroduction.Click += new System.EventHandler(this.GameIntroduction_Click);
            // 
            // GuessText
            // 
            this.GuessText.AutoSize = true;
            this.GuessText.Font = new System.Drawing.Font("新細明體", 25F);
            this.GuessText.Location = new System.Drawing.Point(79, 133);
            this.GuessText.Name = "GuessText";
            this.GuessText.Size = new System.Drawing.Size(185, 34);
            this.GuessText.TabIndex = 2;
            this.GuessText.Text = "請開始遊戲";
            this.GuessText.Click += new System.EventHandler(this.GuessText_Click);
            // 
            // AnswerText
            // 
            this.AnswerText.Location = new System.Drawing.Point(85, 196);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(100, 22);
            this.AnswerText.TabIndex = 3;
            this.AnswerText.TextChanged += new System.EventHandler(this.AnswerText_TextChanged);
            // 
            // GuessBTN
            // 
            this.GuessBTN.Font = new System.Drawing.Font("新細明體", 10F);
            this.GuessBTN.Location = new System.Drawing.Point(260, 196);
            this.GuessBTN.Name = "GuessBTN";
            this.GuessBTN.Size = new System.Drawing.Size(63, 22);
            this.GuessBTN.TabIndex = 4;
            this.GuessBTN.Text = "猜";
            this.GuessBTN.UseVisualStyleBackColor = true;
            this.GuessBTN.Click += new System.EventHandler(this.GuessBTN_Click);
            // 
            // FormFinalCodeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GuessBTN);
            this.Controls.Add(this.AnswerText);
            this.Controls.Add(this.GuessText);
            this.Controls.Add(this.GameIntroduction);
            this.Controls.Add(this.GameStartBTN);
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
    }
}