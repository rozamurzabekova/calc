﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using calc1.twoOper;

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
            double third;
            ICalculate calculate = Calculaterfactory.CreatCalculator(((Button) sender).Name);
            third = calculate.Calculate(first, second);
            Rez.Text = third.ToString();
        }

        private void OneCalculate(object sender, EventArgs e)
        {
            string firstValue = textBox1.Text;
            double first = Convert.ToDouble(firstValue);
            double third;
            ISingleCalculator calculate = SingleFactory.CreateCalculator(((Button)sender).Name);
            third = calculate.Calculate(first);
            Rez.Text = third.ToString();
        }

        private void Sin_Click(object sender, EventArgs e)
        {

        }

        private void Rez_Click(object sender, EventArgs e)
        {

        }
    }
}

