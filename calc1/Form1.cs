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

        private void Calculate(object sender, EventArgs e)
        {
            string firstValue = textBox1.Text;
            string secondValue = textBox2.Text;
            double first = Convert.ToDouble(firstValue);
            double second = Convert.ToDouble(secondValue);
            double third = 0;
            switch (((Button)sender).Text)
            {
                case "+":
                    third = first + second;
                    break;
                case "-":
                    third = first - second;
                    break;
                case "*":
                    third = first * second;
                    break;
                case "/":
                    third = first / second;
                    break;
            }
            rez.Text = third.ToString();
        }
    }
}

