using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSys
{
    internal class Transaction
    {
        private string amount;
        private DateTime date;
        public string Amount { get { return amount; } }
        public DateTime Date { get { return date; } }
        public Transaction(string amount, DateTime date)
        {
            this.amount = amount;
            this.date = DateTime.Now;
        }
    }
}
