using org.matheval;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float mainNum = 0;
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

        private void addDigit(string num)
        {
            if (newLine)
            {
                newLine = false;
                label1.Text = "";
            }
            if (prevChar != num || num != "-")
            {
                label1.Text += num;
                prevSym = false;
                prevChar = num;
            }

        }

        private void addSymbol(string sym)
        {
            if (newLine)
            {
                newLine = false;
                label1.Text = ans;
            }
            if (!prevSym)
            {
                label1.Text += sym;
                prevSym = true;
                prevChar = sym;
            }
        }

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
            if (!isDec)
            {
                addDigit(".");
                isDec = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Expression expression = new Expression(label1.Text);

            List<String> errors = expression.GetError();
            if (errors.Count > 0)
            {
                label1.Text = "ERROR";
            }
            else
            {
                label1.Text = expression.Eval().ToString();
                ans = label1.Text;
            }
            newLine = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            addSymbol("+");
            isDec = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            addDigit("-");
            isDec = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            addSymbol("*");
            isDec = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            addSymbol("/");
            isDec = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Hide();
            new Linear().ShowDialog();
            Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Hide();
            new conTest().ShowDialog();
            Show();
        }
    }
}