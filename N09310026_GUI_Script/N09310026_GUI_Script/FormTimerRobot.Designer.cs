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
            this.StartBTN = new System.Windows.Forms.Button();
            this.StopBTN = new System.Windows.Forms.Button();
            this.EndWorldBTN = new System.Windows.Forms.Button();
            this.Stopwatch = new System.Windows.Forms.Timer(this.components);
            this.StopWatcClear = new System.Windows.Forms.Button();
            this.StopWatchStop = new System.Windows.Forms.Button();
            this.StopWatchStart = new System.Windows.Forms.Button();
            this.StopWatchLable = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SetTimerBox = new System.Windows.Forms.TextBox();
            this.SetTimeBtn = new System.Windows.Forms.Button();
            this.TimeKeep1 = new System.Windows.Forms.Label();
            this.TimeKeep2 = new System.Windows.Forms.Label();
            this.TimeKeep3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeOne
            // 
            this.TimeOne.AutoSize = true;
            this.TimeOne.Font = new System.Drawing.Font("新細明體", 30F);
            this.TimeOne.Location = new System.Drawing.Point(127, 137);
            this.TimeOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeOne.Name = "TimeOne";
            this.TimeOne.Size = new System.Drawing.Size(186, 50);
            this.TimeOne.TabIndex = 0;
            this.TimeOne.Text = "00:00:00";
            this.TimeOne.Click += new System.EventHandler(this.TimeOne_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartBTN
            // 
            this.StartBTN.Font = new System.Drawing.Font("新細明體", 10F);
            this.StartBTN.Location = new System.Drawing.Point(59, 221);
            this.StartBTN.Margin = new System.Windows.Forms.Padding(4);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.Size = new System.Drawing.Size(100, 29);
            this.StartBTN.TabIndex = 1;
            this.StartBTN.Text = "Start";
            this.StartBTN.UseVisualStyleBackColor = true;
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.Font = new System.Drawing.Font("新細明體", 10F);
            this.StopBTN.Location = new System.Drawing.Point(168, 221);
            this.StopBTN.Margin = new System.Windows.Forms.Padding(4);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.Size = new System.Drawing.Size(100, 29);
            this.StopBTN.TabIndex = 2;
            this.StopBTN.Text = "Stop";
            this.StopBTN.UseVisualStyleBackColor = true;
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // EndWorldBTN
            // 
            this.EndWorldBTN.Font = new System.Drawing.Font("新細明體", 10F);
            this.EndWorldBTN.Location = new System.Drawing.Point(276, 221);
            this.EndWorldBTN.Margin = new System.Windows.Forms.Padding(4);
            this.EndWorldBTN.Name = "EndWorldBTN";
            this.EndWorldBTN.Size = new System.Drawing.Size(100, 29);
            this.EndWorldBTN.TabIndex = 3;
            this.EndWorldBTN.Text = "End World";
            this.EndWorldBTN.UseVisualStyleBackColor = true;
            this.EndWorldBTN.Click += new System.EventHandler(this.EndWorldBTN_Click);
            // 
            // Stopwatch
            // 
            this.Stopwatch.Interval = 1000;
            this.Stopwatch.Tick += new System.EventHandler(this.Stopwatch_Tick);
            // 
            // StopWatcClear
            // 
            this.StopWatcClear.Font = new System.Drawing.Font("新細明體", 10F);
            this.StopWatcClear.Location = new System.Drawing.Point(866, 221);
            this.StopWatcClear.Margin = new System.Windows.Forms.Padding(4);
            this.StopWatcClear.Name = "StopWatcClear";
            this.StopWatcClear.Size = new System.Drawing.Size(100, 29);
            this.StopWatcClear.TabIndex = 7;
            this.StopWatcClear.Text = "End World";
            this.StopWatcClear.UseVisualStyleBackColor = true;
            this.StopWatcClear.Click += new System.EventHandler(this.StopWatcClear_Click);
            // 
            // StopWatchStop
            // 
            this.StopWatchStop.Font = new System.Drawing.Font("新細明體", 10F);
            this.StopWatchStop.Location = new System.Drawing.Point(758, 221);
            this.StopWatchStop.Margin = new System.Windows.Forms.Padding(4);
            this.StopWatchStop.Name = "StopWatchStop";
            this.StopWatchStop.Size = new System.Drawing.Size(100, 29);
            this.StopWatchStop.TabIndex = 6;
            this.StopWatchStop.Text = "Stop";
            this.StopWatchStop.UseVisualStyleBackColor = true;
            this.StopWatchStop.Click += new System.EventHandler(this.StopWatchStop_Click);
            // 
            // StopWatchStart
            // 
            this.StopWatchStart.Font = new System.Drawing.Font("新細明體", 10F);
            this.StopWatchStart.Location = new System.Drawing.Point(649, 221);
            this.StopWatchStart.Margin = new System.Windows.Forms.Padding(4);
            this.StopWatchStart.Name = "StopWatchStart";
            this.StopWatchStart.Size = new System.Drawing.Size(100, 29);
            this.StopWatchStart.TabIndex = 5;
            this.StopWatchStart.Text = "Start";
            this.StopWatchStart.UseVisualStyleBackColor = true;
            this.StopWatchStart.Click += new System.EventHandler(this.StopWatchStart_Click);
            // 
            // StopWatchLable
            // 
            this.StopWatchLable.AutoSize = true;
            this.StopWatchLable.Font = new System.Drawing.Font("新細明體", 30F);
            this.StopWatchLable.Location = new System.Drawing.Point(714, 137);
            this.StopWatchLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StopWatchLable.Name = "StopWatchLable";
            this.StopWatchLable.Size = new System.Drawing.Size(186, 50);
            this.StopWatchLable.TabIndex = 4;
            this.StopWatchLable.Text = "00:00:00";
            this.StopWatchLable.Click += new System.EventHandler(this.StopWatchLable_Click);
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("新細明體", 20F);
            this.lable2.Location = new System.Drawing.Point(643, 46);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(185, 34);
            this.lable2.TabIndex = 8;
            this.lable2.Text = "倒數計時器";
            this.lable2.Click += new System.EventHandler(this.lable2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(53, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "碼表";
            // 
            // SetTimerBox
            // 
            this.SetTimerBox.Location = new System.Drawing.Point(649, 190);
            this.SetTimerBox.Name = "SetTimerBox";
            this.SetTimerBox.Size = new System.Drawing.Size(317, 25);
            this.SetTimerBox.TabIndex = 10;
            this.SetTimerBox.Text = "在此輸入數值，基礎為秒";
            this.SetTimerBox.TextChanged += new System.EventHandler(this.SetStopTimerBox_TextChanged);
            // 
            // SetTimeBtn
            // 
            this.SetTimeBtn.Font = new System.Drawing.Font("新細明體", 10F);
            this.SetTimeBtn.Location = new System.Drawing.Point(758, 258);
            this.SetTimeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SetTimeBtn.Name = "SetTimeBtn";
            this.SetTimeBtn.Size = new System.Drawing.Size(100, 29);
            this.SetTimeBtn.TabIndex = 11;
            this.SetTimeBtn.Text = "Set";
            this.SetTimeBtn.UseVisualStyleBackColor = true;
            this.SetTimeBtn.Click += new System.EventHandler(this.SetTimeBtn_Click);
            // 
            // TimeKeep1
            // 
            this.TimeKeep1.AutoSize = true;
            this.TimeKeep1.Font = new System.Drawing.Font("新細明體", 15F);
            this.TimeKeep1.Location = new System.Drawing.Point(281, 267);
            this.TimeKeep1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeKeep1.Name = "TimeKeep1";
            this.TimeKeep1.Size = new System.Drawing.Size(98, 25);
            this.TimeKeep1.TabIndex = 12;
            this.TimeKeep1.Text = "00:00:00";
            this.TimeKeep1.Click += new System.EventHandler(this.TimeKeep1_Click);
            // 
            // TimeKeep2
            // 
            this.TimeKeep2.AutoSize = true;
            this.TimeKeep2.Font = new System.Drawing.Font("新細明體", 15F);
            this.TimeKeep2.Location = new System.Drawing.Point(281, 303);
            this.TimeKeep2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeKeep2.Name = "TimeKeep2";
            this.TimeKeep2.Size = new System.Drawing.Size(98, 25);
            this.TimeKeep2.TabIndex = 13;
            this.TimeKeep2.Text = "00:00:00";
            this.TimeKeep2.Click += new System.EventHandler(this.TimeKeep2_Click);
            // 
            // TimeKeep3
            // 
            this.TimeKeep3.AutoSize = true;
            this.TimeKeep3.Font = new System.Drawing.Font("新細明體", 15F);
            this.TimeKeep3.Location = new System.Drawing.Point(281, 339);
            this.TimeKeep3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeKeep3.Name = "TimeKeep3";
            this.TimeKeep3.Size = new System.Drawing.Size(98, 25);
            this.TimeKeep3.TabIndex = 14;
            this.TimeKeep3.Text = "00:00:00";
            this.TimeKeep3.Click += new System.EventHandler(this.TimeKeep3_Click);
            // 
            // FormTimerRobot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.TimeKeep3);
            this.Controls.Add(this.TimeKeep2);
            this.Controls.Add(this.TimeKeep1);
            this.Controls.Add(this.SetTimeBtn);
            this.Controls.Add(this.SetTimerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.StopWatcClear);
            this.Controls.Add(this.StopWatchStop);
            this.Controls.Add(this.StopWatchStart);
            this.Controls.Add(this.StopWatchLable);
            this.Controls.Add(this.EndWorldBTN);
            this.Controls.Add(this.StopBTN);
            this.Controls.Add(this.StartBTN);
            this.Controls.Add(this.TimeOne);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTimerRobot";
            this.Text = "FormTimerRobot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeOne;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartBTN;
        private System.Windows.Forms.Button StopBTN;
        private System.Windows.Forms.Button EndWorldBTN;
        private System.Windows.Forms.Timer Stopwatch;
        private System.Windows.Forms.Button StopWatcClear;
        private System.Windows.Forms.Button StopWatchStop;
        private System.Windows.Forms.Button StopWatchStart;
        private System.Windows.Forms.Label StopWatchLable;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SetTimerBox;
        private System.Windows.Forms.Button SetTimeBtn;
        private System.Windows.Forms.Label TimeKeep1;
        private System.Windows.Forms.Label TimeKeep2;
        private System.Windows.Forms.Label TimeKeep3;
    }
}