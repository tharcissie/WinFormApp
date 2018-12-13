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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculator(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form4 simple = new Form4();
            simple.TopLevel = false;
            panel1.Controls.Add(simple);
            simple.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            panel1.Controls.Clear();
            Form2 simple = new Form2();
            simple.TopLevel = false;
            panel1.Controls.Add(simple);
            simple.Show();
        }

        private void names(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form3 simple = new Form3();
            simple.TopLevel = false;
            panel1.Controls.Add(simple);
            simple.Show();
        }
    }
}
