using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FreeSoftInstaller
{
    //  ласс установленных ("на удаление") приложений
    public class installed_programs
    {
        public string name;
        public string versio;
        public string publisher;
        public string uninstall_string;
        public installed_programs(string nam, string vers, string publ, string uninst_str)
        {
            name = nam;
            versio = vers;
            publisher = publ;
            uninstall_string = uninst_str;
        }
    }
    //  ласс и список категорий новых и обновл€емых программ
    public class sections
    {
        public string name;
        public string description;
        public string id;
        public string uplevel;
        public sections(string nam, string desc, string idd, string upl)
        {
            name = nam;
            description = desc;
            id = idd;
            uplevel = upl;
        }
        public sections(string string_from_database)
        {
            string[] words = string_from_database.Split('|');
            id = words[1];
            uplevel = words[2];
            description = words[3];
            name = words[4];
        }
    }
    //  ласс программ, конструктор с загрузкой из файла
    public class programs
    {
        public string id;
        public string name;
        public string version;
        public string xware;
        public string price;
        public string reglink;
        public string aname;
        public string lang;
        public string page;
        public string os;
        private string platform;
        public string sec;
        public programs(string id1, string name1, string version1, string xware1, string price1, string reglink1, string aname1,
                string lang1, string page1, string os1, string platform1, string sec1)
        {
            id = id1;
            name = name1;
            version = version1;
            xware = xware1;
            price = price1;
            reglink = reglink1;
            aname = aname1;
            lang = lang1;
            page = page1;
            os = os1;
            platform = platform1;
            sec = sec1;
        }
        public programs(string string_from_database)
        {
            string[] words = string_from_database.Split('|');
            id = words[1];
            name = words[2];
            version = words[3];
            xware = words[4];
            price = words[5];
            reglink = words[6];
            aname = words[7];
            lang = words[8];
            page = words[9];
            os = words[10];
            platform = words[11];
            sec = words[12];

        }
    }
    //  ласс ссылок на файлы
    public class links
    {
        public string id;
        public string link;
        public string size;
        public string desc;
        public string type;
        public links(string id1, string link1, string size1, string desc1, string type1)
        {
            id = id1;
            link = link1;
            size = size1;
            desc = desc1;
            type = type1;
        }
        public links(string string_from_database)
        {
            string[] words = string_from_database.Split('|');
            id = words[1];
            link = words[2];
            size = words[3];
            desc = words[4];
            type = words[5];
        }
    }
    /*
    public class TFileEdit
    {
        public void remove_clones(string filename)
        {
            /*  ј  »—ѕќЋ№«ќ¬ј“№: 
             *             TFileEdit edit = new TFileEdit();
                           edit.remove_clones("./list/links.dat");
            
            List<string> strlist = new List<string>();
            string str;
            StreamReader sr = new StreamReader(@filename);
            while ((str = sr.ReadLine()) != null)
            {
                strlist.Add(str);
            }
            List<string> newstrlist = new List<string>();
            bool notexists;
            foreach (string s in strlist)
            {
                notexists=true;
                foreach (string s1 in newstrlist)
                {
                    if (s == s1) notexists = false;
                }
                if (notexists) newstrlist.Add(s);
            }
            sr.Close();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filename))
            {
                foreach (string line1 in newstrlist){file.WriteLine(line1);}
            }
            return;
        }
    }*/
}
