using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public double f1, f2, f3, f4, f5;

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }

        public Form6()
        {
            InitializeComponent();
        }
        private void zap1()
        {
            StreamReader file = new StreamReader("data.txt");
            string[] array;
            string str = file.ReadLine();
            array = str.Split(';');
            double d1 = Convert.ToDouble(array[0]);
            f1 = d1;
            double d2 = Convert.ToDouble(array[3]);
            f2 = d2;
            double d3 = Convert.ToDouble(array[4]);
            f3 = d3;
            double d4 = Convert.ToDouble(array[6]);
            f4 = d4;
            double d5 = Convert.ToDouble(array[7]);
            f5 = d5;
            file.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            zap1();
            double a = Convert.ToDouble(textBox1.Text);
            dataGridView1.Rows.Add(4);
            dataGridView1.Rows[0].Cells[0].Value = "Себестоимость";
            dataGridView1.Rows[0].Cells[1].Value = f5;
            dataGridView1.Rows[0].Cells[2].Value = f4;
            dataGridView1.Rows[1].Cells[0].Value = "Суммарные затраты, связанные с внедрением проекта";
            dataGridView1.Rows[1].Cells[1].Value = f2;
            dataGridView1.Rows[1].Cells[2].Value = f3;
            dataGridView1.Rows[2].Cells[0].Value = "Приведенные затраты на единицу работ";
            dataGridView1.Rows[2].Cells[1].Value = f5 + a * f2;
            dataGridView1.Rows[2].Cells[2].Value = f4 + a * f3;
            dataGridView1.Rows[3].Cells[0].Value = "Экономический эффект от использования разрабатываемой системы";
            dataGridView1.Rows[3].Cells[1].Value = Convert.ToDouble(dataGridView1.Rows[2].Cells[1].Value) * f1 - Convert.ToDouble(dataGridView1.Rows[2].Cells[2].Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double date = f3/Convert.ToDouble(dataGridView1.Rows[3].Cells[1].Value);
            double koef = 1/date;
            dataGridView2.Rows.Add(5);
            dataGridView2.Rows[0].Cells[0].Value = "Затраты на разработку и внедрение проекта, руб";
            dataGridView2.Rows[0].Cells[1].Value = f3;
            dataGridView2.Rows[1].Cells[0].Value = "Общие эксплутационные затраты, руб";
            dataGridView2.Rows[1].Cells[1].Value = f4;
            dataGridView2.Rows[2].Cells[0].Value = "Экономический эффект";
            dataGridView2.Rows[2].Cells[1].Value = Convert.ToDouble(dataGridView1.Rows[2].Cells[2].Value) * f1 - Convert.ToDouble(dataGridView1.Rows[2].Cells[1].Value);
            dataGridView2.Rows[3].Cells[0].Value = "Коэффициент экономической эффективности";
            dataGridView2.Rows[3].Cells[1].Value = koef;
            dataGridView2.Rows[4].Cells[0].Value = "Срок окупаемости, лет";
            dataGridView2.Rows[4].Cells[1].Value = date;

            if (koef < Convert.ToDouble(textBox1.Text))
            {
                MessageBox.Show("Проект не эффективен.");
            }
            else
            {
                MessageBox.Show("Проект эффективен.");
            }
        }
    }
}
