namespace Mesure
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configure_item = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit_item = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Connect = new System.Windows.Forms.Button();
            this.Com_connect = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveXLS = new System.Windows.Forms.Button();
            this.CreateChart = new System.Windows.Forms.Button();
            this.countValue = new System.Windows.Forms.Button();
            this.clearData = new System.Windows.Forms.Button();
            this.saveFileXLS = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SaveTXT = new System.Windows.Forms.Button();
            this.updCOM = new System.Windows.Forms.Button();
            this.ClearCurrentString = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configure_item,
            this.toolStripSeparator1,
            this.exit_item});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // configure_item
            // 
            this.configure_item.Name = "configure_item";
            this.configure_item.Size = new System.Drawing.Size(190, 22);
            this.configure_item.Text = "Конфигурация порта";
            this.configure_item.Click += new System.EventHandler(this.configure_item_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // exit_item
            // 
            this.exit_item.Name = "exit_item";
            this.exit_item.Size = new System.Drawing.Size(190, 22);
            this.exit_item.Text = "Выход";
            this.exit_item.Click += new System.EventHandler(this.exit_item_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(96, 20);
            this.about.Text = "О Программе";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updCOM);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.Com_connect);
            this.groupBox1.Location = new System.Drawing.Point(11, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбрать порт";
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Connect.Location = new System.Drawing.Point(7, 75);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(132, 43);
            this.Connect.TabIndex = 1;
            this.Connect.Text = "Подключить";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Com_connect
            // 
            this.Com_connect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Com_connect.FormattingEnabled = true;
            this.Com_connect.Location = new System.Drawing.Point(7, 19);
            this.Com_connect.Name = "Com_connect";
            this.Com_connect.Size = new System.Drawing.Size(132, 21);
            this.Com_connect.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(744, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatus.Text = "Готов";
            this.toolStripStatus.Click += new System.EventHandler(this.toolStripStatus_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 20);
            this.textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Value,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(165, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 342);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            this.Number.Width = 60;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "[Reserved Column]";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // SaveXLS
            // 
            this.SaveXLS.Location = new System.Drawing.Point(11, 184);
            this.SaveXLS.Name = "SaveXLS";
            this.SaveXLS.Size = new System.Drawing.Size(146, 43);
            this.SaveXLS.TabIndex = 1;
            this.SaveXLS.Text = "Сохранить (.xlsx)";
            this.SaveXLS.UseVisualStyleBackColor = true;
            this.SaveXLS.Click += new System.EventHandler(this.SaveXLS_Click);
            // 
            // CreateChart
            // 
            this.CreateChart.Location = new System.Drawing.Point(11, 296);
            this.CreateChart.Name = "CreateChart";
            this.CreateChart.Size = new System.Drawing.Size(146, 42);
            this.CreateChart.TabIndex = 8;
            this.CreateChart.Text = "Построить График";
            this.CreateChart.UseVisualStyleBackColor = true;
            this.CreateChart.Click += new System.EventHandler(this.CreateChart_Click);
            // 
            // countValue
            // 
            this.countValue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.countValue.Location = new System.Drawing.Point(586, 304);
            this.countValue.Name = "countValue";
            this.countValue.Size = new System.Drawing.Size(146, 42);
            this.countValue.TabIndex = 9;
            this.countValue.Text = "Считать Значение";
            this.countValue.UseVisualStyleBackColor = false;
            this.countValue.Click += new System.EventHandler(this.countValue_Click);
            // 
            // clearData
            // 
            this.clearData.Location = new System.Drawing.Point(6, 19);
            this.clearData.Name = "clearData";
            this.clearData.Size = new System.Drawing.Size(134, 42);
            this.clearData.TabIndex = 10;
            this.clearData.Text = "Очистить все";
            this.clearData.UseVisualStyleBackColor = true;
            this.clearData.Click += new System.EventHandler(this.clearData_Click);
            // 
            // saveFileXLS
            // 
            this.saveFileXLS.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileXLS_FileOk);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.time);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(585, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 114);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выборка по времени";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Старт";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(8, 40);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(130, 20);
            this.time.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время в минутах:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clearData);
            this.groupBox3.Location = new System.Drawing.Point(585, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 69);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Очистка";
            // 
            // SaveTXT
            // 
            this.SaveTXT.Location = new System.Drawing.Point(11, 233);
            this.SaveTXT.Name = "SaveTXT";
            this.SaveTXT.Size = new System.Drawing.Size(146, 43);
            this.SaveTXT.TabIndex = 15;
            this.SaveTXT.Text = "Сохранить (.txt)";
            this.SaveTXT.UseVisualStyleBackColor = true;
            // 
            // updCOM
            // 
            this.updCOM.Location = new System.Drawing.Point(7, 48);
            this.updCOM.Name = "updCOM";
            this.updCOM.Size = new System.Drawing.Size(132, 21);
            this.updCOM.TabIndex = 2;
            this.updCOM.Text = "Обновить список";
            this.updCOM.UseVisualStyleBackColor = true;
            this.updCOM.Click += new System.EventHandler(this.updCOM_Click);
            // 
            // ClearCurrentString
            // 
            this.ClearCurrentString.Location = new System.Drawing.Point(585, 256);
            this.ClearCurrentString.Name = "ClearCurrentString";
            this.ClearCurrentString.Size = new System.Drawing.Size(146, 42);
            this.ClearCurrentString.TabIndex = 13;
            this.ClearCurrentString.Text = "Пересчет значения";
            this.ClearCurrentString.UseVisualStyleBackColor = true;
            this.ClearCurrentString.Click += new System.EventHandler(this.ClearCurrentString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 442);
            this.Controls.Add(this.ClearCurrentString);
            this.Controls.Add(this.SaveTXT);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SaveXLS);
            this.Controls.Add(this.CreateChart);
            this.Controls.Add(this.countValue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mesure Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configure_item;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exit_item;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Com_connect;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveXLS;
        private System.Windows.Forms.Button CreateChart;
        private System.Windows.Forms.Button countValue;
        private System.Windows.Forms.Button clearData;
        private System.Windows.Forms.SaveFileDialog saveFileXLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SaveTXT;
        private System.Windows.Forms.Button updCOM;
        private System.Windows.Forms.Button ClearCurrentString;
    }
}

