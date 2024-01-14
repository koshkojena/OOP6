using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace лабораторная_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form1_Load(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Пуск";
            button1.Click += button1_Click;
            label1.Text = "Выберите строку и нажмите пуск";
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            // Проверяем, выбрана ли строка
            if (listBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка: строка не выбрана!");
                return;
            }
            // Получаем номер выделенной строки
            int index = listBox2.SelectedIndex;
            // Считываем строку в переменную str
            string str = (string)listBox2.Items[index];
            int zeroCount = 0; // Счетчик нулей
            int oneCount = 0; // Счетчик единиц
            // Узнаем количество символов в строке
            int len = str.Length;
            // Перебор всех символов строки и подсчет количества нулей и единиц
            foreach (char c in str)
            {
                if (c == '0')
                {
                    zeroCount++;
                }
                else if (c == '1')
                {
                    oneCount++;
                }
            }
            label1.Text = "Количество единиц = " + oneCount.ToString() + ". Количество нулей =  " + zeroCount.ToString();//вывод результата
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
