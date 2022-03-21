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

namespace WPFDemo
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(pass.Password !="" || user.Text != "")
            {
                if (pass.Password == "swathi" && user.Text == "swathi")
                {
                    MessageBox.Show("Welcome Swathi", "Authenication Success");
                }
                else MessageBox.Show("Please enter valid credentails", "Invalid credentails");
            }
            else MessageBox.Show("Please enter valid credentails", "Invalid credentails");
        }
    }
}
