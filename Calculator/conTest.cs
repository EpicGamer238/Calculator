/*HEADER
 * Author: Simon Wunderlich
 * For Units 1&2 Computing
 * Date of last edit: 20/04/2023
 * Summary: A function which takes in a single function and determines whether it is convergent using the root test. If it is convergent it will also find the pointit converges on
 */


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
            //The root test states that if f(x)^(1/x) < 1 then the function is convergent
            public bool conTest()
            {
                //Defines a root function that will find x to the nth root
                org.matheval.Expression power = new org.matheval.Expression("x^(1/n)");

                //Recieves a function to test
                org.matheval.Expression series = new org.matheval.Expression(expression);

                //Sets a highish value to x so it wont overflow
                series.Bind("x", range);
                
                //Finds the absolute value of the function when x = range
                long seriesInt = Math.Abs(Convert.ToInt64(series.Eval()));

                //Puts the result under a root of factor  range
                power.Bind("x", seriesInt).Bind("n", range);

                //return whether the result of the root function is less than 1
                return Convert.ToInt64(power.Eval()) < 1;
            }
        }

        //This function contains the logic to find the convergence and display it once a button is pressed
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Gets the function from a user input
            sequence seuquence = new sequence(textBox2.Text.ToString());

            //if function is convergent, display convergent, else display divergent
            if (seuquence.conTest())
            {
                label2.Visible = true;
                label1.Text = "Convergent";
            }
            else
                label1.Text = "Divergent";

            //If the value of the sum of the series rounded to 6 decimal places stays constant for two neighbouring indexes, then it has converged to its target value
            if (Math.Round(seuquence.sum(50), 2) == Math.Round(seuquence.sum(50 + 1), 2))
                //Rounds the target value to two decimal places
                label2.Text += Math.Round(seuquence.sum(50), 2).ToString();
            //if it doesn't reach its target value then it states that the convergence point is inconclusive
            else
                label2.Text += "Inconclusive";

            //Shows next screen controls
            label1.Visible = true;
            panel1.Visible = false;
            textBox2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
        }
        //Closes the page when the back button is pressed
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
