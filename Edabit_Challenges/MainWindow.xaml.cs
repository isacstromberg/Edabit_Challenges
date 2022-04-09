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

namespace Edabit_Challenges
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
        //ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits.
        //Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.



        public bool ValidatePin(string input)
        {
            string AllowedNumbers = "1234567890";
            int counter = 0;
            counter = 0;
            foreach (char c in input)
            {
                foreach (char d in AllowedNumbers)
                {
                    if (c == d)
                    {
                        counter++;
                    }
                }
            }

            if (counter == 4)
            {
                return true;
            }

            if (counter == 6)
            {
                return true;
            }

            return false;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string InputPin = TxtInput.Text;
            MessageBox.Show($"{ValidatePin(InputPin)}");
        }
    }
}
