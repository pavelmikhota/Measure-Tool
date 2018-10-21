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
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
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
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.Com_connect);
            this.groupBox1.Location = new System.Drawing.Point(13, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбрать порт";
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.Color.Green;
            this.Connect.Location = new System.Drawing.Point(7, 57);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(132, 28);
            this.Connect.TabIndex = 1;
            this.Connect.Text = "Подключить";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Com_connect
            // 
            this.Com_connect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Com_connect.FormattingEnabled = true;
            this.Com_connect.Location = new System.Drawing.Point(7, 20);
            this.Com_connect.Name = "Com_connect";
            this.Com_connect.Size = new System.Drawing.Size(132, 21);
            this.Com_connect.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 383);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(591, 22);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 405);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
    }
}

