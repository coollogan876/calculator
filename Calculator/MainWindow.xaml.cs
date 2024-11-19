using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WindowsCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string output = "";

        double temp = 0;

        string operation = "";


        public MainWindow()
        {
            InitializeComponent();

            this.KeyDown += MainWindow_KeyDown;
        }

        private void MainWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.D1:
                case Key.NumPad1:
                    buttonOne.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D2:
                case Key.NumPad2:
                    buttonTwo.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D3:
                case Key.NumPad3:
                    buttonThree.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D4:
                case Key.NumPad4:
                    buttonFour.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D5:
                case Key.NumPad5:
                    buttonFive.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D6:
                case Key.NumPad6:
                    buttonSix.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D7:
                case Key.NumPad7:
                    buttonSeven.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D8:
                case Key.NumPad8:
                    buttonEight.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D9:
                case Key.NumPad9:
                    buttonNine.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
                case Key.D0:
                case Key.NumPad0:
                    buttonZero.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;

                case Key.Add:
                case Key.OemPlus when (Keyboard.Modifiers & ModifierKeys.Shift) != 0:
                    buttonAddition.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;

                case Key.Subtract:
                case Key.OemMinus:
                    buttonSubtraction.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;

                case Key.Multiply:
                    buttonMultiply.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;

                case Key.Divide:
                case Key.OemQuestion:
                    buttonDivision.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;

                case Key.Enter:
                    buttonEquals.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;

                case Key.Decimal:
                case Key.OemPeriod:
                    buttonDot.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;

                case Key.Back:
                    buttonClear.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;

                case Key.Escape:
                    buttonClearAll.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;

                case Key.OemPlus:
                    if ((Keyboard.Modifiers & ModifierKeys.Shift) == 0)
                        buttonEquals.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                    break;
            }
        }

        // Number Button
        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            Random random = new Random();

            if (random.Next(0, 100) < 20)
            {
                Random randomNum = new Random();
                int num = randomNum.Next(0, 10);
                output += $"{num}";
                Output.Text = output;
            }
            else
            {
                switch (name)
                {
                    case "buttonOne":
                        output += "1";
                        Output.Text = output;
                        break;

                    case "buttonTwo":
                        output += "2";
                        Output.Text = output;
                        break;

                    case "buttonThree":
                        output += "3";
                        Output.Text = output;
                        break;

                    case "buttonFour":
                        output += "4";
                        Output.Text = output;
                        break;

                    case "buttonFive":
                        output += "5";
                        Output.Text = output;
                        break;

                    case "buttonSix":
                        output += "6";
                        Output.Text = output;
                        break;

                    case "buttonSeven":
                        output += "7";
                        Output.Text = output;
                        break;

                    case "buttonEight":
                        output += "8";
                        Output.Text = output;
                        break;

                    case "buttonNine":
                        output += "9";
                        Output.Text = output;
                        break;

                    case "buttonZero":
                        output += "0";
                        Output.Text = output;
                        break;
                }
            }
        }

        // Subtraction Button
        private void buttonSubtraction_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "-";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }

        // Addition Button
        private void buttonAddition_Click(object sender, RoutedEventArgs e)
        {           
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "+";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }

        // Multiply Button
        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "*";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }

        // Division Button
        private void buttonDivision_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "/";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }

        // Sqr Button
        private void buttonSqr_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "sqr";
            }

            switch (operation)
            {
                case "sqr":
                {
                    Random random = new Random();
                    int num = 0;
                    if (random.Next(0, 2) == 0)
                    {
                        num++;
                    }
                    else
                    {
                        num--;    
                    }
                    double outputTempSqr = temp * temp + num;
                    output = outputTempSqr.ToString();
                    Output.Text = output;
                    break;
                }
            }
            PreviewOutput.Text = operation + "( " + temp + " )";
        }

        // 1/x Button
        private void buttonOneX_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "1/x";
            }

            switch (operation)
            {
                case "1/x":
                {
                    Random random = new Random();
                    int num = 0;
                    if (random.Next(0, 2) == 0)
                    {
                        num++;
                    }
                    else
                    {
                        num--;
                    }
                    double outputTempSqr = (1) / temp + num;
                    output = outputTempSqr.ToString();
                    Output.Text = output;
                    break;
                }
            }
            PreviewOutput.Text = "1/" + "( " +temp + " )";
        }

        // Equals Button
        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(output))
                output = temp.ToString();

            PreviewOutput.Text = (temp.ToString() + " " + operation + " " + double.Parse(output) + " " + "=");
            Random random = new Random();
            int num;
            if (random.Next(0, 2) == 0)
            {
                num = 1;
            }
            else
            {
                num = -1;
            }

            switch (operation)
            {
                case "-":
                    double outputTempSub = temp - double.Parse(output) + num;
                    output = outputTempSub.ToString();
                    Output.Text = output;
                    break;

                case "+":
                    double outputTempAdd = temp + double.Parse(output) + num;
                    output = outputTempAdd.ToString();
                    Output.Text = output;
                    break;

                case "*":
                    double outputTempMul = temp * double.Parse(output) + num;
                    output = outputTempMul.ToString();
                    Output.Text = output;
                    break;
                    
                case "/":                   
                    double outputTempDiv = temp / double.Parse(output) + num;
                    output = outputTempDiv.ToString();
                    Output.Text = output;                                       
                    break;

                case "%":
                    double outputTempPer = (temp * double.Parse(output)) / 100 + num;
                    output = outputTempPer.ToString();
                    Output.Text = output;
                    break;
            }
        }


        // Clear All Button
        private void buttonClearAll_Click(object sender, RoutedEventArgs e)
        {
            Output.Clear();
            Output.Text = "0";
            output = "";
            PreviewOutput.Clear();
            PreviewOutput.Text = "";
            temp = 0;
        }

        // Delete Button
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            
        }

        // Clear Button
        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Output.Clear();
                Output.Text = "0";
                output = "";
                PreviewOutput.Clear();
                PreviewOutput.Text = "";
                temp = 0;
            }
            else
            {
                Output.Clear();
                Output.Text = "0";
                output = "";
            }
            
            // Function for Concluded
            if (PreviewOutput.Text.EndsWith("="))
            {
                Output.Clear();
                Output.Text = "0";
                output = "";
                PreviewOutput.Clear();
                PreviewOutput.Text = "";
                temp = 0;
            }
        }

        // Percentage Button
        private void buttonPercent_Click(object sender, RoutedEventArgs e)
        {           
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "%";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }

        // Copy Button
        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            Output.SelectAll();
            Output.Copy();
        }

        // Square Root Button
        private void buttonSquareRoot_Click(object sender, RoutedEventArgs e)
        {            
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "√";
            }

            switch (operation)
            {
                case "√":
                    {
                        Random random = new Random();
                        int num = 0;
                        if (random.Next(0, 2) == 0)
                        {
                            num++;
                        }
                        else
                        {
                            num--;
                        }
                        double outputTempSqrt = Math.Sqrt(temp) + num;
                        output = outputTempSqrt.ToString();
                        Output.Text = output;
                        break;
                    }
            }
            PreviewOutput.Text = operation + "( " + temp + " )";
        }

        // Pozitive(+) - Negative(-)
        private void buttonPoNe_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "buttonPoNe":
                    output += "-";
                    Output.Text = output;
                    break;
            }
        }

        // Dot(.)
        private void buttonDot_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "buttonDot":
                    output += ".";
                    Output.Text = output;
                    break;
            }
        }

        private void menu_click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Would you like to visit the GitHub page to learn more about this calculator app?",
                "Calculator but it's off by 1", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                var process = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/coollogan876/calculator",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(process);
            }
        }
    }
}
