using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class Компанента
    {
        public string name;
        public double kof;
        public int pro;
        public int an;
        public string[] array;
        public Компанента(string namee, double koff, int proo, int ann) { name = namee; kof = koff; pro = proo; an = ann; }
        public Компанента(StreamReader a)
        {
            string str = a.ReadLine();
            array = str.Split(';');
            name = array[0];
            kof = Convert.ToDouble(array[1]);
            pro = Convert.ToInt32(array[2]);
            an = Convert.ToInt32(array[3]);
        }
        public string prinname() { return name; }
        public double prinkof() { return kof; }
        public int prinpro() { return pro; }
        public int prinan() { return an; }
    }
}
