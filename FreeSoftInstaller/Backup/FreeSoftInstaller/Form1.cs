using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics; 
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.NetworkInformation; //
using Microsoft.Win32; //
// using "Class1.cs";
namespace FreeSoftInstaller
{
    public partial class FreeSoftInstaller : Form
    {
        public FreeSoftInstaller()
        {
            InitializeComponent();
        }
        // Cписок установленных ("на удаление") приложений
        List<installed_programs> inst_list = new List<installed_programs>();
        // Полный список категорий
        List<sections> sec_list = new List<sections>();
        // Список id основных категорий
        List<string> main_cat_id = new List<string>();
        // Полный список программ
        List<programs>  programs_list = new List<programs>();
        // Список программ, отображаемых сейчас
        List<programs> programs_shown = new List<programs>();
        // Список ссылок
        List<links> links_list = new List<links>();
        // Получение и вывод списка установленных программ
        public void get_installed_list()
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall");
            string[] skeys = key.GetSubKeyNames(); // Все подключи из key
            int length = skeys.Length;
            // Проход по всем подключам
            for (int i = 0; i < length; i++)
            {
                // Получаем очередной подключ
                RegistryKey appKey = key.OpenSubKey(skeys[i]);
                string name, version, publisher, uninstallstring;
                try // Пробуем получить значение DisplayName
                {
                    name = appKey.GetValue("DisplayName").ToString();
                }
                catch (Exception)
                {
                    //name = "[NONAME]";
                    // Пропускаем если нет имени
                    continue;
                }
                try // Пробуем получить значение DisplayName
                {
                    version = appKey.GetValue("DisplayVersion").ToString();
                }
                catch (Exception)
                {
                    version = "[NOVERSION]";
                }
                try // Пробуем получить значение Publisher
                {
                    publisher = appKey.GetValue("Publisher").ToString();
                }
                catch (Exception)
                {
                    publisher = "[NOPUBLISHER]";
                }
                try // Пробуем получить значение UninstallString
                {
                    uninstallstring = appKey.GetValue("UninstallString").ToString();
                }
                catch (Exception)
                {
                    uninstallstring = "[UNINSTALLSTRING]";
                }
                // Добавляем элемент в список
                inst_list.Add(new installed_programs(name, version, publisher, uninstallstring));
                appKey.Close();
            }
            key.Close();
            // Сортировка элементов в списке
            inst_list.Sort(delegate(installed_programs prog2, installed_programs prog1) { 
                return prog2.name.CompareTo(prog1.name); 
            });
            // Выводим список
            foreach (installed_programs instp in inst_list)
            {
                listBox1.Items.Add(instp.name);
                listBox2.Items.Add(instp.versio);
                listBox3.Items.Add(instp.publisher);
                listBox4.Items.Add(instp.uninstall_string);
            }
        }
        // Очистка списка установленных программ
        public void clear_installed_list()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            inst_list.Clear();
        }
        // EXIT
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Тик таймера, проверка связи с сервером
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 20000;
            try
            {
                HttpWebRequest reqFP = (HttpWebRequest)HttpWebRequest.Create("http://freesoft.ru");
                HttpWebResponse rspFP = (HttpWebResponse)reqFP.GetResponse();
                if (HttpStatusCode.OK == rspFP.StatusCode)
                {
                    // HTTP = 200 - Интернет безусловно есть!
                    rspFP.Close();
                    label1.ForeColor = Color.Blue;
                    label1.Text="Статус: Интернет доступен";
                }
                else
                {
                    // сервер вернул отрицательный ответ, возможно что инета нет
                    rspFP.Close();
                    label1.ForeColor = Color.Red;
                    label1.Text="Статус: Интернет не доступен";
                }
            }
            catch (WebException)
            {
                // Ошибка, значит интернета у нас нет. Плачем :'(
                label1.ForeColor = Color.Red;
                label1.Text="Статус: Интернет не доступен";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            get_installed_list();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        // общая прокрутка списков
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex=listBox1.SelectedIndex;
            listBox3.SelectedIndex=listBox1.SelectedIndex;
            listBox4.SelectedIndex=listBox1.SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox2.SelectedIndex;
            listBox3.SelectedIndex = listBox2.SelectedIndex;
            listBox4.SelectedIndex = listBox2.SelectedIndex;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox3.SelectedIndex;
            listBox2.SelectedIndex = listBox3.SelectedIndex;
            listBox4.SelectedIndex = listBox3.SelectedIndex;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = listBox4.SelectedIndex;
            listBox2.SelectedIndex = listBox4.SelectedIndex;
            listBox3.SelectedIndex = listBox4.SelectedIndex;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Временная переменная для адреса анинсталлера
            string uninst_temp=inst_list[listBox1.SelectedIndex].uninstall_string;
            // Все прописные - это ж винда, тут пофиг на размер букв для системы и не пофиг для работы со строками
            uninst_temp.ToLower();
            // Удаление кавычек из подстроки, если необходимо
            if (uninst_temp.Substring(0, 1) == "\"")
            {
                uninst_temp=uninst_temp.Remove(0, 1);
                if (uninst_temp.Substring(uninst_temp.IndexOf(".exe")+4,1)=="\"")
                    uninst_temp = uninst_temp.Remove(uninst_temp.IndexOf(".exe") + 4, 1);
            }
            // Делаем полную ссылку из условной, если нужно
            if ((uninst_temp.IndexOf(":") < -1) || (uninst_temp.IndexOf(":") > 5))
                uninst_temp = "c:/windows/system32/" + uninst_temp;            
            // Получаем отдельно ссылку на анинсталлер и аргументы к нему
            string arguments = uninst_temp.Substring(uninst_temp.IndexOf(".exe") + 4);
            uninst_temp = uninst_temp.Substring(0, uninst_temp.IndexOf(".exe") + 4);
            try
            {
                // Запуск программы удаления
                Process uninstall_process = Process.Start(@uninst_temp, @arguments);
                uninstall_process.WaitForExit();
                uninstall_process.Close();
                // Перезагрузка списка программ
                clear_installed_list();
                get_installed_list();
            }
            catch (Exception err)
            {
                // Вывод ошибки
                MessageBox.Show(err.Message); 
                return;
            }
        }

        // Загрузить список установленных при запуске программы
        private void FreeSoftInstaller_Load(object sender, EventArgs e)
        {
            get_installed_list();
            button2_Click_1(button2, e);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Загрузка категорий
            string strSections;
            try
            {
                // Очистка списка секций 
                sec_list.Clear();
                // Построчное считывание из файла в список категорий
                StreamReader srSections = new StreamReader("./list/sections.dat");
                while ((strSections = srSections.ReadLine()) != null)
                {
                    sec_list.Add(new sections(strSections));
                }
             }
            catch (IOException ex)
            {
                // Если файла нет
                MessageBox.Show(ex.ToString());
                return;
            }
            //Очищаем листбокс основных категорий
            main_cat_list.Items.Clear();
            main_cat_id.Clear();
            //Загружаем основные категории в листбокс
            foreach (sections section in sec_list){
                // Выбираем основные категории
                if (section.uplevel.IndexOf("0") > -1)
                {
                    main_cat_list.Items.Add(section.name);
                    main_cat_id.Add(section.id);
                }
            }
            // Загрузка программ
            string strPrograms;
            try
            {
                // Очистка списка секций 
                programs_list.Clear();
                // Построчное считывание из файла в список категорий
                StreamReader srPrograms = new StreamReader("./list/programs.dat"/*, Encoding.Default*/);
                while ((strPrograms = srPrograms.ReadLine()) != null)
                {
                    programs_list.Add(new programs(strPrograms));
                }
                int inc=1;
                for(int i=0; i<programs_list.Count; i+=inc){
                    if(inc==0)inc=1;
                    if ((programs_list[i].name == "") || (programs_list[i].name == " "))
                    {
                        programs_list.RemoveAt(i);
                        inc = 0;
                    }
                }
                
            }
            catch (IOException ex)
            {
                // Если файла нет
                MessageBox.Show(ex.ToString());
                return;
            }
            // Загрузка ссылок
            string strLinks;
            try
            {
                // Очистка списка секций 
                links_list.Clear();
                // Построчное считывание из файла в список категорий
                StreamReader srLinks = new StreamReader("./list/links.dat");
                while ((strLinks = srLinks.ReadLine()) != null)
                {
                    links_list.Add(new links(strLinks));

                }
            }
            catch (IOException ex)
            {
                // Если файла нет
                MessageBox.Show(ex.ToString());
                return;
            }
        }
        // При выборе основной категории
        private void main_cat_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            // снимаем выбор вторичной категории
            sec_cat_list.SelectedIndex = -1;
            // очищаем список вторичных категорий
            sec_cat_list.Items.Clear();
            // Добавляем пункт для программ вне категорий
            sec_cat_list.Items.Add("[Без категории]");
            // Загрузка списка вторичных категорий для выбранной основной категории
            foreach (sections section in sec_list)
            {
                if (section.uplevel.IndexOf(main_cat_id[main_cat_list.SelectedIndex]) > -1)
                {
                    sec_cat_list.Items.Add(section.name);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void sec_cat_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            prog_list.Items.Clear();
            string sec_selected="абырвалг";
            if (sec_cat_list.SelectedIndex != -1)
            {
                if (sec_cat_list.SelectedIndex == 0)
                {
                    sec_selected = main_cat_id[main_cat_list.SelectedIndex];
                }
                else
                {
                    foreach (sections sec in sec_list)
                    {
                        // FIX!!! разобраться в предыдущем случае (примерно 40 строчек выше)
                        if (sec.name == sec_cat_list.Items[sec_cat_list.SelectedIndex])
                        {
                            sec_selected = sec.id;
                        }
                    }
                }
            }
            programs_shown.Clear();
            foreach (programs pr in programs_list)
            {
                if (pr.sec == sec_selected)
                {
                    prog_list.Items.Add(pr.name);
                    programs_shown.Add(pr);
                }
            }
        }
        public string prog_selected_id;
        private void prog_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (prog_list.SelectedIndex != -1)
            {
                programs proga = programs_shown[prog_list.SelectedIndex];
                prog_aname.Text = proga.aname;
                prog_name.Text = proga.name;
                if (proga.version.Length > 1) prog_name.Text += " v." + proga.version;
                prog_xware.Text = proga.xware;
                prog_selected_id = proga.id;
                if(proga.price!="0")
                    prog_price.Text = proga.price;
                prog_lang.Text = "Язык интерфейса: " + proga.lang;
                prog_page.Text = proga.page;
                prog_os.Text = "Поддерживаемые ОС: " + proga.os;
                prog_reglink.Text = proga.reglink;
            }
            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (prog_list.SelectedIndex != -1)
            {
                programs proga = programs_shown[prog_list.SelectedIndex];
                Form2 qwe = new Form2();
                // Отображение названия программы на вызываемой форме 
                qwe.Controls["prog_name_ver"].Text = proga.name;
                if (proga.version.Length > 1) qwe.Controls["prog_name_ver"].Text += " v." + proga.version;
                // Создание списка радиокнопок
                foreach (links lnk in links_list)
                {
                    if (lnk.id == prog_selected_id)
                    {
                        int max_i;
                        switch (lnk.type)
                        {
                            case "andrey": max_i = 3; break;
                            case "ftp": max_i = 3; break;
                            default: max_i = 1; break;
                        }
                        for (int i = 1; i <= max_i; i++)
                        {
                            // Создание и настройка радиокнопки
                            qwe.radio_list.Add(new RadioButton());
                            qwe.radio_list[qwe.radio_list.Count - 1].Name = "radio" + Convert.ToString(qwe.radio_list.IndexOf(qwe.radio_list[qwe.radio_list.Count - 1]));
                            qwe.radio_list[qwe.radio_list.Count - 1].Parent = qwe.panel1;
                            qwe.radio_list[qwe.radio_list.Count - 1].Top = qwe.radio_list.IndexOf(qwe.radio_list[qwe.radio_list.Count - 1]) * 20;
                            qwe.radio_list[qwe.radio_list.Count - 1].Left = 10;
                            qwe.radio_list[qwe.radio_list.Count - 1].Width = 1000;
                            qwe.radio_list[qwe.radio_list.Count - 1].AutoSize = true;
                            qwe.radio_list[qwe.radio_list.Count - 1].Visible = true;
                            qwe.radio_list[qwe.radio_list.Count - 1].CheckedChanged += new EventHandler(qwe.radio_click);
                            // Добавление ссылки в список
                            switch (lnk.type)
                            {
                                case "andrey":
                                    qwe.radio_list[qwe.radio_list.Count - 1].Text = "Сервер freesoft/rep #" + Convert.ToString(i);
                                    qwe.links.Add("http://files" + Convert.ToString(i) + ".freesoft.ru/rep/" + Convert.ToString(prog_selected_id) + "/" + @lnk.link);
                                    break;
                                case "ftp":
                                    qwe.radio_list[qwe.radio_list.Count - 1].Text = "Сервер freesoft #" + Convert.ToString(i);
                                    qwe.links.Add("http://files" + Convert.ToString(i) + ".freesoft.ru/" + @lnk.link);
                                    break;
                                case "upload":
                                    qwe.radio_list[qwe.radio_list.Count - 1].Text = "Сервер get.freesoft (в разработке)";
                                    qwe.radio_list[qwe.radio_list.Count - 1].Enabled = false;
                                    qwe.links.Add("");
                                    break;
                                case "link":
                                    qwe.radio_list[qwe.radio_list.Count - 1].Text = "Сайт автора программы";
                                    qwe.links.Add(@lnk.link);
                                    break;
                                default:
                                    qwe.radio_list[qwe.radio_list.Count - 1].Text = "ERROR!!!";
                                    break;
                            }
                            if (lnk.desc.Length > 1) qwe.radio_list[qwe.radio_list.Count - 1].Text += " | " + @lnk.desc;
                        }
                    }
                }
                // Установка первого чекбокса
                if (qwe.radio_list.Count > 0)
                {
                    qwe.button1.Enabled = true;
                    qwe.radio_list[0].Checked = true;
                    qwe.checked_item = qwe.links[0];
                }
                else qwe.button1.Enabled = false;
                // Вызов формы
                qwe.StartPosition = FormStartPosition.CenterParent;
                qwe.ShowDialog();
            }
        }
        // THE END
    }
}