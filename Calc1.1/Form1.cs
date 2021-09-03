using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1._1
{
    public partial class Form1 : Form
    {
        double numOne;
        double numTwo;
        string oP;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numOne = Convert.ToDouble(textBox1.Text);
            numTwo = Math.Sqrt(numOne);
            textBox1.Text = Convert.ToString(numTwo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numOne = Convert.ToDouble(textBox1.Text);
            numTwo = numOne * numOne;
            textBox1.Text = Convert.ToString(numTwo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oP = "^";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numOne = Convert.ToDouble(textBox1.Text);
            numTwo = 1 / numOne;
            textBox1.Text = Convert.ToString(numTwo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            numOne = 0;
            numTwo = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //divide
            numOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oP = "/";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oP = "X";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            numOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oP = "+";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            numOne = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            oP = "-";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            numOne = Convert.ToDouble(textBox1.Text);
            numTwo = 0 - numOne;
            textBox1.Text = Convert.ToString(numTwo);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0.";
            }
            else
            {
                textBox1.Text += ".";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //equals
            double answer;
            numTwo = Convert.ToDouble(textBox1.Text);

            if(oP == "+")
            {
                answer = (numOne + numTwo);
                textBox1.Text = Convert.ToString(answer);
                numOne = answer;
            }
            if(oP == "-")
            {
                answer = (numOne - numTwo);
                textBox1.Text = Convert.ToString(answer);
                numOne = answer;
            }
            if(oP == "X")
            {
                answer = (numOne * numTwo);
                textBox1.Text = Convert.ToString(answer);
                numOne = answer;
            }
            if(oP == "/")
            {
                if(numTwo == 0)
                {
                    textBox1.Text = "Unable to divide by zero";
                }
                else
                {
                    answer = (numOne / numTwo);
                    textBox1.Text = Convert.ToString(answer);
                    numOne = answer;
                }
            }
            if(oP == "^")
            {
                answer = Math.Pow(numOne,numTwo);
                textBox1.Text = Convert.ToString(answer);
                numOne = answer;
            }
        }
    }
}
