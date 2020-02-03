using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace averageCalc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal firstValue = decimal.Parse(input1.Text);
            decimal secondValue = decimal.Parse(input2.Text);
            decimal average = (firstValue + secondValue) / 2;
            label1.Text = $"Average Salary: {average:C}";
        }
    }
}
