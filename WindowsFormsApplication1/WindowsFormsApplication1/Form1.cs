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
    }
}