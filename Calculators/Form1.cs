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
        // Form Stuff - Button Presses
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //NUMBER BUTTONS
        private void buttonZero_Click(object sender, EventArgs e) //button 0
        {
            addZero();
        }

        private void buttonOne_Click(object sender, EventArgs e) //button 1
        {
            addOne();
        }

        private void buttonTwo_Click(object sender, EventArgs e) //button 2
        {
            addTwo();
        }

        private void buttonTree_Click(object sender, EventArgs e) // button 3
        {
            addThree();
        }
        private void buttonFour_Click(object sender, EventArgs e) //button 4
        {
            addFour();
        }

        private void buttonFive_Click(object sender, EventArgs e) //button 5
        {
            addFive();
        }

        private void buttonSix_Click(object sender, EventArgs e) //button 6
        {
            addSix();
        }

        private void buttonSieven_Click(object sender, EventArgs e) //button 7
        {
            addSeven();
        }

        private void buttonEight_Click(object sender, EventArgs e) //button8
        {
            addEight();

        }

        private void buttonNain_Click(object sender, EventArgs e) //button9
        {
            addNine();
        }

        //OPERATOR BUTTONS

        private void buttonPlus_Click(object sender, EventArgs e) //button +
        {
            plus();

        }

        private void buttonMainus_Click(object sender, EventArgs e) //button -
        {
            minus();
        }

        private void buttonSquareRooted_Click(object sender, EventArgs e) //square root button
        {
            if (calculator_Input_One != "")
            {
                squareroot();
            }

        }

        private void buttonMultiply_Click(object sender, EventArgs e) //button *
        {
            multy();
        }

       
        private void buttonDecimal_Click(object sender, EventArgs e) //button .
        {
            addDecimal();
        }

        private void buttonEquals_Click(object sender, EventArgs e) //button =
        {
            equals();
        }

        private void buttonDivision_Click(object sender, EventArgs e) //button /
        {
            divi();
        }

        private void buttonSquare_Click(object sender, EventArgs e) // button ^2
        {
            root();
        }

        private void buttonClear_Click(object sender, EventArgs e) //button C
        {
            calculator_Input_One = "";
            calculator_Input_Two = "";
            action = "";
            label1_Update();
        }

        private void buttonCA_Click(object sender, EventArgs e) //button CA
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

        private void buttonDelete_Click(object sender, EventArgs e) // delete button
        {
            delet();
        }



        private void buttonChangeSign_Click(object sender, EventArgs e) // change sign
        {
            if (isAtFirstInput == true)
            {
                if (calculator_Input_One.StartsWith("-"))
                {
                    calculator_Input_One = calculator_Input_One.Remove(0, 1);
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
                    calculator_Input_Two = calculator_Input_Two.Remove(0, 1);
                }
                else
                {
                    calculator_Input_Two = "-" + calculator_Input_Two;
                }
            }
            label1_Update();
        }


        // MATH 

        private void equals() // Checks what action to do
        {
            switch (action)
            {
                case "+": // addition
                    adding();
                    break;

                case "-": // subtraction
                    taking();
                    break;

                case "*": // multiplication
                    multiply();
                    break;

                case "/": // division
                    division();
                    break;

                default: // do nothing
                    label1_Update();
                    break;
            }
        }


        private void adding() // addition math
        {
            double result = Double.Parse(calculator_Input_One) + Double.Parse(calculator_Input_Two);
            label1_result(result);
        }

        private void taking() //subtraction math
        {
            double result = Double.Parse(calculator_Input_One) - Double.Parse(calculator_Input_Two);
            label1_result(result);
        }

        private void multiply() //multiplication math
        {
            double result = Double.Parse(calculator_Input_One) * Double.Parse(calculator_Input_Two);
            label1_result(result);
        }

        private void division() //division math
        {
            double result = Double.Parse(calculator_Input_One) / Double.Parse(calculator_Input_Two);
            label1_result(result);
        }

        private void squareroot() //square root math
        {
            double result = Math.Sqrt(Double.Parse(calculator_Input_One));
            label1_result(result);
        }

        private void root () // root math
        {
            double result = Double.Parse(calculator_Input_One) * Double.Parse(calculator_Input_One);
            label1_result(result);
        }

        //Label Update
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

        private void delet() // deletion
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

        private void plus() // addition
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

        private void minus() //subtraction
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

        private void multy() //multiplication
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

        private void divi() //division
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

        //Number Controls
        private void addOne() // adding one
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

        private void addTwo() // adding two
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

        private void addThree() // adding three
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

        private void addFour() // adding four
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

        private void addFive() // adding five
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

        private void addSix() // adding six
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

        private void addSeven() // adding seven
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

        private void addEight() // adding eight
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

        private void addNine() // adding nine
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

        private void addZero() // adding zero
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

        private void addDecimal() // adding decimal
        {
            if (isAtFirstInput == true && !(calculator_Input_One.Contains('.')))
            {
                if(calculator_Input_One.Length == 0)
                {
                    calculator_Input_One = calculator_Input_One + "0.";
                }
                else
                {
                    calculator_Input_One = calculator_Input_One + ".";
                }
                
            }
            else if(isAtFirstInput == false && !(calculator_Input_Two.Contains('.')))
            {
                if(calculator_Input_Two.Length == 0)
                {
                    calculator_Input_Two = calculator_Input_Two + "0.";
                }
                else
                {
                    calculator_Input_Two = calculator_Input_Two + ".";
                }
            }
            label1_Update();
        }

        private void pictureBox1_Click(object sender, EventArgs e) // don't delete breaks everything
        {

        }

        //KEYBOARD CONTROLS
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