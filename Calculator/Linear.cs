using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.matheval;

namespace Calculator
{
    public partial class Linear : Form
    {
        public Linear()
        {
            InitializeComponent();
        }

        private string linear(float x1, float y1, float x2, float y2)
        {
            float m = (y1 - y2) / (x1 - x2);
            float c = y1 - (m * x1);
            string formular = "y = ";
            if (m != 1 && m != 0)
                formular += $"{m}x + ";
            else if (m == 1)
                formular += "x + ";
            if (c != 0)
                formular += $"{c}";
            return formular;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = linear(float.Parse(textBox1.Text), float.Parse(textBox2.Text), float.Parse(textBox3.Text), float.Parse(textBox4.Text));
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = true;
            label10.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
