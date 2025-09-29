using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double firstnumber = Convert.ToDouble(textBox1.Text);
            double secondnumber = Convert.ToDouble(textBox2.Text);
            double result = firstnumber / secondnumber;
            textBox3.Text = Convert.ToString(result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstnumber = Convert.ToDouble(textBox1.Text);
            double secondnumber = Convert.ToDouble(textBox2.Text);
            double result = firstnumber + secondnumber;
            textBox3.Text = Convert.ToString(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstnumber = Convert.ToDouble(textBox1.Text);
            double secondnumber = Convert.ToDouble(textBox2.Text);
            double result = firstnumber - secondnumber;
            textBox3.Text = Convert.ToString(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double firstnumber = Convert.ToDouble(textBox1.Text);
            double secondnumber = Convert.ToDouble(textBox2.Text);
            double result = firstnumber * secondnumber;
            textBox3.Text = Convert.ToString(result);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
