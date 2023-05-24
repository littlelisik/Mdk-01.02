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

namespace redactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpen_Click_1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox

                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы

                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.

                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
            }

            richTextBox.Clear();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox

                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы

                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.

                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываем в файл содержимое textBox с кодировкой 1251
            }

            richTextBox.Clear();
        }

        private void влевоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Left;

        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) 
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
    }
}
