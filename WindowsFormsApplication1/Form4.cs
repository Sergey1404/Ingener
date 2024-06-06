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
    public partial class Form4 : Form
    {
        public double kap,kapa, kapp, kapr, sum1, sum2, kf, tb,p1;
        public int x1, x2, p2, p3, p4;
        public Form4()
        {
            zap1();
            InitializeComponent();
            dataGridView1.Rows.Add(2);
            dataGridView1.Rows[0].Cells[0].Value = "Руководитель";
            dataGridView1.Rows[0].Cells[1].Value = 19000;
            dataGridView1.Rows[0].Cells[2].Value = 0;
            dataGridView1.Rows[0].Cells[3].Value = x1;
            dataGridView1.Rows[1].Cells[0].Value = "Программист";
            dataGridView1.Rows[1].Cells[1].Value = 7000;
            dataGridView1.Rows[1].Cells[2].Value = 0;
            dataGridView1.Rows[1].Cells[3].Value = x2;
            dataGridView2.Rows.Add(3);
            dataGridView2.Rows[0].Cells[0].Value = "Компакт-диск CD-RW";
            dataGridView2.Rows[0].Cells[1].Value = "шт.";
            dataGridView2.Rows[0].Cells[2].Value = 2;
            dataGridView2.Rows[0].Cells[3].Value = 35;
            dataGridView2.Rows[1].Cells[0].Value = "Тонер для лазер.принтера";
            dataGridView2.Rows[1].Cells[1].Value = "шт.";
            dataGridView2.Rows[1].Cells[2].Value = 1;
            dataGridView2.Rows[1].Cells[3].Value = 1000;
            dataGridView2.Rows[2].Cells[0].Value = "Бумага офисная";
            dataGridView2.Rows[2].Cells[1].Value = "пачка";
            dataGridView2.Rows[2].Cells[2].Value = 1;
            dataGridView2.Rows[2].Cells[3].Value = 130;
            textBox3.Text = "21";
            textBox1.Text = "0,302";
            textBox11.Text = "4";
            textBox13.Text = "0,3";
            textBox14.Text = "0,1";
            textBox15.Text = "20";
            textBox4.Text = "22500";
            textBox5.Text = "1";
            textBox6.Text = "247";
            textBox7.Text = "8";
            textBox8.Text = "6";
            textBox9.Text = "247";
            model_to_view3();
            model_to_view4();
            model_to_view5();
        }
        private void zap1()
        {
            StreamReader file = new StreamReader("data.txt");
            string[] array;
            string str = file.ReadLine();
            array = str.Split(';');
            int d1 = Convert.ToInt32(array[1]);
            int d2 = Convert.ToInt32(array[2]);
            x1 =d1;
            x2 = d2;
            file.Close();
           
        }
        private void zap()
        {
            StreamReader file = new StreamReader("data.txt");
            string[] array;
            string str = file.ReadLine();
            array = str.Split(';');
            double d1 = Convert.ToDouble(array[3]);
            double d2 = Convert.ToDouble(array[4]);
            double d3 = Convert.ToDouble(array[5]);
            double p11 = Convert.ToDouble(array[8]);
            int p22 = Convert.ToInt32(array[9]);
            int p33 = Convert.ToInt32(array[10]);
            int p44 = Convert.ToInt32(array[11]);
            d1 = kapa;
            d2 = Convert.ToDouble(Math.Round(tb));
            d3 = kf;
            p11 = p1;
            p22 = p2;
            p33 = p3;
            p44 = p4;
            file.Close();
            StreamWriter file2 = new StreamWriter("data.txt");
            file2.Write(array[0]);
            file2.Write(";");
            file2.Write(array[1]);
            file2.Write(";");
            file2.Write(array[2]);
            file2.Write(";");
            file2.Write(d1);
            file2.Write(";");
            file2.Write(d2);
            file2.Write(";");
            file2.Write(d3);
            file2.Write(";");
            file2.Write(array[6]);
            file2.Write(";");
            file2.Write(array[7]);
            file2.Write(";");
            file2.Write(p11);
            file2.Write(";");
            file2.Write(p22);
            file2.Write(";");
            file2.Write(p33);
            file2.Write(";");
            file2.Write(p44);
            file2.Close();
        }
        private void model_to_view3()
        {
            dataGridView3.Rows.Add(6);
            dataGridView3.Rows[0].Cells[0].Value = "Основная заработная плата";
            dataGridView3.Rows[1].Cells[0].Value = "Дополнительная зарплата";
            dataGridView3.Rows[2].Cells[0].Value = "Отчисления на социальные нужды";
            dataGridView3.Rows[3].Cells[0].Value = "Затраты на материалы";
            dataGridView3.Rows[4].Cells[0].Value = "Затраты на машинное время";
            dataGridView3.Rows[5].Cells[0].Value = "Накладные расходы организации";
            dataGridView3.Rows[6].Cells[0].Value = "Итого";
        }
        private void model_to_view5()
        {
            dataGridView5.Rows.Add(4);
            dataGridView5.Rows[0].Cells[0].Value = "Затраты на приобретение программного продукта";
            dataGridView5.Rows[0].Cells[1].Value = 37300;
            dataGridView5.Rows[1].Cells[0].Value = "Затраты по оплате услуг на установку и сопровождение продукта";
            dataGridView5.Rows[1].Cells[1].Value = 12000;
            dataGridView5.Rows[2].Cells[0].Value = "Затраты на основное и вспомогательное оборудование";
            dataGridView5.Rows[2].Cells[1].Value = 22500;
            dataGridView5.Rows[3].Cells[0].Value = "Затраты на подготовку пользователя";
            dataGridView5.Rows[3].Cells[1].Value = 9000;
            dataGridView5.Rows[4].Cells[0].Value = "Итого";
        }
        private void model_to_view4()
        {
            dataGridView4.Rows.Add(6);
            dataGridView4.Rows[0].Cells[0].Value = "Затраты на основное и вспомогательное оборудование";
            dataGridView4.Rows[0].Cells[1].Value = 0;
            dataGridView4.Rows[1].Cells[0].Value = "Затраты на строительство, реконструкцию здания и помещений";
            dataGridView4.Rows[1].Cells[1].Value = 0;
            dataGridView4.Rows[2].Cells[0].Value = "Затраты на приобретение типовых разработок, пакетов";
            dataGridView4.Rows[2].Cells[1].Value = 0;
            dataGridView4.Rows[3].Cells[0].Value = "Затраты на прокладку линий связи";
            dataGridView4.Rows[3].Cells[1].Value = 0;
            dataGridView4.Rows[4].Cells[0].Value = "Затраты на создание информационной базы";
            dataGridView4.Rows[4].Cells[1].Value = 0;
            dataGridView4.Rows[5].Cells[0].Value = "Затраты на подготовку и переподготовку кадров";
            dataGridView4.Rows[5].Cells[1].Value = 0;
            dataGridView4.Rows[6].Cells[0].Value = "Итого";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                double summ, summ1;
                summ = 0;
                summ1 = 0;
                int d = 0;
                d = Convert.ToInt32(textBox3.Text);
                dataGridView1.Rows[0].Cells[2].Value = Math.Round(Convert.ToDouble(Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value) / d), 2);
                dataGridView1.Rows[1].Cells[2].Value = Math.Round(Convert.ToDouble(Convert.ToDouble(dataGridView1.Rows[1].Cells[1].Value) / d), 2);
                zap1();
                summ = (Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value) * x1);
                dataGridView1.Rows[0].Cells[4].Value = summ;
                summ1 = (Convert.ToDouble(dataGridView1.Rows[1].Cells[2].Value) * x2);
                dataGridView1.Rows[1].Cells[4].Value = summ1;

                sum1 = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value); ;
                }

                label1.Text = ("Итого: ") + (Convert.ToString(sum1));
            }
            else MessageBox.Show("Поле сколько рабочих дней в месяце не заполнено!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double summ;
            summ = 0;
            for (int i = 0; i < 4; i++)
            { summ += Convert.ToDouble(dataGridView5.Rows[i].Cells[1].Value); }
            dataGridView5.Rows[4].Cells[1].Value = summ;
            kapa= 0;
            kapa = summ;
            zap();
        }

        private bool prov()
        {
            if ((textBox1.Text == "") && (textBox13.Text == "") && (textBox14.Text == "") && (textBox15.Text == ""))
            {
                return false;
            }
            else
                return true;
        }
        private double pr()
        {
            if ((textBox4.Text != "") && (textBox5.Text != "") && (textBox6.Text != "") && (textBox7.Text != "") && (textBox8.Text != "")&& (textBox9.Text != ""))
            {
                p1 = Convert.ToDouble(textBox4.Text);
                p2 = Convert.ToInt32(textBox5.Text);
                p3 = Convert.ToInt32(textBox6.Text);
                p4 = Convert.ToInt32(textBox7.Text);
                double r = 0;
                r = (Convert.ToDouble(textBox4.Text) * Convert.ToInt32(textBox5.Text) * Convert.ToInt32(textBox8.Text) * Convert.ToInt32(textBox9.Text)) / (Convert.ToInt32(textBox6.Text) * Convert.ToInt32(textBox7.Text));
                return r;
            }
            else
                MessageBox.Show("Запомните все поля до таблицы");
            return 0;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView4.Rows[0].Cells[1].Value = pr();
            if (pr() != 0)
            {
                double summ = 0;
                for (int i = 0; i < 6; i++)
                { summ += Convert.ToDouble(dataGridView4.Rows[i].Cells[1].Value); }
                dataGridView4.Rows[6].Cells[1].Value = summ;
                kapr = 0;
                kapr = summ;
                textBox2.Text = Convert.ToString(Math.Round(kapr + kapp));
                tb = Convert.ToDouble(textBox2.Text);
            }
            else MessageBox.Show("Запомните все поля до таблицы");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double summ;
            summ = 0;
            for (int i = 0; i < (dataGridView2.RowCount - 1); i++, summ = 0)
            {
                summ = Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value) * Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value);
                dataGridView2.Rows[i].Cells[4].Value = summ;
            }
            sum2 = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                sum2 += Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value); ;
            }
            label2.Text = ("Итого ") + (Convert.ToString(sum2));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kapp = 0;
            zap1();
            double k1, k2, k3;
            if (prov() == true)
            {
                dataGridView3.Rows[0].Cells[1].Value = sum1;
                k1 = Convert.ToDouble(textBox13.Text);
                k2 = Convert.ToDouble(textBox14.Text);
                k3 = Convert.ToDouble(textBox1.Text);
                kf=k3;
                dataGridView3.Rows[1].Cells[1].Value = (k1 + k2) * sum1;
                dataGridView3.Rows[2].Cells[1].Value = 23475.47;
                dataGridView3.Rows[3].Cells[1].Value = sum2;
                dataGridView3.Rows[4].Cells[1].Value = x2*Convert.ToDouble(textBox11.Text) * Convert.ToDouble(textBox15.Text);
                dataGridView3.Rows[5].Cells[1].Value = sum1 * 0.6;
                double s = 0;
                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                    s += Convert.ToDouble(dataGridView3.Rows[i].Cells[1].Value); ;
                }
                dataGridView3.Rows[6].Cells[1].Value = s;
                kapp = s;
            }
            else { MessageBox.Show("Заполните все поля формы!"); }      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 form = new Form5();
            form.ShowDialog();
            Close();
        }
    }
}
