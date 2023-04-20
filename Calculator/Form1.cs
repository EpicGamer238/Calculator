using org.matheval;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool isDec = false;
        bool prevSym = false;
        string prevChar;
        string ans = "0";
        bool newLine = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Adds a character to the end of the current calculation
        private void addDigit(string num)
        {
            //If there is a new line, clears current calculation;
            if (newLine)
            {
                newLine = false;
                label1.Text = "";
            }
            //Check if input char and previous char are not both "-"
            if (prevChar != num || num != "-")
            {
                //adds input char to calculator and saves it as previous char
                label1.Text += num;
                prevChar = num;

                //prevSym states whether the previous character put into the calculation was an opperation
                prevSym = false;
            }

        }

        //Adds an opperation to the end of the calculation
        private void addSymbol(string sym)
        {
            //If there is a new line, apply the opperation to the previous answer
            if (newLine)
            {
                newLine = false;
            }
            //Checks if the previous character was a character
            if (!prevSym)
            {
                //adds input char to calculator and saves it as previous char
                label1.Text += sym;
                prevChar = sym;

                //Indicates that the previous character is an opperation
                prevSym = true;
            }
        }
        //Calls to add character depending on button pressed
        private void button9_Click(object sender, EventArgs e)
        {
            addDigit("1");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            addDigit("2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDigit("3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addDigit("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            addDigit("5");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addDigit("6");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addDigit("7");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addDigit("8");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addDigit("9");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addDigit("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Checks if the previous character is an opperation 
            if (!prevSym)
            {
                addDigit(".");
                prevSym = true;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            addSymbol("+");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            addDigit("-");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            addSymbol("*");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            addSymbol("/");
        }

        //Evaluates the equations when "=" button pressed
        private void button12_Click(object sender, EventArgs e)
        {
            //Inputs calculation string into an expression
            Expression expression = new Expression(label1.Text);

            //Checks if the expression returns any errors
            //If there are any errors, it will out put "ERROR"
            //Otherwise it will output the result 
            try
            {
                label1.Text = expression.Eval().ToString();
            }
            catch
            {
                label1.Text = "ERROR";
            }
            //After an error or an result, the calculator goes onto a different line
            newLine = true;
        }

        //When the button17 is pressed, open the linear form
        private void button17_Click(object sender, EventArgs e)
        {
            Hide();
            new Linear().ShowDialog();
            Show();
        }
        //When the button18 is pressed, open the convergence test form
        private void button18_Click(object sender, EventArgs e)
        {
            Hide();
            new conTest().ShowDialog();
            Show();
        }
    }
}