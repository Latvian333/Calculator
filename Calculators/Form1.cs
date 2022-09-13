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

        private void buttonEight_Click(object sender, EventArgs e)
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

        private void buttonSieven_Click(object sender, EventArgs e)
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

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (calculator_Input_One != "" && action == "")
            {
                action = "+";
                isAtFirstInput = false;
                label1_Update();
            }


        }

        private void buttonFour_Click(object sender, EventArgs e)
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

        private void buttonFive_Click(object sender, EventArgs e)
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

        private void buttonSix_Click(object sender, EventArgs e)
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

        private void buttonMainus_Click(object sender, EventArgs e)
        {
            if (calculator_Input_One != "" && action == "")
            {
                isAtFirstInput = false;
                action = "-";
                label1_Update();
            }
        }

        private void buttonOne_Click(object sender, EventArgs e)
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

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One + "2";;
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two + "2";
            }
            label1_Update();
        }

        private void buttonTree_Click(object sender, EventArgs e)
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

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (calculator_Input_One != "" && action == "")
            {
                isAtFirstInput = false;
                action = "*";
                label1_Update();
            }
        }

        private void buttonZero_Click(object sender, EventArgs e)
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

        private void buttonDecimal_Click(object sender, EventArgs e)
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

        private void buttonEquals_Click(object sender, EventArgs e)
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

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (calculator_Input_One != "" && action == "")
            {
                isAtFirstInput = false;
                action = "/";
                label1_Update();
            }
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
            if (isAtFirstInput == true)
            {
                calculator_Input_One = calculator_Input_One.Remove(calculator_Input_One.Length - 1);
            }
            else
            {
                calculator_Input_Two = calculator_Input_Two.Remove(calculator_Input_Two.Length - 1);
            }
            label1_Update();
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
    }
}