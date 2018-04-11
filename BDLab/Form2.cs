using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDLab
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mul, div, sub, add;
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            string op = this.comboBox1.SelectedItem.ToString();
            mul = Calmul(num1, num2);
            div = Caldiv(num1, num2);
            sub = Calsub(num1, num2);
            add = Caladd(num2, num1);
            if (op == "Додати")
            {

                textBox3.Text = add.ToString();
            }

            else if (op == "Відняти")
            {
                textBox3.Text = sub.ToString();
            }
            else if (op == "Поділити")
            {
                textBox3.Text = div.ToString();
            }
            else if (op == "Помножити")
            {
                textBox3.Text = mul.ToString();
            }
        }

        public static double Caladd(double a, double b)
        {
            double z = 0;
            z = a + b;
            return z;
        }
        public static double Calmul(double a, double b)
        {
            double z = 0;
            z = a * b;
            return z;
        }
        public static double Caldiv(double a, double b)
        {
            double z = 0;
            z = a / b;
            return z;
        }
        public static double Calsub(double a, double b)
        {
            double z = 0;
            z = a - b;

            return z;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
