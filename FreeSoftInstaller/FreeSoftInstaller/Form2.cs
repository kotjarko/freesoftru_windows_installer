using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
namespace FreeSoftInstaller
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public List<RadioButton> radio_list = new List<RadioButton>();
        public List<string> links = new List<string>();
        public string checked_item;
        public void radio_click(object sender, EventArgs e)
        {
            foreach (RadioButton rr in radio_list)
            {
                if (rr.Checked)
                {
                    checked_item = links[radio_list.IndexOf(rr)];
                }
            }
            return;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                string download_url = checked_item;
                downloaded = Path.GetFileName(download_url);
                webClient.DownloadFileAsync(new Uri(download_url), @"./download.temp");
            }
            catch (Exception err)
            {
                // Ошибка скачивания
                MessageBox.Show(err.ToString());
            }
        }
        // Имя загруженного файла
        public string downloaded;
        // Отображение статуса загрузки
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Отображение размера файла
            totalsize.Text = "Total size: ";
            if (e.TotalBytesToReceive < 1024) totalsize.Text += e.TotalBytesToReceive + " б";
            else if (e.TotalBytesToReceive < 1048576) totalsize.Text += e.TotalBytesToReceive / 1024 + " Кб " + e.TotalBytesToReceive % 1024 + " б";
            else if (e.TotalBytesToReceive < 1073741824) totalsize.Text += e.TotalBytesToReceive / 1048576 + " Мб " + e.TotalBytesToReceive % 1048576 / 1024 + " Кб";
            else totalsize.Text += e.TotalBytesToReceive / 1073741824 + " Гб " + e.TotalBytesToReceive % 1073741824 / 1048576 + " Мб";
            // Отображение количества скачанных байт
            complete.Text = "Downloaded: (" + e.ProgressPercentage + "%) ";
            if (e.BytesReceived < 1024) complete.Text += e.BytesReceived + " б";
            else if (e.BytesReceived < 1048576) complete.Text += e.BytesReceived / 1024 + " Кб " + e.BytesReceived % 1024 + " б";
            else if (e.BytesReceived < 1073741824) complete.Text += e.BytesReceived / 1048576 + " Мб " + e.BytesReceived % 1048576 / 1024 + " Кб";
            else complete.Text += e.BytesReceived / 1073741824 + " Гб " + e.BytesReceived % 1073741824 / 1048576 + " Мб";
            // Отображение прогресса на прогрессбаре
            progressBar.Value = e.ProgressPercentage;
        }
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled) MessageBox.Show("Скачивание отменено!");
            // произошла ошибка
            if (Convert.ToString(e.Error) != "") MessageBox.Show(e.Error.Message);
            // скачивание успешно завершено
            else
            {
                try
                {
                    System.IO.File.Move(@"./download.temp", "./" + @downloaded);
                    try
                    {
                        // Запуск программы установки
                        Process install_process = Process.Start("./" + @downloaded);
                        install_process.WaitForExit();
                        install_process.Close();
                    }
                    catch (Exception err)
                    {
                        // Вывод ошибки
                        MessageBox.Show(err.Message);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}