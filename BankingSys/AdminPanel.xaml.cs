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
using System.Xml.Linq;
using System.Threading;
using System.Windows.Threading;

namespace BankingSys
{
    /// <summary>
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Page
    {

        bool firstuser = true;
        Thread customerThread = null;

        public AdminPanel()
        {
            InitializeComponent();

            name.Text = $"Welcome, {UserDB.currentEmployee.FirstName} {UserDB.currentEmployee.LastName}";

            TotalMoney.Text = $"Total Money: ${UserDB.TotalMoney().ToString("0.00")}";

            customerThread = new Thread(GetCustomers);
            customerThread.Start();
        }
        public void ManageButton(object sender, RoutedEventArgs e)
        {
            try
            {
                UserDB.manageCustomer(User.Text);
            }
            catch
            {
                MessageBox.Show("An error occured, make sure the value is valid");
            }
        }
        public void logout(object sender, RoutedEventArgs e)
        {
            UserDB.logout();
        }
        private void UserFocus(object sender, RoutedEventArgs e)
        {
            if (firstuser)
            {
                User.Text = string.Empty;
                firstuser = false;
            }
        }
        private void AdminRegister(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.frame.Source = new Uri("Register.xaml", UriKind.Relative);
        }

        private void AccountButton(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.frame.Source = new Uri("MyAccount.xaml", UriKind.Relative);
        }
        private void GetCustomers()
        {
            IEnumerable<Customer> linq = from customer in UserDB.customers
                                         orderby customer.Balance descending
                                         select customer;
            this.Dispatcher.Invoke(() => { Customers.ItemsSource = linq; });
            customerThread.Abort();
        }
    }
}
