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

namespace HighLowNumber
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

        // Create a function that accepts a string of space separated numbers and returns the highest and lowest number(as a string).

        public string HighLow(string input)
        {
            List<string> list = new List<string>();
            List<int> intList = new List<int>();
            List<int> intList2 = new List<int>();
            List<string> list2 = new List<string>();
            int LowNum = 0;
            int HighNum = 0;
            int counter;
            string LowNumString = LowNum.ToString();
            string HighNumString = HighNum.ToString();
            string Highlow = "";

            counter = 0;

            string[] CollectNumbers = input.Split();
            foreach (string c in CollectNumbers)
            {
                string GetString = c.ToString();
                list.Add(GetString);
                if (c == " ")
                {
                    list.Remove(GetString);
                }
                // använd .Split
            }

            foreach (string  item in list)
            {
                int GetNumbers = Convert.ToInt32(item);
                intList.Add(GetNumbers);
            }

            foreach (int item in intList)
            {
                LowNum = item;
                HighNum = item;
            }
            foreach (int item in intList)
            {

                if (LowNum > item)
                {
                    LowNum = item;
                }

                if (HighNum < item)
                {
                    HighNum = item;
                }
            }



            intList2.Add(HighNum);
            intList2.Add(LowNum);

            foreach (int item in intList2)
            {
                string NumString = item.ToString();
                list2.Add(NumString);   
            }

            foreach (string item in list2)
            {
                if (counter >= 1)
                {
                    Highlow += " ";
                }
                Highlow += item;
                counter++;

            }
            return Highlow;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = Txtinput.Text;
            MessageBox.Show(HighLow(input));


        }
    }
}
