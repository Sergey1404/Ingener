using System;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public int x1, x2;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }
        private void zap()
        {
            StreamReader file = new StreamReader("data.txt");
            string[] array;
            string str = file.ReadLine();
            array = str.Split(';');
            int d1 = Convert.ToInt32(array[1]);
            int d2 = Convert.ToInt32(array[2]);
            d1 = x1;
            d2 = x2;
            file.Close();
            StreamWriter file2 = new StreamWriter("data.txt");
            file2.Write(array[0]);
            file2.Write(";");
            file2.Write(d1);
            file2.Write(";");
            file2.Write(d2);
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
        private void button5_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if ((string)dataGridView1.Rows[i].Cells[1].Value == "Руководитель")
                {
                    if ((string)dataGridView1.Rows[i].Cells[2].Value == "0")
                    {
                        dataGridView1.Rows[i].Cells[3].Value = "-";
                        dataGridView1.Rows[i].Cells[4].Value = "-";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[3].Value = dateTimePicker4.Value.ToString("dd.MM.yyyy");
                        dataGridView1.Rows[i].Cells[4].Value = dateTimePicker2.Value.AddDays(Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value)-1).ToString("dd.MM.yyyy");
                        dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                    }
                }
                if ((string)dataGridView1.Rows[i].Cells[1].Value == "Программист")
                {
                    if ((string)dataGridView1.Rows[i].Cells[2].Value == "0")
                    {
                        dataGridView1.Rows[i].Cells[3].Value = "-";
                        dataGridView1.Rows[i].Cells[4].Value = "-";
                        dateTimePicker4.Value = dateTimePicker3.Value.AddDays(0);
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[3].Value = dateTimePicker4.Value.ToString("dd.MM.yyyy");
                        dataGridView1.Rows[i].Cells[4].Value = dateTimePicker3.Value.AddDays(Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value)-1).ToString("dd.MM.yyyy");
                        dateTimePicker3.Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value);
                        dateTimePicker4.Value = dateTimePicker3.Value.AddDays(1);
                    }
                }
                if (dateTimePicker2.Value > dateTimePicker3.Value)
                {
                    dateTimePicker3.Value = dateTimePicker2.Value;
                }
                else
                {
                    dateTimePicker2.Value = dateTimePicker4.Value;
                }
            }
            dateTimePicker2.Value = dateTimePicker1.Value;
            dateTimePicker3.Value = dateTimePicker1.Value;

            int a0 = Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value);
            int a1 = Convert.ToInt32(dataGridView1.Rows[2].Cells[2].Value);
            int a2 = Convert.ToInt32(dataGridView1.Rows[4].Cells[2].Value);
            int a3 = Convert.ToInt32(dataGridView1.Rows[6].Cells[2].Value);
            int a4 = Convert.ToInt32(dataGridView1.Rows[8].Cells[2].Value);
            int a5 = Convert.ToInt32(dataGridView1.Rows[10].Cells[2].Value);
            int a6 = Convert.ToInt32(dataGridView1.Rows[12].Cells[2].Value);
            int a7 = Convert.ToInt32(dataGridView1.Rows[14].Cells[2].Value);
            int a8 = Convert.ToInt32(dataGridView1.Rows[16].Cells[2].Value);
            int a9 = Convert.ToInt32(dataGridView1.Rows[18].Cells[2].Value);
            int a10 = Convert.ToInt32(dataGridView1.Rows[20].Cells[2].Value);
            int a17 = Convert.ToInt32(dataGridView1.Rows[22].Cells[2].Value);
            int a12 = Convert.ToInt32(dataGridView1.Rows[24].Cells[2].Value);
            int a13 = Convert.ToInt32(dataGridView1.Rows[26].Cells[2].Value);
            int a14 = Convert.ToInt32(dataGridView1.Rows[28].Cells[2].Value);
            int a15 = Convert.ToInt32(dataGridView1.Rows[30].Cells[2].Value);
            int a16 = Convert.ToInt32(dataGridView1.Rows[32].Cells[2].Value);
            x1 = a0 + a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9 + a10 + a17 + a12 + a14 + a13 + a15 + a16;
            textBox1.Text = x1.ToString();

            int a01 = Convert.ToInt32(dataGridView1.Rows[1].Cells[2].Value);
            int a11 = Convert.ToInt32(dataGridView1.Rows[3].Cells[2].Value);
            int a21 = Convert.ToInt32(dataGridView1.Rows[5].Cells[2].Value);
            int a31 = Convert.ToInt32(dataGridView1.Rows[7].Cells[2].Value);
            int a41 = Convert.ToInt32(dataGridView1.Rows[9].Cells[2].Value);
            int a51 = Convert.ToInt32(dataGridView1.Rows[11].Cells[2].Value);
            int a61 = Convert.ToInt32(dataGridView1.Rows[13].Cells[2].Value);
            int a71 = Convert.ToInt32(dataGridView1.Rows[15].Cells[2].Value);
            int a81 = Convert.ToInt32(dataGridView1.Rows[17].Cells[2].Value);
            int a91 = Convert.ToInt32(dataGridView1.Rows[19].Cells[2].Value);
            int a101 = Convert.ToInt32(dataGridView1.Rows[21].Cells[2].Value);
            int a111 = Convert.ToInt32(dataGridView1.Rows[23].Cells[2].Value);
            int a121 = Convert.ToInt32(dataGridView1.Rows[25].Cells[2].Value);
            int a131 = Convert.ToInt32(dataGridView1.Rows[27].Cells[2].Value);
            int a141 = Convert.ToInt32(dataGridView1.Rows[29].Cells[2].Value);
            int a151 = Convert.ToInt32(dataGridView1.Rows[31].Cells[2].Value);
            int a161 = Convert.ToInt32(dataGridView1.Rows[33].Cells[2].Value);
            x2 = a01 + a11 + a21 + a31 + a41 + a51 + a61 + a71 + a81 + a91 + a101 + a111 + a121 + a141 + a131 + a151 + a161;
            textBox2.Text = x2.ToString();

            int x = 0;
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            x = a + b;
            textBox3.Text = x.ToString();
            zap();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(34);
            dataGridView1.Rows[0].Cells[0].Value = "1.1.Постановка задачи";
            dataGridView1.Rows[0].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[0].Cells[2].Value = "1";
            dataGridView1.Rows[1].Cells[0].Value = "1.1.Постановка задачи";
            dataGridView1.Rows[1].Cells[1].Value = "Программист";
            dataGridView1.Rows[1].Cells[2].Value = "3";
            dataGridView1.Rows[2].Cells[0].Value = "1.2.Сбор исходных данных";
            dataGridView1.Rows[2].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[2].Cells[2].Value = "5";
            dataGridView1.Rows[3].Cells[0].Value = "1.2.Сбор исходных данных";
            dataGridView1.Rows[3].Cells[1].Value = "Программист";
            dataGridView1.Rows[3].Cells[2].Value = "14";
            dataGridView1.Rows[4].Cells[0].Value = "1.3.Анализ существующих методов решения задачи и программных средств";
            dataGridView1.Rows[4].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[4].Cells[2].Value = "0";
            dataGridView1.Rows[5].Cells[0].Value = "1.3.Анализ существующих методов решения задачи и программных средств";
            dataGridView1.Rows[5].Cells[1].Value = "Программист";
            dataGridView1.Rows[5].Cells[2].Value = "6";
            dataGridView1.Rows[6].Cells[0].Value = "1.4.Обоснование принципиальной необходимости разработки";
            dataGridView1.Rows[6].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[6].Cells[2].Value = "1";
            dataGridView1.Rows[7].Cells[0].Value = "1.4.Обоснование принципиальной необходимости разработки";
            dataGridView1.Rows[7].Cells[1].Value = "Программист";
            dataGridView1.Rows[7].Cells[2].Value = "2";
            dataGridView1.Rows[8].Cells[0].Value = "1.5.Определение и анализ требований к программе";
            dataGridView1.Rows[8].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[8].Cells[2].Value = "1";
            dataGridView1.Rows[9].Cells[0].Value = "1.5.Определение и анализ требований к программе";
            dataGridView1.Rows[9].Cells[1].Value = "Программист";
            dataGridView1.Rows[9].Cells[2].Value = "3";
            dataGridView1.Rows[10].Cells[0].Value = "1.6.Определение структуры входных и выходных данных";
            dataGridView1.Rows[10].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[10].Cells[2].Value = "1";
            dataGridView1.Rows[11].Cells[0].Value = "1.6.Определение структуры входных и выходных данных";
            dataGridView1.Rows[11].Cells[1].Value = "Программист";
            dataGridView1.Rows[11].Cells[2].Value = "5";
            dataGridView1.Rows[12].Cells[0].Value = "1.7.Выбор технических средств и программных средств реализации";
            dataGridView1.Rows[12].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[12].Cells[2].Value = "1";
            dataGridView1.Rows[13].Cells[0].Value = "1.7.Выбор технических средств и программных средств реализации";
            dataGridView1.Rows[13].Cells[1].Value = "Программист";
            dataGridView1.Rows[13].Cells[2].Value = "3";
            dataGridView1.Rows[14].Cells[0].Value = "1.8.Согласование и утверждение технического задания";
            dataGridView1.Rows[14].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[14].Cells[2].Value = "1";
            dataGridView1.Rows[15].Cells[0].Value = "1.8.Согласование и утверждение технического задания";
            dataGridView1.Rows[15].Cells[1].Value = "Программист";
            dataGridView1.Rows[15].Cells[2].Value = "3";
            dataGridView1.Rows[16].Cells[0].Value = "2.1.Проектирование программной архитектуры";
            dataGridView1.Rows[16].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[16].Cells[2].Value = "0";
            dataGridView1.Rows[17].Cells[0].Value = "2.1.Проектирование программной архитектуры";
            dataGridView1.Rows[17].Cells[1].Value = "Программист";
            dataGridView1.Rows[17].Cells[2].Value = "3";
            dataGridView1.Rows[18].Cells[0].Value = "2.2.Техническое проектирование компонентов программы";
            dataGridView1.Rows[18].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[18].Cells[2].Value = "0";
            dataGridView1.Rows[19].Cells[0].Value = "2.2.Техническое проектирование компонентов программы";
            dataGridView1.Rows[19].Cells[1].Value = "Программист";
            dataGridView1.Rows[19].Cells[2].Value = "7";
            dataGridView1.Rows[18].Cells[0].Value = "2.2.Техническое проектирование компонентов программы";
            dataGridView1.Rows[18].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[18].Cells[2].Value = "0";
            dataGridView1.Rows[19].Cells[0].Value = "2.2.Техническое проектирование компонентов программы";
            dataGridView1.Rows[19].Cells[1].Value = "Программист";
            dataGridView1.Rows[19].Cells[2].Value = "7";
            dataGridView1.Rows[20].Cells[0].Value = "3.1.Проограммирование модулей в выбранной среде программирования";
            dataGridView1.Rows[20].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[20].Cells[2].Value = "0";
            dataGridView1.Rows[21].Cells[0].Value = "3.1.Проограммирование модулей в выбранной среде программирования";
            dataGridView1.Rows[21].Cells[1].Value = "Программист";
            dataGridView1.Rows[21].Cells[2].Value = "13";
            dataGridView1.Rows[22].Cells[0].Value = "3.2.Тестирование программных модулей";
            dataGridView1.Rows[22].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[22].Cells[2].Value = "0";
            dataGridView1.Rows[23].Cells[0].Value = "3.2.Тестирование программных модулей";
            dataGridView1.Rows[23].Cells[1].Value = "Программист";
            dataGridView1.Rows[23].Cells[2].Value = "21";
            dataGridView1.Rows[24].Cells[0].Value = "3.3.Сборка и испытание программы";
            dataGridView1.Rows[24].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[24].Cells[2].Value = "2";
            dataGridView1.Rows[25].Cells[0].Value = "3.3.Сборка и испытание программы";
            dataGridView1.Rows[25].Cells[1].Value = "Программист";
            dataGridView1.Rows[25].Cells[2].Value = "5";
            dataGridView1.Rows[26].Cells[0].Value = "3.4.Анализ результатов испытаний";
            dataGridView1.Rows[26].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[26].Cells[2].Value = "1";
            dataGridView1.Rows[27].Cells[0].Value = "3.4.Анализ результатов испытаний";
            dataGridView1.Rows[27].Cells[1].Value = "Программист";
            dataGridView1.Rows[27].Cells[2].Value = "5";
            dataGridView1.Rows[28].Cells[0].Value = "4.1.Проведение расчетов показателей безопасности жизнедеятельности";
            dataGridView1.Rows[28].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[28].Cells[2].Value = "0";
            dataGridView1.Rows[29].Cells[0].Value = "4.1.Проведение расчетов показателей безопасности жизнедеятельности";
            dataGridView1.Rows[29].Cells[1].Value = "Программист";
            dataGridView1.Rows[29].Cells[2].Value = "3";
            dataGridView1.Rows[30].Cells[0].Value = "4.2.Проведение экономических расчетов";
            dataGridView1.Rows[30].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[30].Cells[2].Value = "0";
            dataGridView1.Rows[31].Cells[0].Value = "4.2.Проведение экономических расчетов";
            dataGridView1.Rows[31].Cells[1].Value = "Программист";
            dataGridView1.Rows[31].Cells[2].Value = "4";
            dataGridView1.Rows[32].Cells[0].Value = "4.3.Оформление пояснительной записки";
            dataGridView1.Rows[32].Cells[1].Value = "Руководитель";
            dataGridView1.Rows[32].Cells[2].Value = "5";
            dataGridView1.Rows[33].Cells[0].Value = "4.3.Оформление пояснительной записки";
            dataGridView1.Rows[33].Cells[1].Value = "Программист";
            dataGridView1.Rows[33].Cells[2].Value = "15";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value;
            dateTimePicker3.Value = dateTimePicker1.Value;
            dateTimePicker4.Value = dateTimePicker1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 form = new Form4();
            form.ShowDialog();
            Close();
        }
    }
}