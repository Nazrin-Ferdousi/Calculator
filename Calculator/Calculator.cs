using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Nazrin Ferdousi
 * Date: 21/05/2020
 * Description: This is a calculator app
 */

namespace Calculator
{
    public partial class Calculator : Form
    {
        //Variable declairations
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
           
        }

        // Start button clicks
        private void Button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";

            // check for . in input
            if (input.Contains('.'))
            {
                this.textBox1.Text = "Decimal Error";
            }
            else
            {               
                input += ".";
                this.textBox1.Text += input;
            }
            
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operand1 = input;
            operation = '/';
            input = string.Empty;
            this.textBox1.Text += input;
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operand1 = input;
            operation = '*';
            input = string.Empty;
            this.textBox1.Text += input;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operand1 = input;
            operation = '-';
            input = string.Empty;
            this.textBox1.Text += input;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            operand1 = input;
            operation = '+';
            input = string.Empty;
            this.textBox1.Text += input;
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            //Set operands and cast input to double
            operand2 = input;
            double num1;
            double num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;

                //output result to tectBox
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;

                //output result to tectBox
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                //Test for division by 0
                if (num2 != 0)
                {
                    result = num1 / num2;

                    //output result to tectBox
                    textBox1.Text = result.ToString();
                }
                else
                {
                    textBox1.Text = "Cannot divide by 0";
                }
                
            }
            else if (operation == '*')
            {
                result = num1 * num2;

                //output result to tectBox
                textBox1.Text = result.ToString();
            }
        }

        //End of button clicks
    }
}
