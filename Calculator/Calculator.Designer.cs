namespace Calculator
{
    partial class Calculator
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
            this.seven = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(77, 38);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(75, 23);
            this.seven.TabIndex = 0;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(158, 38);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(75, 23);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Button2_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(239, 38);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(75, 23);
            this.nine.TabIndex = 3;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Button3_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(77, 67);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(75, 23);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Button4_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(158, 67);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(75, 23);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Button5_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(239, 67);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(75, 23);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Button6_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(77, 96);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(75, 23);
            this.one.TabIndex = 7;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.Button7_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(158, 96);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(75, 23);
            this.two.TabIndex = 8;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Button8_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(239, 96);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(75, 23);
            this.three.TabIndex = 9;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Button9_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(77, 125);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Button10_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(158, 125);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(75, 23);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Button11_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dot.Location = new System.Drawing.Point(239, 125);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(75, 23);
            this.dot.TabIndex = 12;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.Button12_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(320, 38);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 23);
            this.div.TabIndex = 13;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.Button13_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(320, 67);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 23);
            this.mult.TabIndex = 14;
            this.mult.Text = "X";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.Button14_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(320, 96);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 23);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Button15_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(320, 125);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 16;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Button16_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.enter.Location = new System.Drawing.Point(158, 154);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(156, 23);
            this.enter.TabIndex = 17;
            this.enter.Text = "Enter";
            this.enter.UseVisualStyleBackColor = false;
            this.enter.Click += new System.EventHandler(this.Button17_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.seven);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button enter;
    }
}

