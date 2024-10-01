
namespace N09310026_GUI_Script
{
    partial class FormTextChangeTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeTextOptions = new System.Windows.Forms.ComboBox();
            this.ChangeTextBtn = new System.Windows.Forms.Button();
            this.InputArea = new System.Windows.Forms.TextBox();
            this.OutputArea = new System.Windows.Forms.TextBox();
            this.ReverseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 25F);
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "文字修改器";
            // 
            // ChangeTextOptions
            // 
            this.ChangeTextOptions.Font = new System.Drawing.Font("新細明體", 15F);
            this.ChangeTextOptions.FormattingEnabled = true;
            this.ChangeTextOptions.Location = new System.Drawing.Point(32, 95);
            this.ChangeTextOptions.Name = "ChangeTextOptions";
            this.ChangeTextOptions.Size = new System.Drawing.Size(221, 33);
            this.ChangeTextOptions.TabIndex = 7;
            this.ChangeTextOptions.SelectedIndexChanged += new System.EventHandler(this.ChangeTextOptions_SelectedIndexChanged);
            // 
            // ChangeTextBtn
            // 
            this.ChangeTextBtn.Font = new System.Drawing.Font("新細明體", 15F);
            this.ChangeTextBtn.Location = new System.Drawing.Point(279, 95);
            this.ChangeTextBtn.Name = "ChangeTextBtn";
            this.ChangeTextBtn.Size = new System.Drawing.Size(118, 33);
            this.ChangeTextBtn.TabIndex = 8;
            this.ChangeTextBtn.Text = "修改";
            this.ChangeTextBtn.UseVisualStyleBackColor = true;
            this.ChangeTextBtn.Click += new System.EventHandler(this.ChangeTextBtn_Click);
            // 
            // InputArea
            // 
            this.InputArea.Font = new System.Drawing.Font("新細明體", 12F);
            this.InputArea.Location = new System.Drawing.Point(32, 147);
            this.InputArea.Multiline = true;
            this.InputArea.Name = "InputArea";
            this.InputArea.Size = new System.Drawing.Size(344, 258);
            this.InputArea.TabIndex = 9;
            this.InputArea.TextChanged += new System.EventHandler(this.InputArea_TextChanged);
            // 
            // OutputArea
            // 
            this.OutputArea.Font = new System.Drawing.Font("新細明體", 12F);
            this.OutputArea.Location = new System.Drawing.Point(423, 147);
            this.OutputArea.Multiline = true;
            this.OutputArea.Name = "OutputArea";
            this.OutputArea.Size = new System.Drawing.Size(344, 258);
            this.OutputArea.TabIndex = 10;
            this.OutputArea.TextChanged += new System.EventHandler(this.OutputArea_TextChanged);
            // 
            // ReverseBtn
            // 
            this.ReverseBtn.Font = new System.Drawing.Font("新細明體", 15F);
            this.ReverseBtn.Location = new System.Drawing.Point(382, 260);
            this.ReverseBtn.Name = "ReverseBtn";
            this.ReverseBtn.Size = new System.Drawing.Size(35, 33);
            this.ReverseBtn.TabIndex = 11;
            this.ReverseBtn.Text = "反";
            this.ReverseBtn.UseVisualStyleBackColor = true;
            this.ReverseBtn.Click += new System.EventHandler(this.ReverseBtn_Click);
            // 
            // FormTextChangeTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReverseBtn);
            this.Controls.Add(this.OutputArea);
            this.Controls.Add(this.InputArea);
            this.Controls.Add(this.ChangeTextBtn);
            this.Controls.Add(this.ChangeTextOptions);
            this.Controls.Add(this.label1);
            this.Name = "FormTextChangeTool";
            this.Text = "FormTextTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ChangeTextOptions;
        private System.Windows.Forms.Button ChangeTextBtn;
        private System.Windows.Forms.TextBox InputArea;
        private System.Windows.Forms.TextBox OutputArea;
        private System.Windows.Forms.Button ReverseBtn;
    }
}