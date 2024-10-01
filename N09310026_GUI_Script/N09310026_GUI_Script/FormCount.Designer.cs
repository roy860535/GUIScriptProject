namespace N09310026_GUI_Script
{
    partial class FormCount
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
            this.PlusButton = new System.Windows.Forms.Button();
            this.ChangeText = new System.Windows.Forms.Label();
            this.ResetBox = new System.Windows.Forms.CheckBox();
            this.MinusButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TrueLove
            // 
            this.TrueLove.Font = new System.Drawing.Font("新細明體", 15F);
            this.TrueLove.Location = new System.Drawing.Point(47, 38);
            this.TrueLove.Margin = new System.Windows.Forms.Padding(4);
            this.TrueLove.Name = "TrueLove";
            this.TrueLove.Size = new System.Drawing.Size(301, 81);
            this.TrueLove.TabIndex = 0;
            this.TrueLove.Text = "曾經有一份真摯的感情擺在我面前";
            this.TrueLove.UseVisualStyleBackColor = true;
            this.TrueLove.Click += new System.EventHandler(this.TrueLove_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Font = new System.Drawing.Font("新細明體", 15F);
            this.PlusButton.Location = new System.Drawing.Point(48, 247);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(4);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(158, 49);
            this.PlusButton.TabIndex = 1;
            this.PlusButton.Text = "++";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // ChangeText
            // 
            this.ChangeText.AutoSize = true;
            this.ChangeText.Font = new System.Drawing.Font("新細明體", 15F);
            this.ChangeText.Location = new System.Drawing.Point(44, 204);
            this.ChangeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChangeText.Name = "ChangeText";
            this.ChangeText.Size = new System.Drawing.Size(62, 25);
            this.ChangeText.TabIndex = 2;
            this.ChangeText.Text = "數值";
            this.ChangeText.Click += new System.EventHandler(this.ChangeText_Click);
            // 
            // ResetBox
            // 
            this.ResetBox.AutoSize = true;
            this.ResetBox.Font = new System.Drawing.Font("新細明體", 15F);
            this.ResetBox.Location = new System.Drawing.Point(47, 318);
            this.ResetBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResetBox.Name = "ResetBox";
            this.ResetBox.Size = new System.Drawing.Size(86, 29);
            this.ResetBox.TabIndex = 3;
            this.ResetBox.Text = "Reset";
            this.ResetBox.UseVisualStyleBackColor = true;
            this.ResetBox.CheckedChanged += new System.EventHandler(this.ResetBox_CheckedChanged);
            // 
            // MinusButton
            // 
            this.MinusButton.Font = new System.Drawing.Font("新細明體", 15F);
            this.MinusButton.Location = new System.Drawing.Point(230, 247);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(4);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(156, 49);
            this.MinusButton.TabIndex = 4;
            this.MinusButton.Text = "--";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(42, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "次數計算機";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.ResetBox);
            this.Controls.Add(this.ChangeText);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.TrueLove);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCount";
            this.Text = "你成功進入了第二層";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TrueLove;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Label ChangeText;
        private System.Windows.Forms.CheckBox ResetBox;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Label label1;
    }
}