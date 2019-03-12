using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenanceClasses
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string email;

        public Customer() { }

        public Customer(string first, string last, string em)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Email = em;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string GetDisplayText()
        {
            string info;
            info = firstName + " " + lastName + ", " + email;
            return info;
        }
    }
}
