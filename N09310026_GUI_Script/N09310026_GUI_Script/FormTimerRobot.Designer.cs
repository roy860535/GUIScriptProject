namespace N09310026_GUI_Script
{
    partial class FormTimerRobot
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
            this.components = new System.ComponentModel.Container();
            this.TimeOne = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HelloWorldBTN = new System.Windows.Forms.Button();
            this.TheWorldBTN = new System.Windows.Forms.Button();
            this.EndWorldBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeOne
            // 
            this.TimeOne.AutoSize = true;
            this.TimeOne.Font = new System.Drawing.Font("新細明體", 30F);
            this.TimeOne.Location = new System.Drawing.Point(105, 43);
            this.TimeOne.Name = "TimeOne";
            this.TimeOne.Size = new System.Drawing.Size(76, 40);
            this.TimeOne.TabIndex = 0;
            this.TimeOne.Text = "0秒";
            this.TimeOne.Click += new System.EventHandler(this.TimeOne_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HelloWorldBTN
            // 
            this.HelloWorldBTN.Location = new System.Drawing.Point(24, 108);
            this.HelloWorldBTN.Name = "HelloWorldBTN";
            this.HelloWorldBTN.Size = new System.Drawing.Size(75, 23);
            this.HelloWorldBTN.TabIndex = 1;
            this.HelloWorldBTN.Text = "Hello World";
            this.HelloWorldBTN.UseVisualStyleBackColor = true;
            this.HelloWorldBTN.Click += new System.EventHandler(this.HelloWorldBTN_Click);
            // 
            // TheWorldBTN
            // 
            this.TheWorldBTN.Location = new System.Drawing.Point(106, 108);
            this.TheWorldBTN.Name = "TheWorldBTN";
            this.TheWorldBTN.Size = new System.Drawing.Size(75, 23);
            this.TheWorldBTN.TabIndex = 2;
            this.TheWorldBTN.Text = "The World";
            this.TheWorldBTN.UseVisualStyleBackColor = true;
            this.TheWorldBTN.Click += new System.EventHandler(this.TheWorldBTN_Click);
            // 
            // EndWorldBTN
            // 
            this.EndWorldBTN.Location = new System.Drawing.Point(187, 108);
            this.EndWorldBTN.Name = "EndWorldBTN";
            this.EndWorldBTN.Size = new System.Drawing.Size(75, 23);
            this.EndWorldBTN.TabIndex = 3;
            this.EndWorldBTN.Text = "End World";
            this.EndWorldBTN.UseVisualStyleBackColor = true;
            this.EndWorldBTN.Click += new System.EventHandler(this.EndWorldBTN_Click);
            // 
            // FormTimerRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndWorldBTN);
            this.Controls.Add(this.TheWorldBTN);
            this.Controls.Add(this.HelloWorldBTN);
            this.Controls.Add(this.TimeOne);
            this.Name = "FormTimerRobot";
            this.Text = "FormTimerRobot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeOne;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button HelloWorldBTN;
        private System.Windows.Forms.Button TheWorldBTN;
        private System.Windows.Forms.Button EndWorldBTN;
    }
}