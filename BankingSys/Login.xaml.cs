using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        bool firstuser = true;
        bool firstpass = true;
        public Login()
        {
            InitializeComponent();
        }

        private void UserFocus(object sender, RoutedEventArgs e)
        {
            if (firstuser)
            {
                User.Text = string.Empty;
                firstuser = false;
            }
        }

        private void PassFocus(object sender, RoutedEventArgs e)
        {
            if (firstpass)
            {
                Pass.Text = string.Empty;
                firstpass = false;
            }
        }

        private void RegisterButton(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.frame.Source = new Uri("Register.xaml", UriKind.Relative);
        }

        private void LoginButton(object sender, RoutedEventArgs e)
        {
            UserDB.login(User.Text, Pass.Text);
        }
    }
}
