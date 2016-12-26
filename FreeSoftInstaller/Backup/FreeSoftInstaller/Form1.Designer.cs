namespace FreeSoftInstaller
{
    partial class FreeSoftInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FreeSoftInstaller));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.prog_price = new System.Windows.Forms.Label();
            this.prog_aname = new System.Windows.Forms.Label();
            this.prog_os = new System.Windows.Forms.Label();
            this.prog_page = new System.Windows.Forms.Label();
            this.prog_lang = new System.Windows.Forms.Label();
            this.prog_reglink = new System.Windows.Forms.Label();
            this.prog_xware = new System.Windows.Forms.Label();
            this.prog_name = new System.Windows.Forms.Label();
            this.prog_list = new System.Windows.Forms.ListBox();
            this.sec_cat_list = new System.Windows.Forms.ListBox();
            this.main_cat_list = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prog_desc = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить список";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(723, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "---";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 290);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(147, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(85, 290);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(238, 6);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(138, 290);
            this.listBox3.TabIndex = 2;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.HorizontalScrollbar = true;
            this.listBox4.Location = new System.Drawing.Point(382, 6);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(371, 290);
            this.listBox4.TabIndex = 2;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            this.listBox4.DoubleClick += new System.EventHandler(this.button4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(131, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Удалить программу";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 352);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.listBox4);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.listBox3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(951, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Удаление программ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.prog_price);
            this.tabPage2.Controls.Add(this.prog_aname);
            this.tabPage2.Controls.Add(this.prog_os);
            this.tabPage2.Controls.Add(this.prog_desc);
            this.tabPage2.Controls.Add(this.prog_page);
            this.tabPage2.Controls.Add(this.prog_lang);
            this.tabPage2.Controls.Add(this.prog_reglink);
            this.tabPage2.Controls.Add(this.prog_xware);
            this.tabPage2.Controls.Add(this.prog_name);
            this.tabPage2.Controls.Add(this.prog_list);
            this.tabPage2.Controls.Add(this.sec_cat_list);
            this.tabPage2.Controls.Add(this.main_cat_list);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(951, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Установка программ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(795, 297);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Загрузить файл";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(637, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Загрузить категории";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // prog_price
            // 
            this.prog_price.AutoSize = true;
            this.prog_price.Location = new System.Drawing.Point(679, 268);
            this.prog_price.Name = "prog_price";
            this.prog_price.Size = new System.Drawing.Size(57, 13);
            this.prog_price.TabIndex = 1;
            this.prog_price.Text = "prog_price";
            // 
            // prog_aname
            // 
            this.prog_aname.AutoSize = true;
            this.prog_aname.Location = new System.Drawing.Point(637, 6);
            this.prog_aname.Name = "prog_aname";
            this.prog_aname.Size = new System.Drawing.Size(66, 13);
            this.prog_aname.TabIndex = 1;
            this.prog_aname.Text = "prog_aname";
            // 
            // prog_os
            // 
            this.prog_os.Location = new System.Drawing.Point(637, 220);
            this.prog_os.Name = "prog_os";
            this.prog_os.Size = new System.Drawing.Size(308, 35);
            this.prog_os.TabIndex = 1;
            this.prog_os.Text = "prog_os";
            // 
            // prog_page
            // 
            this.prog_page.AutoSize = true;
            this.prog_page.Location = new System.Drawing.Point(692, 176);
            this.prog_page.Name = "prog_page";
            this.prog_page.Size = new System.Drawing.Size(58, 13);
            this.prog_page.TabIndex = 1;
            this.prog_page.Text = "prog_page";
            // 
            // prog_lang
            // 
            this.prog_lang.Location = new System.Drawing.Point(637, 189);
            this.prog_lang.Name = "prog_lang";
            this.prog_lang.Size = new System.Drawing.Size(308, 31);
            this.prog_lang.TabIndex = 1;
            this.prog_lang.Text = "prog_lang";
            // 
            // prog_reglink
            // 
            this.prog_reglink.AutoSize = true;
            this.prog_reglink.Location = new System.Drawing.Point(685, 281);
            this.prog_reglink.Name = "prog_reglink";
            this.prog_reglink.Size = new System.Drawing.Size(65, 13);
            this.prog_reglink.TabIndex = 1;
            this.prog_reglink.Text = "prog_reglink";
            // 
            // prog_xware
            // 
            this.prog_xware.AutoSize = true;
            this.prog_xware.Location = new System.Drawing.Point(637, 255);
            this.prog_xware.Name = "prog_xware";
            this.prog_xware.Size = new System.Drawing.Size(62, 13);
            this.prog_xware.TabIndex = 1;
            this.prog_xware.Text = "prog_xware";
            // 
            // prog_name
            // 
            this.prog_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prog_name.Location = new System.Drawing.Point(637, 19);
            this.prog_name.Name = "prog_name";
            this.prog_name.Size = new System.Drawing.Size(311, 30);
            this.prog_name.TabIndex = 1;
            this.prog_name.Text = "prog_name";
            // 
            // prog_list
            // 
            this.prog_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prog_list.FormattingEnabled = true;
            this.prog_list.Location = new System.Drawing.Point(372, 6);
            this.prog_list.Name = "prog_list";
            this.prog_list.Size = new System.Drawing.Size(259, 316);
            this.prog_list.TabIndex = 0;
            this.prog_list.SelectedIndexChanged += new System.EventHandler(this.prog_list_SelectedIndexChanged);
            // 
            // sec_cat_list
            // 
            this.sec_cat_list.FormattingEnabled = true;
            this.sec_cat_list.Location = new System.Drawing.Point(174, 6);
            this.sec_cat_list.Name = "sec_cat_list";
            this.sec_cat_list.Size = new System.Drawing.Size(192, 316);
            this.sec_cat_list.TabIndex = 0;
            this.sec_cat_list.SelectedIndexChanged += new System.EventHandler(this.sec_cat_list_SelectedIndexChanged);
            // 
            // main_cat_list
            // 
            this.main_cat_list.FormattingEnabled = true;
            this.main_cat_list.Location = new System.Drawing.Point(6, 6);
            this.main_cat_list.Name = "main_cat_list";
            this.main_cat_list.Size = new System.Drawing.Size(162, 316);
            this.main_cat_list.TabIndex = 0;
            this.main_cat_list.SelectedIndexChanged += new System.EventHandler(this.main_cat_list_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(637, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Купить:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(637, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Страница:";
            // 
            // prog_desc
            // 
            this.prog_desc.Location = new System.Drawing.Point(637, 49);
            this.prog_desc.Name = "prog_desc";
            this.prog_desc.Size = new System.Drawing.Size(308, 127);
            this.prog_desc.TabIndex = 1;
            // 
            // FreeSoftInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 424);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FreeSoftInstaller";
            this.Text = "FreeSoft.Ru Installer 0.3";
            this.Load += new System.EventHandler(this.FreeSoftInstaller_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox prog_list;
        private System.Windows.Forms.ListBox sec_cat_list;
        private System.Windows.Forms.ListBox main_cat_list;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label prog_name;
        private System.Windows.Forms.Label prog_price;
        private System.Windows.Forms.Label prog_xware;
        private System.Windows.Forms.Label prog_aname;
        private System.Windows.Forms.Label prog_reglink;
        private System.Windows.Forms.Label prog_page;
        private System.Windows.Forms.Label prog_lang;
        private System.Windows.Forms.Label prog_os;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label prog_desc;
    }
}

