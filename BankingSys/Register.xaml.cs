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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {

        bool firstuser = true;
        bool firstpass = true;
        bool firstfname = true;
        bool firstlname = true;

        public Register()
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

        private void fnameFocus(object sender, RoutedEventArgs e)
        {
            if (firstfname)
            {
                FirstName.Text = string.Empty;
                firstfname = false;
            }
        }

        private void lnameFocus(object sender, RoutedEventArgs e)
        {
            if (firstlname)
            {
                LastName.Text = string.Empty;
                firstlname = false;
            }
        }

        private void RegisterButton(object sender, RoutedEventArgs e)
        {
            if(UserDB.currentEmployee != null)
            {
                UserDB.register(FirstName.Text, LastName.Text, User.Text, Pass.Text, true);
            }
            else
            {
                UserDB.register(FirstName.Text, LastName.Text, User.Text, Pass.Text, false);
            }
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if (UserDB.currentEmployee != null)
            {
                mainWindow.frame.Source = new Uri("AdminPanel.xaml", UriKind.Relative);
            }
            else
            {
                mainWindow.frame.Source = new Uri("Login.xaml", UriKind.Relative);
            }
        }
    }
}
