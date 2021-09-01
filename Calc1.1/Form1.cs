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

        }

        private void button7_Click(object sender, EventArgs e)
        {

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
    }
}
