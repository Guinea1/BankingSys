using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

// Employee inherits from person, but changes nothing since they don't have a balance/transactions

namespace BankingSys
{
    class Employee : Person
    {
        public Employee(string firstname, string lastname, string username, string password) : base(firstname, lastname, username, password)
        {

        }
    }
}
