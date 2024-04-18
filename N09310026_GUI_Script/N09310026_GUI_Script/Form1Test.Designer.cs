namespace N09310026_GUI_Script
{
    partial class Form1Test
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
            this.Clable = new System.Windows.Forms.Label();
            this.Flable = new System.Windows.Forms.Label();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.FText = new System.Windows.Forms.Label();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Clable
            // 
            this.Clable.AutoSize = true;
            this.Clable.Font = new System.Drawing.Font("新細明體", 25F);
            this.Clable.Location = new System.Drawing.Point(65, 40);
            this.Clable.Name = "Clable";
            this.Clable.Size = new System.Drawing.Size(144, 34);
            this.Clable.TabIndex = 0;
            this.Clable.Text = "攝氏(C) :";
            // 
            // Flable
            // 
            this.Flable.AutoSize = true;
            this.Flable.Font = new System.Drawing.Font("新細明體", 25F);
            this.Flable.Location = new System.Drawing.Point(68, 180);
            this.Flable.Name = "Flable";
            this.Flable.Size = new System.Drawing.Size(150, 34);
            this.Flable.TabIndex = 1;
            this.Flable.Text = "華氏(F) : ";
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Font = new System.Drawing.Font("新細明體", 25F);
            this.ChangeBtn.Location = new System.Drawing.Point(215, 96);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(175, 60);
            this.ChangeBtn.TabIndex = 2;
            this.ChangeBtn.Text = "轉換";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // FText
            // 
            this.FText.AutoSize = true;
            this.FText.Font = new System.Drawing.Font("新細明體", 25F);
            this.FText.Location = new System.Drawing.Point(209, 180);
            this.FText.Name = "FText";
            this.FText.Size = new System.Drawing.Size(185, 34);
            this.FText.TabIndex = 3;
            this.FText.Text = "請輸入攝氏";
            this.FText.Click += new System.EventHandler(this.FText_Click);
            // 
            // CTextBox
            // 
            this.CTextBox.Location = new System.Drawing.Point(215, 52);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(175, 22);
            this.CTextBox.TabIndex = 4;
            this.CTextBox.TextChanged += new System.EventHandler(this.CTextBox_TextChanged);
            // 
            // Form1Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CTextBox);
            this.Controls.Add(this.FText);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.Flable);
            this.Controls.Add(this.Clable);
            this.Name = "Form1Test";
            this.Text = "Form1Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Clable;
        private System.Windows.Forms.Label Flable;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Label FText;
        private System.Windows.Forms.TextBox CTextBox;
    }
}