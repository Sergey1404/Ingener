using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public double f, a, p, p1;
        public int p2, p3, p4;
        public Form5()
        {
            InitializeComponent();
        }
        private void zap1()
        {
            StreamReader file = new StreamReader("data.txt");
            string[] array;
            string str = file.ReadLine();
            array = str.Split(';');
            double d1 = Convert.ToDouble(array[5]);
            f = d1;
            double p11 = Convert.ToDouble(array[8]);
            p1 = p11;
            int p22 = Convert.ToInt32(array[9]);
            p2 = p22;
            int p33 = Convert.ToInt32(array[10]);
            p3 = p33;
            int p44 = Convert.ToInt32(array[11]);
            p4 = p44;
            file.Close();
        }
        private void zap()
        {
            StreamReader file = new StreamReader("data.txt");
            string[] array;
            string str = file.ReadLine();
            array = str.Split(';');
            double d1 = Convert.ToDouble(array[6]);
            double d2 = Convert.ToDouble(array[7]);
            d1 = Math.Round(p);
            d2 = Math.Round(a);
            file.Close();
            StreamWriter file2 = new StreamWriter("data.txt");
            file2.Write(array[0]);
            file2.Write(";");
            file2.Write(array[1]);
            file2.Write(";");
            file2.Write(array[2]);
            file2.Write(";");
            file2.Write(array[3]);
            file2.Write(";");
            file2.Write(array[4]);
            file2.Write(";");
            file2.Write(array[5]);
            file2.Write(";");
            file2.Write(d1);
            file2.Write(";");
            file2.Write(d2);
            file2.Write(";");
            file2.Write(array[8]);
            file2.Write(";");
            file2.Write(array[9]);
            file2.Write(";");
            file2.Write(array[10]);
            file2.Write(";");
            file2.Write(array[11]);
            file2.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            zap1();
            double t1 = Convert.ToDouble(textBox2.Text);
            double t2 = Convert.ToDouble(textBox1.Text);
            double t3 = Convert.ToDouble(textBox3.Text);
            double t4 = Convert.ToDouble(textBox4.Text);
            double t5 = Convert.ToDouble(textBox6.Text);
            double t7 = Convert.ToDouble(textBox8.Text);
            double t9 = Convert.ToDouble(textBox9.Text);
            double t10 = Convert.ToDouble(textBox14.Text);
            double t11 = Convert.ToDouble(textBox16.Text);
            double t12 = Convert.ToDouble(textBox18.Text);
            double t13 = Convert.ToDouble(textBox20.Text);
            double t14 = Convert.ToDouble(textBox22.Text);
            double t15 = Convert.ToDouble(textBox26.Text);
            double t16 = Convert.ToDouble(textBox28.Text);
            double t17 = Convert.ToDouble(textBox32.Text);
            double tp = (t1 + t3) * t13;
            double ta = (t2 + t4) * t13;
            double a1 = ((t1 * t5) + (t3 * t7)) * (1 + t9) * (1 + f);
            double a2 = ((t2 * t5) + (t4 * t7)) * (1 + t9) * (1 + f);
            double b1 = t14 * (t10 * t11 * tp) / (t12 * t13);
            double b2 = t14 * (t10 * t11 * ta) / (t12 * t13);
            double c1 = t16 * tp * t15;
            double c2 = t16 * ta * t15;
            double d1 = (t17 * t10 * tp) / (t12 * t13);
            double d2 = (t17 * t10 * ta) / (t12 * t13);
            double e1 = t10 * 0.01;
            double e2 = t10 * 0.01;
            double f1 = (a1 + b1 + c1 + d1 + e1) * 0.2;
            double f2 = (a2 + b2 + c2 + d2 + e2) * 0.2;
            dataGridView1.Rows.Add(7);
            dataGridView1.Rows[0].Cells[0].Value = "Основная и дополнительная зарплата с отчислениями";
            dataGridView1.Rows[0].Cells[1].Value = a1;
            dataGridView1.Rows[0].Cells[2].Value = a2;
            dataGridView1.Rows[1].Cells[0].Value = "Амортизационные отчисления";
            dataGridView1.Rows[1].Cells[1].Value = b1;
            dataGridView1.Rows[1].Cells[2].Value = b2;
            dataGridView1.Rows[2].Cells[0].Value = "Затраты на электроэнергию";
            dataGridView1.Rows[2].Cells[1].Value = c1;
            dataGridView1.Rows[2].Cells[2].Value = c2;
            dataGridView1.Rows[3].Cells[0].Value = "Затраты на текущий ремонт";
            dataGridView1.Rows[3].Cells[1].Value = d1;
            dataGridView1.Rows[3].Cells[2].Value = d2;
            dataGridView1.Rows[4].Cells[0].Value = "Затраты на материалы";
            dataGridView1.Rows[4].Cells[1].Value = e1;
            dataGridView1.Rows[4].Cells[2].Value = e2;
            dataGridView1.Rows[5].Cells[0].Value = "Накладные расходы";
            dataGridView1.Rows[5].Cells[1].Value = f1;
            dataGridView1.Rows[5].Cells[2].Value = f2;
            dataGridView1.Rows[6].Cells[0].Value = "Итого";
            dataGridView1.Rows[6].Cells[1].Value = Math.Round(a1 + b1 + c1 + d1 + e1 + f1);
            p = Convert.ToDouble(dataGridView1.Rows[6].Cells[1].Value);
            dataGridView1.Rows[6].Cells[2].Value = Math.Round(a2 + b2 + c2 + d2 + e2 + f2);
            a = Convert.ToDouble(dataGridView1.Rows[6].Cells[2].Value);
            zap();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 form = new Form6();
            form.ShowDialog();
            Close();
        }
    }
}
