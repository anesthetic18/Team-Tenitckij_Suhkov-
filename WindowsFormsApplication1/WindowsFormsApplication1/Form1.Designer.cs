namespace WindowsFormsApplication1
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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(195, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 20);
            this.textBox3.TabIndex = 2;
            // 
            // buttonAmount
            // 
            this.buttonAmount.Location = new System.Drawing.Point(195, 85);
            this.buttonAmount.Name = "buttonAmount";
            this.buttonAmount.Size = new System.Drawing.Size(61, 23);
            this.buttonAmount.TabIndex = 3;
            this.buttonAmount.Text = "+";
            this.buttonAmount.UseVisualStyleBackColor = true;
            this.buttonAmount.Click += new System.EventHandler(this.Click);
            // 
            // buttonDifference
            // 
            this.buttonDifference.Location = new System.Drawing.Point(195, 114);
            this.buttonDifference.Name = "buttonDifference";
            this.buttonDifference.Size = new System.Drawing.Size(61, 23);
            this.buttonDifference.TabIndex = 4;
            this.buttonDifference.Text = "-";
            this.buttonDifference.UseVisualStyleBackColor = true;
            this.buttonDifference.Click += new System.EventHandler(this.Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(195, 143);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(61, 22);
            this.buttonMultiply.TabIndex = 5;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.Click);
            // 
            // buttonDivision
            // 
            this.buttonDivision.Location = new System.Drawing.Point(195, 171);
            this.buttonDivision.Name = "buttonDivision";
            this.buttonDivision.Size = new System.Drawing.Size(61, 23);
            this.buttonDivision.TabIndex = 6;
            this.buttonDivision.Text = "/";
            this.buttonDivision.UseVisualStyleBackColor = true;
            this.buttonDivision.Click += new System.EventHandler(this.Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(12, 84);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(75, 23);
            this.Square.TabIndex = 7;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(12, 114);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(75, 23);
            this.Sin.TabIndex = 8;
            this.Sin.Text = "sin(x)";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.ClickUnary);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.buttonDivision);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonDifference);
            this.Controls.Add(this.buttonAmount);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
    }
}

