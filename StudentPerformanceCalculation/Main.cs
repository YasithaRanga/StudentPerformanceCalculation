using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentPerformanceCalculation
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void lblModule1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtModule1.Text = "";
            txtModule2.Text = "";
            txtModule3.Text = "";
            txtModule4.Text = "";
            txtModule5.Text = "";

            lblShowAvg.Text = "";
            lblShowClass.Text = "";
            lblShowTotal.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double Module1 = double.Parse(txtModule1.Text);
            double Module2 = double.Parse(txtModule2.Text);
            double Module3 = double.Parse(txtModule3.Text);
            double Module4 = double.Parse(txtModule4.Text);
            double Module5 = double.Parse(txtModule5.Text);

            double total = Module1 + Module2 + Module3 + Module4 + Module5;
            double average = total / 5;

            lblShowTotal.Text = total.ToString();
            lblShowAvg.Text = average.ToString();

            ///Calculate Class
            if (average >= 75)
                lblShowClass.Text = "First Class Upper";
            else if (average >= 65 && average <= 74)
                lblShowClass.Text = "Second Class Upper";
            else if (average >= 55 && average <= 64)
                lblShowClass.Text = "Second Class Lower";
            else if (average >= 45 && average <= 54)
                lblShowClass.Text = "General";
            else
                lblShowClass.Text = "You are Not Progressing to the Next Semester";
        }
    }
}
