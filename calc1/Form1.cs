using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstValue = textBox1.Text;
            string secondValue = textBox2.Text;
            int first = Convert.ToInt32(firstValue);
            int second = Convert.ToInt32(secondValue);
            int third = first + second;
            rez.Text = third.ToString();

        }
    }
}
