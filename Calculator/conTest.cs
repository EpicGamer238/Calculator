using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

namespace Calculator
{
    public partial class conTest : Form
    {
        public conTest()
        {
            InitializeComponent();
        }

        public class sequence
        {
            float total = 0;
            public int range = 50;
            public string expression;
            public int start = 1;
            public sequence(string _expression)
            {
                expression = _expression;
            }
            //Finds the sum of a given index
            public float sum(int _range)
            {
                //Total is the variable which hold the sum of the expression
                total = 0;
                //Adds the value of each index to the total
                for (int x = start; x <= _range; x++)
                {
                    total += float.Parse(new org.matheval.Expression(expression).Bind("x", x).Eval().ToString());
                }
                //returns the total + 1
                return total + 1;
            }
            //Finds whether a series is convergence using the root test
            //Finds whether a series is convergence using the root test
            public bool conTest()
            {
                org.matheval.Expression power = new org.matheval.Expression("x^(1/b)");
                org.matheval.Expression series = new org.matheval.Expression(expression);
                series.Bind("x", range);
                long seriesInt = Math.Abs(Convert.ToInt64(series.Eval()));
                power.Bind("x", seriesInt).Bind("b", range);

                return Convert.ToInt64(power.Eval()) < 1;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sequence seuquence = new sequence(textBox2.Text.ToString());
            //Dictionary<int, float> series = seuquence.sum();
            if (seuquence.conTest())
            {
                label2.Visible = true;
                label1.Text = "Convergent";
            }
            else
                label1.Text = "Divergent";

            if (Math.Round(seuquence.sum(50), 2) == Math.Round(seuquence.sum(50 + 1), 2))
                label2.Text += Math.Round(seuquence.sum(50), 2).ToString();
            else
                label2.Text += "Inconclusive";
            label1.Visible = true;
            panel1.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
