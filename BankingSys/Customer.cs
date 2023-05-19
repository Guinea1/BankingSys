using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

// Customer inherits from person and adds balance/transactions

namespace BankingSys
{
    class Customer : Person
    {
        private double balance;
        private List<Transaction> transactions;
        private bool isSuspended;
        public double Balance { get { return balance; } }
        public List<Transaction> Transactions { get {  return transactions; } }
        public bool IsSuspended { get { return isSuspended; } set { isSuspended = value; } }
        public Customer(string firstname, string lastname, string username, string password): base(firstname, lastname, username, password)
        {
            this.balance = 0.0;
            this.transactions = new List<Transaction>();
            this.isSuspended = false;
        }

        // Deposits an amount and logs it
        public bool deposit(double value)
        {
            if(!(value > 0))
            {
                MessageBox.Show("Cannot deposit 0 or negative dollars");
                return false;
            }
            this.balance += value;
            transactions.Add(new Transaction($"+${value}", DateTime.Now));
            MessageBox.Show($"${value} was Deposited");
            return true;
        }

        // Withdraws an amount and logs it
        public bool withdraw(double value)
        {
            if(!(value > 0))
            {
                MessageBox.Show("Cannot withdraw 0 or negative dollars");
                return false;
            }
            if(this.balance >= value)
            {
                this.balance -= value;
                transactions.Add(new Transaction($"-${value}", DateTime.Now));
                MessageBox.Show($"${value} was Withdrawn");
                return true;
            }
            MessageBox.Show("Account does not have enough money");
            return false;
        }
    }
}
