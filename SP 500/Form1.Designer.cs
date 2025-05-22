namespace SP_500
{
    partial class Form1
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
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.endYearComboBox = new System.Windows.Forms.ComboBox();
            this.endMonthComboBox = new System.Windows.Forms.ComboBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.overallTextBox = new System.Windows.Forms.TextBox();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.annualTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "Select the year first"});
            this.monthComboBox.Location = new System.Drawing.Point(22, 35);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 21);
            this.monthComboBox.TabIndex = 0;
            // 
            // yearComboBox
            // 
            this.yearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(157, 35);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(65, 21);
            this.yearComboBox.TabIndex = 1;
            this.yearComboBox.SelectedIndexChanged += new System.EventHandler(this.yearComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "From year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "End year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "End month (including)";
            // 
            // endYearComboBox
            // 
            this.endYearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endYearComboBox.FormattingEnabled = true;
            this.endYearComboBox.Location = new System.Drawing.Point(157, 86);
            this.endYearComboBox.Name = "endYearComboBox";
            this.endYearComboBox.Size = new System.Drawing.Size(65, 21);
            this.endYearComboBox.TabIndex = 5;
            this.endYearComboBox.SelectedIndexChanged += new System.EventHandler(this.endYearComboBox_SelectedIndexChanged);
            // 
            // endMonthComboBox
            // 
            this.endMonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endMonthComboBox.FormattingEnabled = true;
            this.endMonthComboBox.Items.AddRange(new object[] {
            "Select the year first"});
            this.endMonthComboBox.Location = new System.Drawing.Point(22, 86);
            this.endMonthComboBox.Name = "endMonthComboBox";
            this.endMonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.endMonthComboBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(191, 295);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(81, 25);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Overall S&P 500 Return (With dividends)";
            this.label5.UseMnemonic = false;
            // 
            // overallTextBox
            // 
            this.overallTextBox.Location = new System.Drawing.Point(22, 149);
            this.overallTextBox.Name = "overallTextBox";
            this.overallTextBox.ReadOnly = true;
            this.overallTextBox.Size = new System.Drawing.Size(121, 20);
            this.overallTextBox.TabIndex = 12;
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(22, 200);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.ReadOnly = true;
            this.averageTextBox.Size = new System.Drawing.Size(121, 20);
            this.averageTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Average monthly S&P 500 Return (With dividends)";
            this.label6.UseMnemonic = false;
            // 
            // annualTextBox
            // 
            this.annualTextBox.Location = new System.Drawing.Point(22, 253);
            this.annualTextBox.Name = "annualTextBox";
            this.annualTextBox.ReadOnly = true;
            this.annualTextBox.Size = new System.Drawing.Size(121, 20);
            this.annualTextBox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Average annual S&P 500 Return (With dividends)";
            this.label7.UseMnemonic = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 335);
            this.Controls.Add(this.annualTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.overallTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.endYearComboBox);
            this.Controls.Add(this.endMonthComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearComboBox);
            this.Controls.Add(this.monthComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S&P 500";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox endYearComboBox;
        private System.Windows.Forms.ComboBox endMonthComboBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox overallTextBox;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox annualTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}

