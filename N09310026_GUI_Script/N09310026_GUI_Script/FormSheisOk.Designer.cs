namespace N09310026_GUI_Script
{
    partial class FormSheisOk
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
            this.TrueLove = new System.Windows.Forms.Button();
            this.TextChangeButton = new System.Windows.Forms.Button();
            this.ChangeText = new System.Windows.Forms.Label();
            this.ResetBox = new System.Windows.Forms.CheckBox();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrueLove
            // 
            this.TrueLove.Location = new System.Drawing.Point(35, 30);
            this.TrueLove.Name = "TrueLove";
            this.TrueLove.Size = new System.Drawing.Size(214, 49);
            this.TrueLove.TabIndex = 0;
            this.TrueLove.Text = "曾經有一份真摯的感情擺在我面前";
            this.TrueLove.UseVisualStyleBackColor = true;
            this.TrueLove.Click += new System.EventHandler(this.TrueLove_Click);
            // 
            // TextChangeButton
            // 
            this.TextChangeButton.Location = new System.Drawing.Point(291, 56);
            this.TextChangeButton.Name = "TextChangeButton";
            this.TextChangeButton.Size = new System.Drawing.Size(31, 23);
            this.TextChangeButton.TabIndex = 1;
            this.TextChangeButton.Text = "++";
            this.TextChangeButton.UseVisualStyleBackColor = true;
            this.TextChangeButton.Click += new System.EventHandler(this.TextChangeButton_Click);
            // 
            // ChangeText
            // 
            this.ChangeText.AutoSize = true;
            this.ChangeText.Location = new System.Drawing.Point(289, 30);
            this.ChangeText.Name = "ChangeText";
            this.ChangeText.Size = new System.Drawing.Size(33, 12);
            this.ChangeText.TabIndex = 2;
            this.ChangeText.Text = "label1";
            this.ChangeText.Click += new System.EventHandler(this.ChangeText_Click);
            // 
            // ResetBox
            // 
            this.ResetBox.AutoSize = true;
            this.ResetBox.Location = new System.Drawing.Point(291, 86);
            this.ResetBox.Name = "ResetBox";
            this.ResetBox.Size = new System.Drawing.Size(49, 16);
            this.ResetBox.TabIndex = 3;
            this.ResetBox.Text = "Reset";
            this.ResetBox.UseVisualStyleBackColor = true;
            this.ResetBox.CheckedChanged += new System.EventHandler(this.ResetBox_CheckedChanged);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(328, 57);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(29, 23);
            this.MinusButton.TabIndex = 4;
            this.MinusButton.Text = "--";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // FormSheisOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.ResetBox);
            this.Controls.Add(this.ChangeText);
            this.Controls.Add(this.TextChangeButton);
            this.Controls.Add(this.TrueLove);
            this.Name = "FormSheisOk";
            this.Text = "你成功進入了第二層";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TrueLove;
        private System.Windows.Forms.Button TextChangeButton;
        private System.Windows.Forms.Label ChangeText;
        private System.Windows.Forms.CheckBox ResetBox;
        private System.Windows.Forms.Button MinusButton;
    }
}