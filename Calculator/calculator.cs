namespace Calculator
{
    public partial class calculator : Form
    {
        Double result = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public calculator()
        {
            InitializeComponent();
        }

        private void BtnNumClick(object sender, EventArgs e)
        {
                if ((TxtBox.Text == "0") || (isOperationPerformed))
                    TxtBox.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                if (button.Text == ".")
                {
                    if (!TxtBox.Text.Contains("."))
                        TxtBox.Text = TxtBox.Text + button.Text;
                }
                else
                {
                    TxtBox.Text = TxtBox.Text + button.Text;
                }
           
        }

        private void operatorClick(object sender, EventArgs e)
        {
                Button button = (Button)sender;

                if (result != 0 && !isOperationPerformed)
                {
                try { 
                    EqualBtn.PerformClick();
                    operationPerformed = button.Text;
                    operationStatement.Text = result + " " + operationPerformed;
                    isOperationPerformed = true;
                }
                catch (FormatException)
                {
                    TxtBox.Text = "Enter valid number";
                }
            }
                else
                {
                    operationPerformed = button.Text;
                    result = Double.Parse(TxtBox.Text);
                    operationStatement.Text = result + " " + operationPerformed;
                    isOperationPerformed = true;
                }
           
        }

        private void CEBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "0";
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "0";
            result = 0;
            operationStatement.Text = "";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double secondOperand = Double.Parse(TxtBox.Text);
                double a = result;
                switch (operationPerformed)
                {
                    case "+":
                        TxtBox.Text = (result + secondOperand).ToString();
                        break;

                    case "-":
                        TxtBox.Text = (result - secondOperand).ToString();
                        break;

                    case "X":
                        TxtBox.Text = (result * secondOperand).ToString();
                        break;

                    case "÷":
                        if (secondOperand != 0)
                            TxtBox.Text = (result / secondOperand).ToString();
                        else
                            TxtBox.Text = "Infinity"; 
                        break;

                    case "root":
                        TxtBox.Text = Math.Sqrt(result).ToString();
                        break;

                    case "X^2":
                        TxtBox.Text = Math.Pow(result, 2).ToString();
                        break;

                    case "1/x":
                        if (result != 0)
                            TxtBox.Text = (1 / result).ToString();
                        else
                            TxtBox.Text = "Infinity"; 
                        break;

                    case "%":
                        TxtBox.Text = ((result * secondOperand) / 100).ToString();

                        break;

                    default:
                        break;
                }
            
            result = Double.Parse(TxtBox.Text);
            // operationPerformed = "";
            isOperationPerformed = false;
            operationStatement.Text = a + " " + operationPerformed + " " + secondOperand + "=";
            operationPerformed = "";
            }
            catch (Exception)
            {
                TxtBox.Text = "Error";
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Length > 0)
            {
                TxtBox.Text = TxtBox.Text.Substring(0, TxtBox.Text.Length - 1);
            }
            if (TxtBox.Text == "")
            {
                TxtBox.Text = "0";
            }
        }

        private void negPosConverter(object sender, EventArgs e)
        {
            if (Double.Parse(TxtBox.Text) > 0)
            {
                TxtBox.Text = "-" + TxtBox.Text;
            }
            else
            {
                TxtBox.Text = "+" + TxtBox.Text;
            }

        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
