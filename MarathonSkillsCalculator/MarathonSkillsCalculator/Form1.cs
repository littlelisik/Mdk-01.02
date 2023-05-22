using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonSkillsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void count_Click(object sender, EventArgs e)
        {

            double Weights = Convert.ToDouble(weight.Text);
            double Heights = Convert.ToDouble(height.Text);
            Heights = Heights / 100;
            double BMI = Math.Round(Weights / (Heights * Heights), 1);
        }

        private void man_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            woman.BorderStyle = BorderStyle.None;
            man.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.Gainsboro;
            woman.BackColor = Color.WhiteSmoke;
        }

        private void woman_Click(object sender, EventArgs e)
        {
            man.BorderStyle = BorderStyle.None;
            woman.BorderStyle = BorderStyle.FixedSingle;
            man.BackColor = Color.WhiteSmoke;
            woman.BackColor = Color.Gainsboro;
        }
    }
}
