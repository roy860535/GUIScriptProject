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
            this.SuspendLayout();
            // 
            // TrueLove
            // 
            this.TrueLove.Location = new System.Drawing.Point(35, 130);
            this.TrueLove.Name = "TrueLove";
            this.TrueLove.Size = new System.Drawing.Size(214, 49);
            this.TrueLove.TabIndex = 0;
            this.TrueLove.Text = "曾經有一份真摯的感情擺在我面前";
            this.TrueLove.UseVisualStyleBackColor = true;
            this.TrueLove.Click += new System.EventHandler(this.TrueLove_Click);
            // 
            // FormSheisOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrueLove);
            this.Name = "FormSheisOk";
            this.Text = "你成功進入了第二層";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TrueLove;
    }
}