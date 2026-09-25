using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculyator
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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            double num1;
            double num2;


            try
            {
                num1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("1-ci ədəd səhv daxil edilib!");
                return;
            }


            try
            {
                num2 = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("2-ci ədəd səhv daxil edilib!");
                return;
            }


            string command = comboBox1.SelectedItem?.ToString();
            double result = 0;


            if (command == "+")
            {
                result = num1 + num2;
            }
            else if (command == "-")
            {
                result = num1 - num2;
            }
            else if (command == "*")
            {
                result = num1 * num2;
            }
            else if (command == "/")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    MessageBox.Show("Sıfıra bölmək olmaz!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa bir əməliyyat (+, -, *, /) seçin!");
                return;
            }

            lblAnswer.Text = "Answer: " + result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            comboBox1.SelectedIndex = -1;

            lblAnswer.Text = "Answer: 0";
        }
    }
}