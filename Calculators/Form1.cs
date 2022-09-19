namespace Calculators
{
    public partial class Form1 : Form
    {

        List<string> list_Calculator = new List<string>();
        string calculator_Input_One = "";
        string calculator_Input_Two = "";
        bool isAtFirstInput = true;
        
        string action = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSquareRooted_Click(object sender, EventArgs e)
        {
            if(calculator_Input_One != "")
            {
                squareroot();
            }
            
        }

        private void buttonNain_Click(object sender, EventArgs e)
        {
            addNine();
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            addEight();

        }

        private void buttonSieven_Click(object sender, EventArgs e)
        {
            addSeven();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            plus();

        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            addFour();
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            addFive();
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            addSix();
        }

        private void buttonMainus_Click(object sender, EventArgs e)
        {
            minus();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            addOne();
        }


        private void buttonTwo_Click(object sender, EventArgs e)
        {
            addTwo();
        }

        private void buttonTree_Click(object sender, EventArgs e)
        {
            addThree();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            multy();
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            addZero();
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            addDecimal();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            equals();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            divi();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            root();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            calculator_Input_One = "";
            calculator_Input_Two = "";
            action = "";
            label1_Update();
        }

        private void buttonCA_Click(object sender, EventArgs e)
        {

            if (isAtFirstInput == true)
            {
                calculator_Input_One = "";
                label1_Update();
            }
            else
            {
                calculator_Input_Two = "";
            }
            label1_Update();
        }

        private void equals()
        {
            switch (action)
            {
                case "+":
                    adding();
                    break;

                case "-":
                    taking();
                    break;

                case "*":
                    multiply();
                    break;

                case "/":
                    division();
                    break;

                default:
                    label1_Update();
                    break;
            }
        }

        private void adding()
        {
            double result = Double.Parse(calculator_Input_One) + Double.Parse(calculator_Input_Two);
            label1_result(result);
        }

        private void taking()
        {
            double result = Double.Parse(calculator_Input_One) - Double.Parse(calculator_Input_Two);
            label1_result(result);
        }

        private void multiply()
        {
            double result = Double.Parse(calculator_Input_One) * Double.Parse(calculator_Input_Two);
            label1_result(result);
        }

        private void division()
        {
            double result = Double.Parse(calculator_Input_One) / Double.Parse(calculator_Input_Two);
            label1_result(result);
        }

        private void squareroot()
        {
            double result = Math.Sqrt(Double.Parse(calculator_Input_One));
            label1_result(result);
        }

        private void root ()
        {
            double result = Double.Parse(calculator_Input_One) * Double.Parse(calculator_Input_One);
            label1_result(result);
        }

        private void label1_Update()
        {
            if (isAtFirstInput == true)
            {
                label1.Text = calculator_Input_One;


            }
            else
            {
                label1.Text = calculator_Input_Two;
            }
        }

        private void label1_result(double result)
        {
            calculator_Input_One = result.ToString();
            calculator_Input_Two = "";
            action = "";
            isAtFirstInput = true;
            label1.Text = result.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            delet();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            if (isAtFirstInput == true)
            {
                if (calculator_Input_One.StartsWith("-"))
                {
                    calculator_Input_One = calculator_Input_One.Remove(0,1);
                }
                else
                {
                    calculator_Input_One = "-" + calculator_Input_One;
                }
            }
            else
            {
                if (calculator_Input_Two.StartsWith("-"))
                {
                    calculator_Input_Two = calculator_Input_Two.Remove(0,1);
                }
                else
                {
                    calculator_Input_Two = "-" + calculator_Input_Two;
                }
            }
            label1_Update();
        }

        private void delet()
        {
            if (isAtFirstInput == true && (calculator_Input_One.Length - 1) >= 0)
            {
                calculator_Input_One = calculator_Input_One.Remove(calculator_Input_One.Length - 1);
            }
            else if (isAtFirstInput == false && (calculator_Input_Two.Length - 1) >= 0)
            {
                calculator_Input_Two = calculator_Input_Two.Remove(calculator_Input_Two.Length - 1);
            }
            label1_Update();
        }

        private void plus()
        {
            if (calculator_Input_One != "" && action == "")
            {
                action = "+";
                isAtFirstInput = false;
                label1_Update();
            }
            else
            {
                equals();
            }
        }

        private void minus()
        {
            if (calculator_Input_One != "" && action == "")
            {
                isAtFirstInput = false;
                action = "-";
                label1_Update();
            }
            else
            {
                equals();
            }
        }

        private void multy()
        {
            if (calculator_Input_One != "" && action == "")
            {
                isAtFirstInput = false;
                action = "*";
                label1_Update();
            }
            else
            {
                equals();
            }
        }

        private void divi()
        {
            if (calculator_Input_One != "" && action == "")
            {
                isAtFirstInput = false;
                action = "/";
                label1_Update();
            }
            else
            {
                equals();
            }
        }


        private void addOne()
        {
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One + "1";
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two + "1";
            }
            label1_Update();
        }

        private void addTwo()
        {
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One + "2";
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two + "2";
            }
            label1_Update();
        }

        private void addThree()
        {
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One + "3";
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two + "3";
            }
            label1_Update();
        }

        private void addFour()
        {
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One + "4";
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two + "4";
            }
            label1_Update();
        }

        private void addFive()
        {
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One + "5";
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two + "5";
            }
            label1_Update();
        }

        private void addSix()
        {
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One + "6";
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two + "6";
            }
            label1_Update();
        }

        private void addSeven()
        {
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One + "7";
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two + "7";
            }
            label1_Update();
        }

        private void addEight()
        {
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One + "8";
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two + "8";
            }
            label1_Update();
        }

        private void addNine()
        {
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One + "9";
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two + "9";
            }
            label1_Update();
        }

        private void addZero()
        {
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One + "0";
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two + "0";
            }
            label1_Update();
        }

        private void addDecimal()
        {
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One + ".";
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two + ".";
            }
            label1_Update();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    addOne();
                    break;
                case Keys.NumPad2:
                    addTwo();
                    break;
                case Keys.NumPad3:
                    addThree();
                    break;
                case Keys.NumPad4:
                    addFour();
                    break;
                case Keys.NumPad5:
                    addFive();
                    break;
                case Keys.NumPad6:
                    addSix();
                    break;
                case Keys.NumPad7:
                    addSeven();
                    break;
                case Keys.NumPad8:
                    addEight();
                    break;
                case Keys.NumPad9:
                    addNine();
                    break;
                case Keys.NumPad0:
                    addZero();
                    break;
                case Keys.Decimal:
                    addDecimal();
                    break;
                case Keys.Add:
                    plus();
                    break;
                case Keys.Subtract:
                    minus();
                    break;
                case Keys.Divide:
                    divi();
                    break;
                case Keys.Multiply:
                    multy();
                    break;
                case Keys.Enter:
                    equals();
                    break;
                case Keys.Delete:
                    delet();
                    break;
            }
        }
    }
}