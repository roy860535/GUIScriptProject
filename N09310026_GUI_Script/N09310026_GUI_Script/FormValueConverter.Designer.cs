namespace N09310026_GUI_Script
{
    partial class FormValueConverter
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
            this.ChangeTemperatureBtn = new System.Windows.Forms.Button();
            this.OutputTemperatureText = new System.Windows.Forms.Label();
            this.CTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FCHostOptions = new System.Windows.Forms.ComboBox();
            this.FCObjectOptions = new System.Windows.Forms.ComboBox();
            this.WeightObjectOptions = new System.Windows.Forms.ComboBox();
            this.WeightHostOptions = new System.Windows.Forms.ComboBox();
            this.InputWeightText = new System.Windows.Forms.TextBox();
            this.OutputWeightText = new System.Windows.Forms.Label();
            this.ChangeWeightBtn = new System.Windows.Forms.Button();
            this.LengthObjectOptions = new System.Windows.Forms.ComboBox();
            this.LengthHostOptions = new System.Windows.Forms.ComboBox();
            this.InputLengthText = new System.Windows.Forms.TextBox();
            this.OutputLengthText = new System.Windows.Forms.Label();
            this.ChangeLengthBtn = new System.Windows.Forms.Button();
            this.CapacityObjectOptions = new System.Windows.Forms.ComboBox();
            this.CapacityHostOptions = new System.Windows.Forms.ComboBox();
            this.InputCapacityText = new System.Windows.Forms.TextBox();
            this.OutputCapacityText = new System.Windows.Forms.Label();
            this.ChangeCapacityBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeTemperatureBtn
            // 
            this.ChangeTemperatureBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.ChangeTemperatureBtn.Location = new System.Drawing.Point(164, 113);
            this.ChangeTemperatureBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeTemperatureBtn.Name = "ChangeTemperatureBtn";
            this.ChangeTemperatureBtn.Size = new System.Drawing.Size(233, 50);
            this.ChangeTemperatureBtn.TabIndex = 2;
            this.ChangeTemperatureBtn.Text = "轉換";
            this.ChangeTemperatureBtn.UseVisualStyleBackColor = true;
            this.ChangeTemperatureBtn.Click += new System.EventHandler(this.ChangeTemperatureBtn_Click);
            // 
            // OutputTemperatureText
            // 
            this.OutputTemperatureText.AutoSize = true;
            this.OutputTemperatureText.Font = new System.Drawing.Font("新細明體", 15F);
            this.OutputTemperatureText.Location = new System.Drawing.Point(205, 178);
            this.OutputTemperatureText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputTemperatureText.Name = "OutputTemperatureText";
            this.OutputTemperatureText.Size = new System.Drawing.Size(137, 25);
            this.OutputTemperatureText.TabIndex = 3;
            this.OutputTemperatureText.Text = "請輸入溫度";
            this.OutputTemperatureText.Click += new System.EventHandler(this.OutputTemperatureText_Click);
            // 
            // CTextBox
            // 
            this.CTextBox.Font = new System.Drawing.Font("新細明體", 14F);
            this.CTextBox.Location = new System.Drawing.Point(164, 70);
            this.CTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CTextBox.Name = "CTextBox";
            this.CTextBox.Size = new System.Drawing.Size(232, 35);
            this.CTextBox.TabIndex = 4;
            this.CTextBox.TextChanged += new System.EventHandler(this.CTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15F);
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "溫度測算區";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15F);
            this.label2.Location = new System.Drawing.Point(49, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "重量測算區";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15F);
            this.label3.Location = new System.Drawing.Point(522, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "長度測算區";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15F);
            this.label4.Location = new System.Drawing.Point(522, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "容量測算區";
            // 
            // FCHostOptions
            // 
            this.FCHostOptions.Font = new System.Drawing.Font("新細明體", 15F);
            this.FCHostOptions.FormattingEnabled = true;
            this.FCHostOptions.Location = new System.Drawing.Point(54, 70);
            this.FCHostOptions.Name = "FCHostOptions";
            this.FCHostOptions.Size = new System.Drawing.Size(98, 33);
            this.FCHostOptions.TabIndex = 9;
            this.FCHostOptions.SelectedIndexChanged += new System.EventHandler(this.FCHostOptions_SelectedIndexChanged);
            // 
            // FCObjectOptions
            // 
            this.FCObjectOptions.Font = new System.Drawing.Font("新細明體", 15F);
            this.FCObjectOptions.FormattingEnabled = true;
            this.FCObjectOptions.Location = new System.Drawing.Point(55, 170);
            this.FCObjectOptions.Name = "FCObjectOptions";
            this.FCObjectOptions.Size = new System.Drawing.Size(98, 33);
            this.FCObjectOptions.TabIndex = 10;
            this.FCObjectOptions.SelectedIndexChanged += new System.EventHandler(this.FCObjectOptions_SelectedIndexChanged);
            // 
            // WeightObjectOptions
            // 
            this.WeightObjectOptions.Font = new System.Drawing.Font("新細明體", 15F);
            this.WeightObjectOptions.FormattingEnabled = true;
            this.WeightObjectOptions.Location = new System.Drawing.Point(56, 415);
            this.WeightObjectOptions.Name = "WeightObjectOptions";
            this.WeightObjectOptions.Size = new System.Drawing.Size(98, 33);
            this.WeightObjectOptions.TabIndex = 15;
            this.WeightObjectOptions.SelectedIndexChanged += new System.EventHandler(this.WeightObjectOptions_SelectedIndexChanged);
            // 
            // WeightHostOptions
            // 
            this.WeightHostOptions.Font = new System.Drawing.Font("新細明體", 15F);
            this.WeightHostOptions.FormattingEnabled = true;
            this.WeightHostOptions.Location = new System.Drawing.Point(55, 315);
            this.WeightHostOptions.Name = "WeightHostOptions";
            this.WeightHostOptions.Size = new System.Drawing.Size(98, 33);
            this.WeightHostOptions.TabIndex = 14;
            this.WeightHostOptions.SelectedIndexChanged += new System.EventHandler(this.WeightHostOptions_SelectedIndexChanged);
            // 
            // InputWeightText
            // 
            this.InputWeightText.Font = new System.Drawing.Font("新細明體", 14F);
            this.InputWeightText.Location = new System.Drawing.Point(165, 315);
            this.InputWeightText.Margin = new System.Windows.Forms.Padding(4);
            this.InputWeightText.Name = "InputWeightText";
            this.InputWeightText.Size = new System.Drawing.Size(232, 35);
            this.InputWeightText.TabIndex = 13;
            // 
            // OutputWeightText
            // 
            this.OutputWeightText.AutoSize = true;
            this.OutputWeightText.Font = new System.Drawing.Font("新細明體", 15F);
            this.OutputWeightText.Location = new System.Drawing.Point(206, 423);
            this.OutputWeightText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputWeightText.Name = "OutputWeightText";
            this.OutputWeightText.Size = new System.Drawing.Size(137, 25);
            this.OutputWeightText.TabIndex = 12;
            this.OutputWeightText.Text = "請輸入重量";
            this.OutputWeightText.Click += new System.EventHandler(this.OutputWeightText_Click);
            // 
            // ChangeWeightBtn
            // 
            this.ChangeWeightBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.ChangeWeightBtn.Location = new System.Drawing.Point(165, 358);
            this.ChangeWeightBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeWeightBtn.Name = "ChangeWeightBtn";
            this.ChangeWeightBtn.Size = new System.Drawing.Size(233, 50);
            this.ChangeWeightBtn.TabIndex = 11;
            this.ChangeWeightBtn.Text = "轉換";
            this.ChangeWeightBtn.UseVisualStyleBackColor = true;
            this.ChangeWeightBtn.Click += new System.EventHandler(this.ChangeWeightBtn_Click);
            // 
            // LengthObjectOptions
            // 
            this.LengthObjectOptions.Font = new System.Drawing.Font("新細明體", 15F);
            this.LengthObjectOptions.FormattingEnabled = true;
            this.LengthObjectOptions.Location = new System.Drawing.Point(528, 168);
            this.LengthObjectOptions.Name = "LengthObjectOptions";
            this.LengthObjectOptions.Size = new System.Drawing.Size(98, 33);
            this.LengthObjectOptions.TabIndex = 20;
            this.LengthObjectOptions.SelectedIndexChanged += new System.EventHandler(this.LengthObjectOptions_SelectedIndexChanged);
            // 
            // LengthHostOptions
            // 
            this.LengthHostOptions.Font = new System.Drawing.Font("新細明體", 15F);
            this.LengthHostOptions.FormattingEnabled = true;
            this.LengthHostOptions.Location = new System.Drawing.Point(527, 68);
            this.LengthHostOptions.Name = "LengthHostOptions";
            this.LengthHostOptions.Size = new System.Drawing.Size(98, 33);
            this.LengthHostOptions.TabIndex = 19;
            this.LengthHostOptions.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // InputLengthText
            // 
            this.InputLengthText.Font = new System.Drawing.Font("新細明體", 14F);
            this.InputLengthText.Location = new System.Drawing.Point(637, 68);
            this.InputLengthText.Margin = new System.Windows.Forms.Padding(4);
            this.InputLengthText.Name = "InputLengthText";
            this.InputLengthText.Size = new System.Drawing.Size(232, 35);
            this.InputLengthText.TabIndex = 18;
            // 
            // OutputLengthText
            // 
            this.OutputLengthText.AutoSize = true;
            this.OutputLengthText.Font = new System.Drawing.Font("新細明體", 15F);
            this.OutputLengthText.Location = new System.Drawing.Point(678, 176);
            this.OutputLengthText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputLengthText.Name = "OutputLengthText";
            this.OutputLengthText.Size = new System.Drawing.Size(137, 25);
            this.OutputLengthText.TabIndex = 17;
            this.OutputLengthText.Text = "請輸入長度";
            this.OutputLengthText.Click += new System.EventHandler(this.OutputLengthText_Click);
            // 
            // ChangeLengthBtn
            // 
            this.ChangeLengthBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.ChangeLengthBtn.Location = new System.Drawing.Point(637, 111);
            this.ChangeLengthBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeLengthBtn.Name = "ChangeLengthBtn";
            this.ChangeLengthBtn.Size = new System.Drawing.Size(233, 50);
            this.ChangeLengthBtn.TabIndex = 16;
            this.ChangeLengthBtn.Text = "轉換";
            this.ChangeLengthBtn.UseVisualStyleBackColor = true;
            this.ChangeLengthBtn.Click += new System.EventHandler(this.ChangeLengthBtn_Click);
            // 
            // CapacityObjectOptions
            // 
            this.CapacityObjectOptions.Font = new System.Drawing.Font("新細明體", 15F);
            this.CapacityObjectOptions.FormattingEnabled = true;
            this.CapacityObjectOptions.Location = new System.Drawing.Point(528, 413);
            this.CapacityObjectOptions.Name = "CapacityObjectOptions";
            this.CapacityObjectOptions.Size = new System.Drawing.Size(98, 33);
            this.CapacityObjectOptions.TabIndex = 25;
            this.CapacityObjectOptions.SelectedIndexChanged += new System.EventHandler(this.CapacityObjectOptions_SelectedIndexChanged);
            // 
            // CapacityHostOptions
            // 
            this.CapacityHostOptions.Font = new System.Drawing.Font("新細明體", 15F);
            this.CapacityHostOptions.FormattingEnabled = true;
            this.CapacityHostOptions.Location = new System.Drawing.Point(527, 313);
            this.CapacityHostOptions.Name = "CapacityHostOptions";
            this.CapacityHostOptions.Size = new System.Drawing.Size(98, 33);
            this.CapacityHostOptions.TabIndex = 24;
            this.CapacityHostOptions.SelectedIndexChanged += new System.EventHandler(this.CapacityHostOptions_SelectedIndexChanged);
            // 
            // InputCapacityText
            // 
            this.InputCapacityText.Font = new System.Drawing.Font("新細明體", 14F);
            this.InputCapacityText.Location = new System.Drawing.Point(637, 313);
            this.InputCapacityText.Margin = new System.Windows.Forms.Padding(4);
            this.InputCapacityText.Name = "InputCapacityText";
            this.InputCapacityText.Size = new System.Drawing.Size(232, 35);
            this.InputCapacityText.TabIndex = 23;
            // 
            // OutputCapacityText
            // 
            this.OutputCapacityText.AutoSize = true;
            this.OutputCapacityText.Font = new System.Drawing.Font("新細明體", 15F);
            this.OutputCapacityText.Location = new System.Drawing.Point(678, 421);
            this.OutputCapacityText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputCapacityText.Name = "OutputCapacityText";
            this.OutputCapacityText.Size = new System.Drawing.Size(137, 25);
            this.OutputCapacityText.TabIndex = 22;
            this.OutputCapacityText.Text = "請輸入容量";
            this.OutputCapacityText.Click += new System.EventHandler(this.OutputCapacityText_Click);
            // 
            // ChangeCapacityBtn
            // 
            this.ChangeCapacityBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.ChangeCapacityBtn.Location = new System.Drawing.Point(637, 356);
            this.ChangeCapacityBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeCapacityBtn.Name = "ChangeCapacityBtn";
            this.ChangeCapacityBtn.Size = new System.Drawing.Size(233, 50);
            this.ChangeCapacityBtn.TabIndex = 21;
            this.ChangeCapacityBtn.Text = "轉換";
            this.ChangeCapacityBtn.UseVisualStyleBackColor = true;
            this.ChangeCapacityBtn.Click += new System.EventHandler(this.ChangeCapacityBtn_Click);
            // 
            // FormValueConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.CapacityObjectOptions);
            this.Controls.Add(this.CapacityHostOptions);
            this.Controls.Add(this.InputCapacityText);
            this.Controls.Add(this.OutputCapacityText);
            this.Controls.Add(this.ChangeCapacityBtn);
            this.Controls.Add(this.LengthObjectOptions);
            this.Controls.Add(this.LengthHostOptions);
            this.Controls.Add(this.InputLengthText);
            this.Controls.Add(this.OutputLengthText);
            this.Controls.Add(this.ChangeLengthBtn);
            this.Controls.Add(this.WeightObjectOptions);
            this.Controls.Add(this.WeightHostOptions);
            this.Controls.Add(this.InputWeightText);
            this.Controls.Add(this.OutputWeightText);
            this.Controls.Add(this.ChangeWeightBtn);
            this.Controls.Add(this.FCObjectOptions);
            this.Controls.Add(this.FCHostOptions);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CTextBox);
            this.Controls.Add(this.OutputTemperatureText);
            this.Controls.Add(this.ChangeTemperatureBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormValueConverter";
            this.Text = "Form1Test";
            this.Load += new System.EventHandler(this.FormFCConverter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ChangeTemperatureBtn;
        private System.Windows.Forms.Label OutputTemperatureText;
        private System.Windows.Forms.TextBox CTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox FCHostOptions;
        private System.Windows.Forms.ComboBox FCObjectOptions;
        private System.Windows.Forms.ComboBox WeightObjectOptions;
        private System.Windows.Forms.ComboBox WeightHostOptions;
        private System.Windows.Forms.TextBox InputWeightText;
        private System.Windows.Forms.Label OutputWeightText;
        private System.Windows.Forms.Button ChangeWeightBtn;
        private System.Windows.Forms.ComboBox LengthObjectOptions;
        private System.Windows.Forms.ComboBox LengthHostOptions;
        private System.Windows.Forms.TextBox InputLengthText;
        private System.Windows.Forms.Label OutputLengthText;
        private System.Windows.Forms.Button ChangeLengthBtn;
        private System.Windows.Forms.ComboBox CapacityObjectOptions;
        private System.Windows.Forms.ComboBox CapacityHostOptions;
        private System.Windows.Forms.TextBox InputCapacityText;
        private System.Windows.Forms.Label OutputCapacityText;
        private System.Windows.Forms.Button ChangeCapacityBtn;
    }
}