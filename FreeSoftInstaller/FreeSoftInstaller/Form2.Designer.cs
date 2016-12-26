namespace FreeSoftInstaller
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.prog_name_ver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filesize = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.totalsize = new System.Windows.Forms.Label();
            this.complete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 203);
            this.panel1.TabIndex = 1;
            // 
            // prog_name_ver
            // 
            this.prog_name_ver.AutoSize = true;
            this.prog_name_ver.Location = new System.Drawing.Point(12, 9);
            this.prog_name_ver.Name = "prog_name_ver";
            this.prog_name_ver.Size = new System.Drawing.Size(81, 13);
            this.prog_name_ver.TabIndex = 2;
            this.prog_name_ver.Text = "prog_name_ver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите зеркало для скачивания:";
            // 
            // filesize
            // 
            this.filesize.AutoSize = true;
            this.filesize.Location = new System.Drawing.Point(12, 22);
            this.filesize.Name = "filesize";
            this.filesize.Size = new System.Drawing.Size(49, 13);
            this.filesize.TabIndex = 3;
            this.filesize.Text = "Размер:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 287);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(344, 17);
            this.progressBar.TabIndex = 7;
            // 
            // totalsize
            // 
            this.totalsize.AutoSize = true;
            this.totalsize.Location = new System.Drawing.Point(12, 270);
            this.totalsize.Name = "totalsize";
            this.totalsize.Size = new System.Drawing.Size(45, 13);
            this.totalsize.TabIndex = 6;
            this.totalsize.Text = "totalsize";
            // 
            // complete
            // 
            this.complete.AutoSize = true;
            this.complete.Location = new System.Drawing.Point(12, 257);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(50, 13);
            this.complete.TabIndex = 5;
            this.complete.Text = "complete";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 345);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.totalsize);
            this.Controls.Add(this.filesize);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prog_name_ver);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Загрузка программы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label prog_name_ver;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label filesize;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label totalsize;
        private System.Windows.Forms.Label complete;
        public System.Windows.Forms.Button button1;
    }
}