﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonAmount = new System.Windows.Forms.Button();
            this.buttonDifference = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivision = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Cube = new System.Windows.Forms.Button();
            this.Tan = new System.Windows.Forms.Button();
            this.Atan = new System.Windows.Forms.Button();
            this.Fraction = new System.Windows.Forms.Button();
            this.TenExp = new System.Windows.Forms.Button();
            this.XPowerY = new System.Windows.Forms.Button();
            this.DoublAmount = new System.Windows.Forms.Button();
            this.Ctan = new System.Windows.Forms.Button();
            this.Arcsin = new System.Windows.Forms.Button();
            this.Arccos = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.doubleDifference = new System.Windows.Forms.Button();
            this.doubleMultiply = new System.Windows.Forms.Button();
            this.doubleDivision = new System.Windows.Forms.Button();
            this.amountSquare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 60);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(292, 60);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 26);
            this.textBox3.TabIndex = 2;
            // 
            // buttonAmount
            // 
            this.buttonAmount.Location = new System.Drawing.Point(292, 131);
            this.buttonAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAmount.Name = "buttonAmount";
            this.buttonAmount.Size = new System.Drawing.Size(92, 35);
            this.buttonAmount.TabIndex = 3;
            this.buttonAmount.Text = "+";
            this.buttonAmount.UseVisualStyleBackColor = true;
            this.buttonAmount.Click += new System.EventHandler(this.Click);
            // 
            // buttonDifference
            // 
            this.buttonDifference.Location = new System.Drawing.Point(292, 175);
            this.buttonDifference.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDifference.Name = "buttonDifference";
            this.buttonDifference.Size = new System.Drawing.Size(92, 35);
            this.buttonDifference.TabIndex = 4;
            this.buttonDifference.Text = "-";
            this.buttonDifference.UseVisualStyleBackColor = true;
            this.buttonDifference.Click += new System.EventHandler(this.Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(292, 220);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(92, 34);
            this.buttonMultiply.TabIndex = 5;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(292, 263);
            this.buttonDivision.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(92, 35);
            this.buttonDivision.TabIndex = 6;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(18, 129);
            this.Square.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(112, 35);
            this.Square.TabIndex = 7;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(18, 175);
            this.Sin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(112, 35);
            this.Sin.TabIndex = 8;
            this.Sin.Text = "sin(x)";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(478, 60);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(98, 37);
            this.Cos.TabIndex = 9;
            this.Cos.Text = "cos(x)";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Cube
            // 
            this.Cube.Location = new System.Drawing.Point(478, 103);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(98, 37);
            this.Cube.TabIndex = 10;
            this.Cube.Text = "x^3";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Tan
            // 
            this.Tan.Location = new System.Drawing.Point(478, 146);
            this.Tan.Name = "Tan";
            this.Tan.Size = new System.Drawing.Size(98, 37);
            this.Tan.TabIndex = 11;
            this.Tan.Text = "tan(x)";
            this.Tan.UseVisualStyleBackColor = true;
            this.Tan.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Atan
            // 
            this.Atan.Location = new System.Drawing.Point(478, 189);
            this.Atan.Name = "Atan";
            this.Atan.Size = new System.Drawing.Size(98, 37);
            this.Atan.TabIndex = 12;
            this.Atan.Text = "arctan(x)";
            this.Atan.UseVisualStyleBackColor = true;
            this.Atan.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Fraction
            // 
            this.Fraction.Location = new System.Drawing.Point(478, 232);
            this.Fraction.Name = "Fraction";
            this.Fraction.Size = new System.Drawing.Size(98, 37);
            this.Fraction.TabIndex = 13;
            this.Fraction.Text = "1/x";
            this.Fraction.UseVisualStyleBackColor = true;
            this.Fraction.Click += new System.EventHandler(this.ClickUnary);
            // 
            // TenExp
            // 
            this.TenExp.Location = new System.Drawing.Point(614, 60);
            this.TenExp.Name = "TenExp";
            this.TenExp.Size = new System.Drawing.Size(98, 37);
            this.TenExp.TabIndex = 14;
            this.TenExp.Text = "10^x";
            this.TenExp.UseVisualStyleBackColor = true;
            this.TenExp.Click += new System.EventHandler(this.ClickUnary);
            // 
            // XPowerY
            // 
            this.XPowerY.Location = new System.Drawing.Point(741, 60);
            this.XPowerY.Name = "XPowerY";
            this.XPowerY.Size = new System.Drawing.Size(98, 37);
            this.XPowerY.TabIndex = 15;
            this.XPowerY.Text = "x^y";
            this.XPowerY.UseVisualStyleBackColor = true;
            this.XPowerY.Click += new System.EventHandler(this.Click);
            // 
            // DoublAmount
            // 
            this.DoublAmount.Location = new System.Drawing.Point(862, 60);
            this.DoublAmount.Name = "DoublAmount";
            this.DoublAmount.Size = new System.Drawing.Size(98, 37);
            this.DoublAmount.TabIndex = 16;
            this.DoublAmount.Text = "2(x+y)";
            this.DoublAmount.UseVisualStyleBackColor = true;
            this.DoublAmount.Click += new System.EventHandler(this.Click);
            // 
            // Ctan
            // 
            this.Ctan.Location = new System.Drawing.Point(614, 103);
            this.Ctan.Name = "Ctan";
            this.Ctan.Size = new System.Drawing.Size(98, 37);
            this.Ctan.TabIndex = 17;
            this.Ctan.Text = "ctan(x)";
            this.Ctan.UseVisualStyleBackColor = true;
            this.Ctan.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Arcsin
            // 
            this.Arcsin.Location = new System.Drawing.Point(614, 146);
            this.Arcsin.Name = "Arcsin";
            this.Arcsin.Size = new System.Drawing.Size(98, 37);
            this.Arcsin.TabIndex = 18;
            this.Arcsin.Text = "Arcsin";
            this.Arcsin.UseVisualStyleBackColor = true;
            this.Arcsin.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Arccos
            // 
            this.Arccos.Location = new System.Drawing.Point(614, 189);
            this.Arccos.Name = "Arccos";
            this.Arccos.Size = new System.Drawing.Size(98, 37);
            this.Arccos.TabIndex = 19;
            this.Arccos.Text = "Arccos";
            this.Arccos.UseVisualStyleBackColor = true;
            this.Arccos.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(614, 232);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(98, 37);
            this.Log.TabIndex = 20;
            this.Log.Text = "Lg(x)";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.ClickUnary);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(741, 103);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(98, 37);
            this.button13.TabIndex = 21;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(741, 146);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(98, 37);
            this.button14.TabIndex = 22;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(741, 189);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(98, 37);
            this.button15.TabIndex = 23;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(741, 232);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(98, 37);
            this.button16.TabIndex = 24;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // doubleDifference
            // 
            this.doubleDifference.Location = new System.Drawing.Point(862, 103);
            this.doubleDifference.Name = "doubleDifference";
            this.doubleDifference.Size = new System.Drawing.Size(98, 37);
            this.doubleDifference.TabIndex = 25;
            this.doubleDifference.Text = "2(x-y)";
            this.doubleDifference.UseVisualStyleBackColor = true;
            this.doubleDifference.Click += new System.EventHandler(this.Click);
            // 
            // doubleMultiply
            // 
            this.doubleMultiply.Location = new System.Drawing.Point(862, 146);
            this.doubleMultiply.Name = "doubleMultiply";
            this.doubleMultiply.Size = new System.Drawing.Size(98, 37);
            this.doubleMultiply.TabIndex = 26;
            this.doubleMultiply.Text = "2(x*y)";
            this.doubleMultiply.UseVisualStyleBackColor = true;
            this.doubleMultiply.Click += new System.EventHandler(this.Click);
            // 
            // doubleDivision
            // 
            this.doubleDivision.Location = new System.Drawing.Point(862, 189);
            this.doubleDivision.Name = "doubleDivision";
            this.doubleDivision.Size = new System.Drawing.Size(98, 37);
            this.doubleDivision.TabIndex = 27;
            this.doubleDivision.Text = "2(x/y)";
            this.doubleDivision.UseVisualStyleBackColor = true;
            this.doubleDivision.Click += new System.EventHandler(this.Click);
            // 
            // amountSquare
            // 
            this.amountSquare.Location = new System.Drawing.Point(862, 232);
            this.amountSquare.Name = "amountSquare";
            this.amountSquare.Size = new System.Drawing.Size(98, 37);
            this.amountSquare.TabIndex = 28;
            this.amountSquare.Text = "x^2 + y^2";
            this.amountSquare.UseVisualStyleBackColor = true;
            this.amountSquare.Click += new System.EventHandler(this.Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "OneArgumentFunction";
            this.label1.Click += new System.EventHandler(this.ClickUnary);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(768, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "TwoArgumentFunction";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 369);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountSquare);
            this.Controls.Add(this.doubleDivision);
            this.Controls.Add(this.doubleMultiply);
            this.Controls.Add(this.doubleDifference);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Arccos);
            this.Controls.Add(this.Arcsin);
            this.Controls.Add(this.Ctan);
            this.Controls.Add(this.DoublAmount);
            this.Controls.Add(this.XPowerY);
            this.Controls.Add(this.TenExp);
            this.Controls.Add(this.Fraction);
            this.Controls.Add(this.Atan);
            this.Controls.Add(this.Tan);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDifference);
            this.Controls.Add(this.buttonAmount);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonAmount;
        private System.Windows.Forms.Button buttonDifference;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivision;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Cube;
        private System.Windows.Forms.Button Tan;
        private System.Windows.Forms.Button Atan;
        private System.Windows.Forms.Button Fraction;
        private System.Windows.Forms.Button TenExp;
        private System.Windows.Forms.Button XPowerY;
        private System.Windows.Forms.Button DoublAmount;
        private System.Windows.Forms.Button Ctan;
        private System.Windows.Forms.Button Arcsin;
        private System.Windows.Forms.Button Arccos;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button doubleDifference;
        private System.Windows.Forms.Button doubleMultiply;
        private System.Windows.Forms.Button doubleDivision;
        private System.Windows.Forms.Button amountSquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

