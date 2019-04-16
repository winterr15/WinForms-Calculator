using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        double Number1;
        string Operation;

        public Form1()
        {
            InitializeComponent();
        }
                

        private void number0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text + "0";
        }

        private void number1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "1";
            else
                textBox1.Text = textBox1.Text + "1";
        }

        private void number2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "2";
            else
                textBox1.Text = textBox1.Text + "2";
        }

        private void number3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "3";
            else
                textBox1.Text = textBox1.Text + "3";
        }

        private void number4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "4";
            else
                textBox1.Text = textBox1.Text + "4";
        }

        private void number5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "5";
            else
                textBox1.Text = textBox1.Text + "5";
        }

        private void number6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "6";
            else
                textBox1.Text = textBox1.Text + "6";
        }

        private void number7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "7";
            else
                textBox1.Text = textBox1.Text + "7";
        }

        private void number8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "8";
            else
                textBox1.Text = textBox1.Text + "8";
        }

        private void number9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
                textBox1.Text = "9";
            else
                textBox1.Text = textBox1.Text + "9";         
        }

        private void clear1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void decimal1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void equals1_Click(object sender, EventArgs e)
        {
            double Number2;
            double Result;

            Number2 = Convert.ToDouble(textBox1.Text);
           
            if (Operation == "+"){
                Result = (Number1 + Number2);
                textBox1.Text = Convert.ToString(Result);
                Number1 = Result;
            }
            if (Operation == "-"){
                Result = (Number1 - Number2);
                textBox1.Text = Convert.ToString(Result);
                Number1 = Result;
            }
            if (Operation == "*"){
                Result = (Number1 * Number2);
                textBox1.Text = Convert.ToString(Result);
                Number1 = Result;
            }
            if (Operation == "/"){
                if (Number2 == 0)              
                    textBox1.Text = "Cannot divide by zero";                
                else{
                    Result = (Number1 / Number2);
                    textBox1.Text = Convert.ToString(Result);
                    Number1 = Result;
                }
            }
            if (Operation == "log"){
                Result = Math.Log(Number2);
                textBox1.Text = Convert.ToString(Result);
                Number1 = Result;
            }
            if (Operation == "sqrt"){
                Result = Math.Sqrt(Number1);
                textBox1.Text = Convert.ToString(Result);
                Number1 = Result;
            }
        }

        private void divide1_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void times1_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void minus1_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void plus1_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }
        
        private void log1_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "log";
        }

        private void sqrt1_Click(object sender, EventArgs e)
        {
            Number1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "sqrt";
        }
    }
}
