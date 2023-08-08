using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double temp = 0;
        string operation = ""; 
        string output = ""; 
            

        public MainWindow()
        {
            InitializeComponent();
            DivideBtn.Content = "\u00F7";

            
        }
      
        private void NumBtn_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;
            

            switch (name)
            {
                case "OneBtn":
                    output += '1';
                    OutputTextBlock.Text = output;
                    break;

                case "TwoBtn":
                    output += '2';
                    OutputTextBlock.Text = output;
                    break;

                case "ThreeBtn":
                    output += '3';
                    OutputTextBlock.Text = output;
                    break;

                case "FourBtn":
                    output += '4';
                    OutputTextBlock.Text = output;
                    break;

                case "FiveBtn":
                    output += '5';
                    OutputTextBlock.Text = output;
                    break;

                case "SixBtn":
                    output += '6';
                    OutputTextBlock.Text = output;
                    break;

                case "SevenBtn":
                    output += '7';
                    OutputTextBlock.Text = output;
                    break;

                case "EightBtn":
                    output += '8';
                    OutputTextBlock.Text = output;
                    break;

                case "NineBtn":
                    output += '9';
                    OutputTextBlock.Text = output;
                    break;

                case "ZeroBtn":
                    output += '0';
                    OutputTextBlock.Text = output;
                    break;

                case "CommaBtn":
                    if (!output.Contains('.'))
                    {
                        output += '.';
                        OutputTextBlock.Text = output;
                    }
                    break;

            }
        }

        private void MinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if(output !="")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Minus";
            }
        }

        private void PlusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Plus";
            }
        }

        private void TimesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Times";
            }
        }

        private void DivideBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);
                output = "";
                operation = "Divide";
            }
        }

        private void MinusPlus_Click(object sender, RoutedEventArgs e)
        {
            if (output != ".")
                if (output != "")
            {
                temp = double.Parse(OutputTextBlock.Text);
                temp = Math.Abs(temp) * (-1);
                OutputTextBlock.Text = temp.ToString();
            }
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            double outputTemp;

            switch(operation)
            {
                case "Minus":
                    outputTemp = temp - double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Plus":
                    outputTemp = temp + double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Times":
                    outputTemp = temp * double.Parse(output);
                    output = outputTemp.ToString();
                    OutputTextBlock.Text = output;
                    break;

                case "Divide":
                    if(double.Parse(output) !=0)
                    {
                        outputTemp = temp / double.Parse(output);
                        output = outputTemp.ToString();
                        OutputTextBlock.Text = output;
                    }
                    break;
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            output = "";
            OutputTextBlock.Text = output;
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBlock.Text = output;
            if (output.Length > 0)
            {
                output = output.Remove(output.Length -1,1);
            }
            if (output == "")
            {
                output = "";
            }
        }

        private void CosBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                double cos = Convert.ToDouble(OutputTextBlock.Text);
                cos = Math.Cos(cos);
                OutputTextBlock.Text = Convert.ToString(cos);
            }
        }

        private void SinBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                double sin = Convert.ToDouble(OutputTextBlock.Text);
                sin = Math.Sin(sin);
                OutputTextBlock.Text = Convert.ToString(sin);
            }
        }

        private void CtanBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                double ctan = Convert.ToDouble(OutputTextBlock.Text);
                ctan = +1 / Math.Tan(ctan);
                OutputTextBlock.Text = Convert.ToString(ctan);
            }
        }

        private void TanBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                double tan = Convert.ToDouble(OutputTextBlock.Text);
                tan = Math.Tan(tan);
                OutputTextBlock.Text = Convert.ToString(tan);
            }
        }

        private void BinBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                int outputTemp = int.Parse(OutputTextBlock.Text);
                OutputTextBlock.Text = Convert.ToString(outputTemp, 2);
            }
        }

        private void HexBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                int outputTemp = int.Parse(OutputTextBlock.Text);
                OutputTextBlock.Text = Convert.ToString(outputTemp, 16);
            }
           /*if (output == hex)
            {
                int intValue = int.Parse(output, System.Globalization.NumberStyles.HexNumber);
            }*/
        }

        private void OctBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                int outputTemp = int.Parse(OutputTextBlock.Text);
                OutputTextBlock.Text = Convert.ToString(outputTemp, 8);
            }
        }

        private void PercentBtn_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                double outputTemp;
                outputTemp = (temp * double.Parse(output) / 100);
                output = outputTemp.ToString();
            }
        }
    }
}
