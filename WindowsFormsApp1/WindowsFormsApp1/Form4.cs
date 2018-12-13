using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(textBox1.Text);
            var number2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (number1 + number2).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(textBox1.Text);
            var number2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (number1 - number2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(textBox1.Text);
            var number2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (number1 * number2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var number1 = Convert.ToDouble(textBox1.Text);
            var number2 = Convert.ToDouble(textBox2.Text);
            textBox3.Text = (number1 / number2).ToString();
        }
    }
}
