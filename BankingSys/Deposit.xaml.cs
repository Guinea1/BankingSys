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

namespace BankingSys
{
    /// <summary>
    /// Interaction logic for Deposit.xaml
    /// </summary>
    public partial class Deposit : Page
    {

        bool firstamt = true;

        public Deposit()
        {
            InitializeComponent();
        }
        private void AmtFocus(object sender, RoutedEventArgs e)
        {
            if (firstamt)
            {
                Amount.Text = string.Empty;
                firstamt = false;
            }
        }
        private void BackButton(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.frame.Source = new Uri("UserPanel.xaml", UriKind.Relative);
        }

        private void DepositButton(object sender, RoutedEventArgs e)
        {
            try
            {
                if(!UserDB.currentCustomer.deposit(Double.Parse(Amount.Text)))
                {
                    return;
                }
                MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
                mainWindow.frame.Source = new Uri("UserPanel.xaml", UriKind.Relative);
            }
            catch
            {
                MessageBox.Show("An error occured, make sure you are entering a number");
            }
        }
    }
}
