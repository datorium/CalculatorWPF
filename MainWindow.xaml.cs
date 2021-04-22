using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumericButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            
            if(Display.Text == "0")
            {
                Display.Text = button.Content.ToString();
            }
            else
            {
                Display.Text += button.Content.ToString();
            }            
        }

        private void PeriodButton_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;

            if (button.Content.ToString() == ".")
            {
                if (!Display.Text.Contains("."))
                {
                    Display.Text += button.Content.ToString();
                }              
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
        }

        private void OperationButton_Click(object sender, RoutedEventArgs e)
        {
            Display.Text = "0";
        }
    }
}
