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

namespace forms1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public double a, b;
        public char c;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "1";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "2";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "3";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "4";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "5";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "6";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "7";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "8";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "9";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            TextBox.Text += "0";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
            a = 0;
            b = 0;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            string s = TextBox.Text;
            s = s.Substring(0, s.Length - 1);
            TextBox.Text = s;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TextBox.Text);
                c = '*';
                TextBox.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TextBox.Text);
                c = '+';
                TextBox.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TextBox.Text);
                c = '-';
                TextBox.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TextBox.Text);
                c = '/';
                TextBox.Text = "";
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TextBox.Text);
                TextBox.Text = Convert.ToString(a * a);
            }
            catch
            {

            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            try
            {
                a = Convert.ToDouble(TextBox.Text);
                TextBox.Text = Convert.ToString(Math.Sqrt(a));
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            try
            {
                b = Convert.ToDouble(TextBox.Text);
                TextBox.Text = "";
                switch (c)
                {
                    case '+':
                        TextBox.Text = Convert.ToString(a + b);
                        break;
                    case '-':
                        TextBox.Text = Convert.ToString(a - b);
                        break;
                    case '*':
                        TextBox.Text = Convert.ToString(a * b);
                        break;
                    case '/':
                        TextBox.Text = Convert.ToString(a / b);
                        if (b == 0) { TextBox.Text = "Не пытайся, не получится!"; }
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            TextBox.Text += ",";
        }
    }
}
