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
    /// Interaction logic for UserPanel.xaml
    /// </summary>
    public partial class UserPanel : Page
    {
        public UserPanel()
        {
            InitializeComponent();

            name.Text = $"Welcome, {UserDB.currentCustomer.FirstName} {UserDB.currentCustomer.LastName}";
            balance.Text = $"Your Balance: ${UserDB.currentCustomer.Balance}";
            Transactions.ItemsSource = UserDB.currentCustomer.Transactions;
        }

        public void logout(object sender, EventArgs e)
        {
            UserDB.logout();
        }

        public void DepositButton(object sender, EventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.frame.Source = new Uri("Deposit.xaml", UriKind.Relative);
        }
        public void WithdrawButton(object sender, EventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.frame.Source = new Uri("Withdraw.xaml", UriKind.Relative);
        }

        public void AccountButton(object sender, EventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.frame.Source = new Uri("MyAccount.xaml", UriKind.Relative);
        }
    }
}
