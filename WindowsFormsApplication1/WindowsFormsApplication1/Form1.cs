using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static double Amount(double a, double b)
        {
            return a + b;
        }
        public static double Subtraction(double a, double b)
        {
            return a - b;
        }
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
        public static double Division(double a, double b)
        {
            return a / b;
        }
        public Form1()
        {
            InitializeComponent();
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            string secondValueText = textBox2.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            double secondValue = Convert.ToDouble(secondValueText);
            double result = Amount(firstValue, secondValue);
            textBox3.Text = result.ToString();
        }
 

        private void button3_Click(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            string secondValueText = textBox2.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            double secondValue = Convert.ToDouble(secondValueText);
            double result = Multiplication(firstValue, secondValue);
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FirstValueText = textBox1.Text;
            double firstValue = Convert.ToDouble(FirstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            double result = Subtraction(firstValue, secondValue);
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string FirstValueText = textBox1.Text;
            double firstValue = Convert.ToDouble(FirstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            double result = Division(firstValue, secondValue);
            textBox3.Text = result.ToString();
        }
        */
        private void Click(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            string secondValueText = textBox2.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            double secondValue = Convert.ToDouble(secondValueText);
            double result;
       
   
            switch (((Button)sender).Name)
            {
                case "buttonAmount":
                    result = Amount(firstValue, secondValue);
                    break;
                case "buttonDifference":
                    result = Subtraction(firstValue, secondValue);
                    break;
                case "buttonMultiply":
                    result = Multiplication(firstValue, secondValue);
                    break;
                case "buttonDivision":
                    result = Division(firstValue, secondValue);
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
            textBox3.Text = result.ToString();
        }
    }
}
