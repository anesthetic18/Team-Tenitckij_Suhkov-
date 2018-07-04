using System;
using System.Windows.Forms;
using WindowsFormsApplication1.OneArgument;
using WindowsFormsApplication1.TwoArgument;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Click(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            string secondValueText = textBox2.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            double secondValue = Convert.ToDouble(secondValueText);
            string buttonName = ((Button)sender).Name;
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator(buttonName);
            double result = calculator.Calculate(firstValue, secondValue);
            textBox3.Text = result.ToString();
        }
        private void ClickUnary(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            string buttonName = ((Button)sender).Name;
            ICalculateOneArgument calculator = CalculateOneFactory.CreateCalculator(buttonName);
            double result = calculator.Calculate(firstValue);
            textBox3.Text = result.ToString();
        }
    }
}
