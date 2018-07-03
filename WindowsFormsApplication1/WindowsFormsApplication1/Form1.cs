﻿using System;
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
        public static double sum(double a, double b)
        {
            return a + b;
        }
        public static double min(double a, double b)
        {
            return a - b;
        }
        public static double mul(double a, double b)
        {
            return a * b;
        }
        public static double del(double a, double b)
        {
            return a / b;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstValueText = textBox1.Text;
            string secondValueText = textBox2.Text;
            double firstValue = Convert.ToDouble(firstValueText);
            double secondValue = Convert.ToDouble(secondValueText);
            double result = sum(firstValue, secondValue);
            textBox3.Text = result.ToString();
        }
 

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(mul(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string FirstValueText = textBox1.Text;
            double firstValue = Convert.ToDouble(FirstValueText);
            string secondValueText = textBox2.Text;
            double secondValue = Convert.ToDouble(secondValueText);
            double result = secondValue / firstValue;
            textBox3.Text = result.ToString();

            textBox3.Text = Convert.ToString(min(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(del(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
    }
}
