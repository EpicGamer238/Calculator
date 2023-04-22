/*HEADER
 * Author: Simon Wunderlich
 * For Units 1&2 Computing
 * Date of last edit: 22/04/2023
 * Summary: Program takes in two coordinates and finds the linear function joining them
 */

/*PSUEDOCODE
 * START
 *  DEFINE linear(NUMERICAL x1, NUMERICAL y1, NUMERICAL x2, NUMERICAL y2)
 *      NUMERICAL m <- (y1 MINUS y2) DIVIDED BY (x1 minus x2)
 *      NUMERICAL c <- y1 MINUS m MULTIPLIED BY x1
 *      TEXT formular <- "y = "
 *      formular PLUS m
 *      formular PLUS "x + "
 *      formular PLUS c
 *      DISPLAY formular
 *  DISPLAY "ENTER FIRST X COORDINATE"
 *  x1 <- INPUT
 *  DISPLAY "ENTER FIRST Y COORDINATE"
 *  y1 <- INPUT
 *  DISPLAY "ENTER SECOND X COORDINATE"
 *  x2 <- INPUT
 *  DISPLAY "ENTER SECOND Y COORDINATE"
 *  y2 <- INPUT
 *  
 *  CALL linear(x1, y1, x2, y2)
 */
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

        //Finds the gradient and y axis intercept and compiles it into the form y=mx+c
        private string linear(float x1, float y1, float x2, float y2)
        {
            //The gradient is found by dividing the difference between the ys by the difference between the xs
            float m = (y1 - y2) / (x1 - x2);

            //y axis intercept is found by rearranging the form y=mx+c to c=y-mx
            float c = y1 - (m * x1);

            //Contructs the final formular
            string formular = "y = ";

            //Check if m is not 1 or 0 and then adds 'm'x + to the function 
            //if m is 1 then x + is added
            //is m is 0 nothing is added
            if (m != 1 && m != 0)
                formular += $"{m}x + ";
            else if (m == 1)
                formular += "x + ";
            //if c isn't 0 then it is added to the end of the function
            if (c != 0)
                formular += $"{c}";
            //returns the complete formular
            return formular;
        }

        //When the GO button is pressed, the linear function is called with the given inputs and the next set of controls are shown
        private void button1_Click(object sender, EventArgs e)
        {
            //set label10s text to the formular for the linear equation that connects the two given coordinates
            label10.Text = linear(float.Parse(textBox1.Text), float.Parse(textBox2.Text), float.Parse(textBox3.Text), float.Parse(textBox4.Text));

            //Hides previous controls and shows new ones
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
        //Closes program when BACK button is pressed
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
