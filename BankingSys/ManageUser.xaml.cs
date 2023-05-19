using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for ManageUser.xaml
    /// </summary>
    public partial class ManageUser : Page
    {

        bool firstamt = true;
        bool firstpass = true;
        public ManageUser()
        {
            InitializeComponent();

            name.Text = $"Managing user: {UserDB.currentCustomer.FirstName} {UserDB.currentCustomer.LastName} ({UserDB.currentCustomer.Username})";
            Balance.Text = $"Balance: ${UserDB.currentCustomer.Balance.ToString("0.00")}";
            Transactions.ItemsSource = UserDB.currentCustomer.Transactions;
        }
        private void AmtFocus(object sender, RoutedEventArgs e)
        {
            if (firstamt)
            {
                Amount.Text = string.Empty;
                firstamt = false;
            }
        }
        private void PassFocus(object sender, RoutedEventArgs e)
        {
            if (firstpass)
            {
                NewPass.Text = string.Empty;
                firstpass = false;
            }
        }
        private void BackButton(object sender, RoutedEventArgs e)
        {
            UserDB.currentCustomer = null;
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.frame.Source = new Uri("AdminPanel.xaml", UriKind.Relative);
        }

        private void DepositButton(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!UserDB.currentCustomer.deposit(Double.Parse(Amount.Text)))
                {
                    return;
                }
                Balance.Text = $"Balance: ${UserDB.currentCustomer.Balance.ToString("0.00")}";
                Transactions.ItemsSource = null;
                Transactions.ItemsSource = UserDB.currentCustomer.Transactions;
            }
            catch
            {
                MessageBox.Show("An error occured, make sure you are entering a number");
            }
        }

        private void WithdrawButton(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!UserDB.currentCustomer.withdraw(Double.Parse(Amount.Text)))
                {
                    return;
                }
                Balance.Text = $"Balance: ${UserDB.currentCustomer.Balance.ToString("0.00")}";
                Transactions.ItemsSource = null;
                Transactions.ItemsSource = UserDB.currentCustomer.Transactions;
            }
            catch
            {
                MessageBox.Show("An error occured, make sure you are entering a number");
            }
        }
        private void ChangeButton(object sender, RoutedEventArgs e)
        {
            try
            {
                if (NewPass.Text == "New Password" || !Regex.IsMatch(NewPass.Text, "[a-z0-9]"))
                {
                    MessageBox.Show("Please enter a new password");
                    return;
                }
                UserDB.currentCustomer.Password = NewPass.Text;
                MessageBox.Show("Password Changed");
            }
            catch
            {
                MessageBox.Show("An error occured, make sure the value is valid");
            }
        }
        private void SuspendButton(object sender, RoutedEventArgs e)
        {
            if(UserDB.currentCustomer.IsSuspended)
            {
                UserDB.currentCustomer.IsSuspended = false;
                MessageBox.Show("User unsuspended");
            }
            else
            {
                UserDB.currentCustomer.IsSuspended = true;
                MessageBox.Show("User suspended");
            }
        }
        private void DeleteButton(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this account?", "Delete Account", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                UserDB.delete(true);
                UserDB.currentCustomer = null;
                MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
                mainWindow.frame.Source = new Uri("AdminPanel.xaml", UriKind.Relative);
                MessageBox.Show("The account has been deleted");
            }
        }
    }
}
