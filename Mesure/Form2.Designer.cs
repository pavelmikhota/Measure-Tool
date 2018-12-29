namespace Mesure
{
    partial class Form2
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
            this.baudRate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submit_settings = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataBits_8 = new System.Windows.Forms.RadioButton();
            this.DataBits_7 = new System.Windows.Forms.RadioButton();
            this.DataBits_6 = new System.Windows.Forms.RadioButton();
            this.DataBits_5 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Parity_space = new System.Windows.Forms.RadioButton();
            this.Parity_mark = new System.Windows.Forms.RadioButton();
            this.Parity_even = new System.Windows.Forms.RadioButton();
            this.Parity_odd = new System.Windows.Forms.RadioButton();
            this.Parity_none = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StopBits_2 = new System.Windows.Forms.RadioButton();
            this.StopBits_1_5 = new System.Windows.Forms.RadioButton();
            this.StopBits_1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // baudRate
            // 
            this.baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRate.FormattingEnabled = true;
            this.baudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudRate.Location = new System.Drawing.Point(70, 23);
            this.baudRate.Name = "baudRate";
            this.baudRate.Size = new System.Drawing.Size(124, 21);
            this.baudRate.TabIndex = 0;
            this.baudRate.SelectedIndexChanged += new System.EventHandler(this.baudRate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Baud Rate";
            // 
            // submit_settings
            // 
            this.submit_settings.Location = new System.Drawing.Point(218, 256);
            this.submit_settings.Name = "submit_settings";
            this.submit_settings.Size = new System.Drawing.Size(158, 40);
            this.submit_settings.TabIndex = 10;
            this.submit_settings.Text = "Применить";
            this.submit_settings.UseVisualStyleBackColor = true;
            this.submit_settings.Click += new System.EventHandler(this.submit_settings_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DataBits_8);
            this.groupBox1.Controls.Add(this.DataBits_7);
            this.groupBox1.Controls.Add(this.DataBits_6);
            this.groupBox1.Controls.Add(this.DataBits_5);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Биты Данных (Data Bits)";
            // 
            // DataBits_8
            // 
            this.DataBits_8.AutoSize = true;
            this.DataBits_8.Checked = true;
            this.DataBits_8.Location = new System.Drawing.Point(6, 76);
            this.DataBits_8.Name = "DataBits_8";
            this.DataBits_8.Size = new System.Drawing.Size(31, 17);
            this.DataBits_8.TabIndex = 3;
            this.DataBits_8.TabStop = true;
            this.DataBits_8.Text = "8";
            this.DataBits_8.UseVisualStyleBackColor = true;
            // 
            // DataBits_7
            // 
            this.DataBits_7.AutoSize = true;
            this.DataBits_7.Location = new System.Drawing.Point(6, 57);
            this.DataBits_7.Name = "DataBits_7";
            this.DataBits_7.Size = new System.Drawing.Size(31, 17);
            this.DataBits_7.TabIndex = 2;
            this.DataBits_7.Text = "7";
            this.DataBits_7.UseVisualStyleBackColor = true;
            // 
            // DataBits_6
            // 
            this.DataBits_6.AutoSize = true;
            this.DataBits_6.Location = new System.Drawing.Point(6, 38);
            this.DataBits_6.Name = "DataBits_6";
            this.DataBits_6.Size = new System.Drawing.Size(31, 17);
            this.DataBits_6.TabIndex = 1;
            this.DataBits_6.Text = "6";
            this.DataBits_6.UseVisualStyleBackColor = true;
            // 
            // DataBits_5
            // 
            this.DataBits_5.AutoSize = true;
            this.DataBits_5.Location = new System.Drawing.Point(6, 19);
            this.DataBits_5.Name = "DataBits_5";
            this.DataBits_5.Size = new System.Drawing.Size(31, 17);
            this.DataBits_5.TabIndex = 0;
            this.DataBits_5.Text = "5";
            this.DataBits_5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Parity_space);
            this.groupBox2.Controls.Add(this.Parity_mark);
            this.groupBox2.Controls.Add(this.Parity_even);
            this.groupBox2.Controls.Add(this.Parity_odd);
            this.groupBox2.Controls.Add(this.Parity_none);
            this.groupBox2.Location = new System.Drawing.Point(218, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 131);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Четность (Parity)";
            // 
            // Parity_space
            // 
            this.Parity_space.AutoSize = true;
            this.Parity_space.Location = new System.Drawing.Point(6, 107);
            this.Parity_space.Name = "Parity_space";
            this.Parity_space.Size = new System.Drawing.Size(54, 17);
            this.Parity_space.TabIndex = 4;
            this.Parity_space.Text = "space";
            this.Parity_space.UseVisualStyleBackColor = true;
            // 
            // Parity_mark
            // 
            this.Parity_mark.AutoSize = true;
            this.Parity_mark.Location = new System.Drawing.Point(6, 85);
            this.Parity_mark.Name = "Parity_mark";
            this.Parity_mark.Size = new System.Drawing.Size(48, 17);
            this.Parity_mark.TabIndex = 3;
            this.Parity_mark.Text = "mark";
            this.Parity_mark.UseVisualStyleBackColor = true;
            // 
            // Parity_even
            // 
            this.Parity_even.AutoSize = true;
            this.Parity_even.Location = new System.Drawing.Point(6, 63);
            this.Parity_even.Name = "Parity_even";
            this.Parity_even.Size = new System.Drawing.Size(49, 17);
            this.Parity_even.TabIndex = 2;
            this.Parity_even.Text = "even";
            this.Parity_even.UseVisualStyleBackColor = true;
            // 
            // Parity_odd
            // 
            this.Parity_odd.AutoSize = true;
            this.Parity_odd.Location = new System.Drawing.Point(6, 41);
            this.Parity_odd.Name = "Parity_odd";
            this.Parity_odd.Size = new System.Drawing.Size(43, 17);
            this.Parity_odd.TabIndex = 1;
            this.Parity_odd.Text = "odd";
            this.Parity_odd.UseVisualStyleBackColor = true;
            // 
            // Parity_none
            // 
            this.Parity_none.AutoSize = true;
            this.Parity_none.Checked = true;
            this.Parity_none.Location = new System.Drawing.Point(6, 19);
            this.Parity_none.Name = "Parity_none";
            this.Parity_none.Size = new System.Drawing.Size(49, 17);
            this.Parity_none.TabIndex = 0;
            this.Parity_none.TabStop = true;
            this.Parity_none.Text = "none";
            this.Parity_none.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StopBits_2);
            this.groupBox3.Controls.Add(this.StopBits_1_5);
            this.groupBox3.Controls.Add(this.StopBits_1);
            this.groupBox3.Location = new System.Drawing.Point(12, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Стоповые Биты (Stop Bits)";
            // 
            // StopBits_2
            // 
            this.StopBits_2.AutoSize = true;
            this.StopBits_2.Location = new System.Drawing.Point(7, 68);
            this.StopBits_2.Name = "StopBits_2";
            this.StopBits_2.Size = new System.Drawing.Size(31, 17);
            this.StopBits_2.TabIndex = 2;
            this.StopBits_2.Text = "2";
            this.StopBits_2.UseVisualStyleBackColor = true;
            // 
            // StopBits_1_5
            // 
            this.StopBits_1_5.AutoSize = true;
            this.StopBits_1_5.Location = new System.Drawing.Point(7, 44);
            this.StopBits_1_5.Name = "StopBits_1_5";
            this.StopBits_1_5.Size = new System.Drawing.Size(40, 17);
            this.StopBits_1_5.TabIndex = 1;
            this.StopBits_1_5.Text = "1.5";
            this.StopBits_1_5.UseVisualStyleBackColor = true;
            // 
            // StopBits_1
            // 
            this.StopBits_1.AutoSize = true;
            this.StopBits_1.Checked = true;
            this.StopBits_1.Location = new System.Drawing.Point(7, 20);
            this.StopBits_1.Name = "StopBits_1";
            this.StopBits_1.Size = new System.Drawing.Size(31, 17);
            this.StopBits_1.TabIndex = 0;
            this.StopBits_1.TabStop = true;
            this.StopBits_1.Text = "1";
            this.StopBits_1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.baudRate);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(12, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 55);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Скорость в Бодах";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.numericUpDown1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 118);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Таймаут";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(80, 68);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown2.TabIndex = 5;
            this.numericUpDown2.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(80, 24);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Запись";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Чтение";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 310);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submit_settings);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form2";
            this.Text = "Конфигурация Порта";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox baudRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_settings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DataBits_8;
        private System.Windows.Forms.RadioButton DataBits_7;
        private System.Windows.Forms.RadioButton DataBits_6;
        private System.Windows.Forms.RadioButton DataBits_5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Parity_space;
        private System.Windows.Forms.RadioButton Parity_mark;
        private System.Windows.Forms.RadioButton Parity_even;
        private System.Windows.Forms.RadioButton Parity_odd;
        private System.Windows.Forms.RadioButton Parity_none;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton StopBits_2;
        private System.Windows.Forms.RadioButton StopBits_1_5;
        private System.Windows.Forms.RadioButton StopBits_1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}