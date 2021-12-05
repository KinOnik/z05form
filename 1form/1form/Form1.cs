using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = "Результат:\n";
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double h = double.Parse(textBox3.Text);
                for (double i = a; i <= b; i += h)
                    try
                    {
                        result.Text+=($"y({i:f2})={f(i):f4}\n");
                    }
                    catch
                    {
                        result.Text += ($"y({i})=error\n");
                    }
            }
            catch (Exception)
            {
                result.Text +="Неверный формат ввода данных";
                MessageBox.Show(
                      "Одно или более чисел имеет некорректное значение!",
                      "Предупреждение",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button3);
            }
        }

        double f(double x)
        {
            try
            {
                if (x == -1) throw new Exception();
                else return (3 * x + 4) / (Math.Sqrt(x * x + 2 * x + 1));
            }
            catch
            {
                throw;
            }
        }
    }
}
