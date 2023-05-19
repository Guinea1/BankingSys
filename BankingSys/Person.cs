using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSys
{
    abstract class Person
    {
        private string firstname;
        private string lastname;
        private string username;
        private string password;

        public string FirstName { get { return firstname; } }
        public string LastName { get { return lastname; } }
        public string Username { get { return username; } }
        public string Password { get { return password; } set { password = value; } }

        public Person(string firstname, string lastname, string username, string password)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.password = password;
        }
    }
}
