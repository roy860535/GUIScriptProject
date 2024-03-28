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
            // FormTextRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}