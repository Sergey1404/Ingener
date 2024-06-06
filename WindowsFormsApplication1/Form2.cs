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
    public partial class Form2 : Form
    {
        public double sum;
        private Список_компанентов a;
        public Form2()
        {
            InitializeComponent();
            string f;
            f = "modul1.txt";
            a = new Список_компанентов(f);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < kol(); i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = a.items(i).prinname();
                dataGridView1.Rows[i].Cells[1].Value = a.items(i).prinkof();
                dataGridView1.Rows[i].Cells[2].Value = a.items(i).prinpro();
                dataGridView1.Rows[i].Cells[3].Value = a.items(i).prinan();
            }
        }
        private void zap()
        {
            StreamReader file = new StreamReader("data.txt");
            string[] array;
            string str = file.ReadLine();
            array = str.Split(';');
            double z1 = Convert.ToDouble(array[0]);
            z1 = sum;
            file.Close();
            StreamWriter file2 = new StreamWriter("data.txt");
            file2.Write(z1);
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
            file2.Write(array[6]);
            file2.Write(";");
            file2.Write(array[7]);
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
        private int kol()
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


        private void button1_Click(object sender, EventArgs e)
        {
            double sumk = 0;
            for (int i = 0; i < kol(); i++)
            {
                double koff = 0;
                koff = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                if (koff != a.items(i).prinkof())
                {
                    dataGridView1.Rows[i].Cells[1].Value = koff;
                    a.items(i).kof = koff;
                }
                sumk += koff;
            }
            if (sumk > 1)
            {
                double t=0;
                t = sumk - 1;
                string d =string.Format("Сумма коэффицентов больше 1 на {0}",t);
                MessageBox.Show(d);
            }
            if (sumk < 1)
            {
                double t = 0;
                t = 1-sumk;
                string d = string.Format("Сумма коэффицентов меньше 1 на {0}", t);
                MessageBox.Show(d);
            }
            else
            {
                for (int i = 0; i < kol(); i++)
                {
                    int proo;
                    proo = 1;
                    proo = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                    if (proo != a.items(i).prinpro())
                    {
                        dataGridView1.Rows[i].Cells[2].Value = proo;
                        a.items(i).pro = proo;
                    }
                }
                for (int i = 0; i < kol(); i++)
                {
                    int ann;
                    ann = 2;
                    ann = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    if (ann != a.items(i).prinan())
                    {
                        dataGridView1.Rows[i].Cells[3].Value = ann;
                        a.items(i).an = ann;
                    }
                }
                double sum1, sum2;
                sum1 = 0;
                sum2 = 0;
                for (int i = 0; i < kol(); i++)
                {
                    sum1 += (a.items(i).kof) * (a.items(i).pro);
                }
                for (int i = 0; i < kol(); i++)
                {
                    sum2 += (a.items(i).kof) * (a.items(i).an);
                }
                sum = Math.Round((sum1 / sum2), 2);
                textBox1.Text = Convert.ToString(sum1);
                textBox2.Text = Convert.ToString(sum2);
                textBox3.Text = Convert.ToString(sum);
                zap();
            }
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Коэффициент Ак =";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 295);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 31);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(434, 292);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 292);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 31);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(584, 272);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Показатели качества";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Коэффииент весомости";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Проект";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Аналог";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(521, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Меню";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(607, 394);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Расчет КТУ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form7 form = new Form7();
            form.ShowDialog();
            Close();
        }
    }
}
