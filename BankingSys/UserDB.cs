using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BankingSys
{
    internal static class UserDB
    {
        // The "Database" V
        public static List<Customer> customers = new List<Customer>();
        public static List<Employee> employees = new List<Employee>();

        // The currently logged in/managed customer/employee
        public static Customer currentCustomer;
        public static Employee currentEmployee;

        // Registers a new account (user or admin)
        public static void register(string firstname, string lastname, string username, string password, bool isAdmin)
        {
            try
            {
                if(!checkValid(firstname, lastname, username, password))
                {
                    MessageBox.Show("Please enter values for all fields");
                    return;
                }
                if(checkUser(username))
                {
                    if(isAdmin)
                    {
                        employees.Add(new Employee(firstname, lastname, username, password));
                        MessageBox.Show("Successfully Registered");
                        MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
                        mainWindow.frame.Source = new Uri("AdminPanel.xaml", UriKind.Relative);
                    }
                    else
                    {
                        customers.Add(new Customer(firstname, lastname, username, password));
                        MessageBox.Show("Successfully Registered, continue to login");
                        MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
                        mainWindow.frame.Source = new Uri("Login.xaml", UriKind.Relative);
                    }
                }
                else
                {
                    MessageBox.Show("Unable to register, username is already taken");
                }
            }
            catch
            {
                MessageBox.Show("Unable to register, please make sure all fields are valid (no invalid characters)");
            }
        }

        // Checks if username is already taken
        public static bool checkUser(string username)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Username == username)
                {
                    return false;
                }
            }

            foreach (Customer customer in customers)
            {
                if (customer.Username == username)
                {
                    return false;
                }
            }
            return true;
        }

        // Checks if registration info is valid (as in, no empty fields)
        public static bool checkValid(string firstname, string lastname, string username, string password)
        {
            if(firstname == "First Name" || lastname == "Last Name" || username == "Username" || password == "Password" || !Regex.IsMatch(firstname, "[a-z0-9]") || !Regex.IsMatch(lastname, "[a-z0-9]") || !Regex.IsMatch(username, "[a-z0-9]") || !Regex.IsMatch(password, "[a-z0-9]"))
            {
                return false;
            }
            return true;
        }

        // Logs someone in (user or admin)
        public static void login(string username, string password)
        {

            if (username == "Username" || password == "Password" || !Regex.IsMatch(username, "[a-z0-9]") || !Regex.IsMatch(password, "[a-z0-9]"))
            {
                MessageBox.Show("Please enter a value for all fields");
                return;
            }

            foreach (Employee emp in employees)
            {
                if(emp.Username == username && emp.Password == password)
                {
                    currentEmployee = emp;
                    MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
                    mainWindow.frame.Source = new Uri("AdminPanel.xaml", UriKind.Relative);
                    return;
                }
            }

            foreach (Customer cus in customers)
            {
                if (cus.Username == username && cus.Password == password)
                {
                    if(cus.IsSuspended)
                    {
                        MessageBox.Show("Your account is currently suspended");
                        return;
                    }
                    currentCustomer = cus;
                    MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
                    mainWindow.frame.Source = new Uri("UserPanel.xaml", UriKind.Relative);
                    return;
                }
            }
            MessageBox.Show("Invalid username/password, or user does not exist");
        }

        // Logs someone out (user or admin)
        public static void logout()
        {
            if(currentCustomer != null)
            {
                currentCustomer = null;
            }
            else
            {
                currentEmployee = null;
            }
            MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.frame.Source = new Uri("Login.xaml", UriKind.Relative);
        }

        // Deletes an account (user or admin)
        public static void delete(bool isManaging)
        {
            if (currentCustomer != null || isManaging)
            {
                customers.Remove(currentCustomer);
            }
            else
            {
                employees.Remove(currentEmployee);
            }
        }

        // Finds and sets up a user to be managed in the admin panel
        public static void manageCustomer(string username)
        {
            if (username == "Username" || !Regex.IsMatch(username, "[a-z0-9]"))
            {
                MessageBox.Show("Please enter a value");
                return;
            }

            foreach (Customer cus in customers)
            {
                if (cus.Username == username)
                {
                    currentCustomer = cus;
                    MainWindow mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
                    mainWindow.frame.Source = new Uri("ManageUser.xaml", UriKind.Relative);
                    return;
                }
            }
            MessageBox.Show("User does not exist, OR is an admin");
        }

        // Creates demo accounts
        public static void addDemo()
        {
            employees.Add(new Employee("Demo", "Employee", "admin", "admin"));
            customers.Add(new Customer("Demo", "Customer", "user", "user"));
        }

        // Changes someones password (user or admin)
        public static void change(string newPass)
        {
            if (currentCustomer != null)
            {
                currentCustomer.Password = newPass;
            }
            else
            {
                currentEmployee.Password = newPass;
            }
        }

        // Gets the total amount of money in the "bank"
        public static double TotalMoney()
        {
            double total = 0.0;

            foreach (Customer customer in customers)
            {
                total += customer.Balance;
            }
            return total;
        }
    }
}
