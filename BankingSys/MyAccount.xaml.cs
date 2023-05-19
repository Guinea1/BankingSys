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
    /// Interaction logic for MyAccount.xaml
    /// </summary>
    public partial class MyAccount : Page
    {

        bool firstpass = true;

        public MyAccount()
        {
            InitializeComponent();
        }
        private void PassFocus(object sender, RoutedEventArgs e)
        {
            if (firstpass)
            {
                NewPass.Text = string.Empty;
                firstpass = false;
            }
        }

        // Changes someones password and logs them out
        public void ChangeButton(object sender, RoutedEventArgs e)
        {
            try
            {
                if(NewPass.Text == "New Password" || !Regex.IsMatch(NewPass.Text, "[a-z0-9]"))
                {
                    MessageBox.Show("Please enter a new password");
                    return;
                }
                UserDB.change(NewPass.Text);
                MessageBox.Show("Password Changed");
                UserDB.logout();
            }
            catch
            {
                MessageBox.Show("An error occured, make sure the value is valid");
            }
        }

        // Confirms that someone wants to delete their account, then does it
        public void DeleteButton(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete your account?","Delete Account", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                UserDB.delete(false);
                UserDB.logout();
                MessageBox.Show("Your account has been deleted");
            }
        }
        private void BackButton(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if(UserDB.currentCustomer != null)
            {
                mainWindow.frame.Source = new Uri("UserPanel.xaml", UriKind.Relative);
            }
            else
            {
                mainWindow.frame.Source = new Uri("AdminPanel.xaml", UriKind.Relative);
            }
        }
    }
}
