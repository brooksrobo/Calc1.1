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
    }
}
