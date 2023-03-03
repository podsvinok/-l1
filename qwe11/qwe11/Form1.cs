//1.Реализовать программу - тест, в которой будет предусмотрено
//любое количество вопросов и четыре варианта ответов.
//Причем можно выбрать несколько вариантов ответов,
//или все (но нельзя ничего не выбирать). До тех пор,
//пока не выбран ни один из вариантов ответов, переход
//к следующему вопросу невозможен. Данные о вопросах
//хранятся в файле. Программа должна в конце теста
//создавать файл с выбранными вариантами ответов.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace qwe11
{
    public partial class Tester : Form
    {
        StreamReader reader;
        private string[] answers;
        private int quest, rightAnswers;
        private string rightAnswer;
        public Tester()
        {
            InitializeComponent();
            quantity.Scroll += quantity_Scroll;
        }

        private void quantity_Scroll(object sender, EventArgs e) { quantityScroll.Text = String.Format("Кол-во вопросов: {0}", quantity.Value); }
        private void quantity_Changed(object sender, EventArgs e) { accept.Enabled = true; }

        private void testchoice_Click(object sender, EventArgs e)
        {
            quantityScroll.Text = "Кол-во вопросов: 1";
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "Text files (*.txt)|*.txt",
                RestoreDirectory = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                reader = new StreamReader(openFileDialog.FileName);
                quantity.Visible = true; quantityScroll.Visible = true; quantity.Maximum = Convert.ToInt16(reader.ReadLine());
                accept.Visible = true;
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {
            question.Visible = true;
            quantity.Visible = false; quantityScroll.Visible = false;
            testchoice.Visible = false;
            accept.Visible = false;
            var1.Visible = true; var2.Visible = true; var3.Visible = true; var4.Visible = true;
            answer.Visible = true;
            answers = new string[quantity.Value];
            toquest();
        }

        private void toquest()
        {
            if (quest < quantity.Value)
            {
                question.Text = reader.ReadLine();
                var1.Text = reader.ReadLine();
                var2.Text = reader.ReadLine();
                var3.Text = reader.ReadLine();
                var4.Text = reader.ReadLine();
                rightAnswer = reader.ReadLine();
            }
        }

        private void var_Click(object sender, EventArgs e)
        {
            if (var1.Checked || var2.Checked || var3.Checked || var4.Checked) answer.Enabled = true;
            else answer.Enabled = false;
        }

        private void answer_Click(object sender, EventArgs e)
        {
            if (var1.Checked) { answers[quest] += "1"; var1.Checked = false; }
            if (var2.Checked) { answers[quest] += "2"; var2.Checked = false; }
            if (var3.Checked) { answers[quest] += "3"; var3.Checked = false; }
            if (var4.Checked) { answers[quest] += "4"; var4.Checked = false; }

            if (rightAnswer == answers[quest]) rightAnswers += 1;

            if (quest < quantity.Value - 1)
            {
                quest += 1;
                toquest();
            }
            else
            {
                MessageBox.Show("Правильных ответов: " + rightAnswers + " из " + quantity.Value);
                reader.Close();
                reader.Dispose();
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    InitialDirectory = "c:\\",
                    Filter = "Text files (*.txt)|*.txt",
                    RestoreDirectory = true
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false))
                    {
                        for (int i = 0; i < quantity.Value; i++)
                        {
                            writer.WriteLine(answers[i]);
                        }
                    }
                }
                testchoice.Visible = true;
                var1.Visible = false; var2.Visible = false; var3.Visible = false; var4.Visible = false;
                answer.Visible = false; question.Visible = false;
                rightAnswers = 0; quest = 0;
            }
        }
    }
}