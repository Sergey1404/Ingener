using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class Список_компанентов
    {
        private int n;
        private Компанента[] Kom;
        public Список_компанентов(string f) { prin(); }
        public void prin()
        {
            int i;
            n = CountFile();
            Kom = new Компанента[n];
            StreamReader file2 = new StreamReader("modul1.txt", Encoding.GetEncoding(1251));
            i = 0;
            while (!file2.EndOfStream)
            {
                Kom[i] = new Компанента(file2);
                i++;
            }
            file2.Close();
        }
        private int CountFile()
        {
            StreamReader file = new StreamReader("modul1.txt");
            int i = 0;
            while (!file.EndOfStream)
            {
                file.ReadLine();
                i++; //считает кол-во строк
            }
            file.Close();
            return i;
        }
        public int Count()
        {
            return n;
        }
        public Компанента items(int s)
        {
            return Kom[s];
        }
    }
}
