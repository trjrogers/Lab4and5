using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerMaintenanceClasses;

namespace CustomerTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerConstructor();
            TestCustomerPropertyGetter();
            TestCustomerPropertySetter();
            TestCustomerGetDisplayText();

            Console.WriteLine();
            Console.ReadLine();
        }

        static void TestCustomerConstructor()
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer("Trevor", "Rogers", "rogerst@my.lanecc.edu");

            Console.WriteLine("Testing constructors.");
            Console.WriteLine("Default constructor. Expecting default values." + customer1.GetDisplayText());
            Console.WriteLine("Overloaded constructor. Expecting Trevor Rogers, rogerst@my.lanecc.edu. " + customer2.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerPropertyGetter()
        {
            Customer customer = new Customer("Trevor", "Rogers", "rogerst@my.lanecc.edu");

            Console.WriteLine("Testing getters.");
            Console.WriteLine("Testing first name. Expecting Trevor. " + customer.FirstName);
            Console.WriteLine("Testing last name. Expecting Rogers. " + customer.LastName);
            Console.WriteLine("Testing email. Expecting rogerst@my.lanecc.edu. " + customer.Email);
            Console.WriteLine();

        }

        static void TestCustomerPropertySetter()
        {
            Customer customer = new Customer("Trevor", "Rogers", "rogerst@my.lanecc.edu");

            Console.WriteLine("Testing setters.");
            customer.FirstName = "Griffin";
            customer.LastName = "McElroy";
            customer.Email = "test@test.com";

            Console.WriteLine("Expecting Griffin McElroy, test@test.com. " + customer.GetDisplayText());
            Console.WriteLine();
        }

        static void TestCustomerGetDisplayText()
        {
            Customer customer = new Customer("Trevor", "Rogers", "rogerst@my.lanecc.edu");

            Console.WriteLine("Testing GetDisplayText() method.");
            Console.WriteLine("Expecting Trevor Rogers, rogerst@my.lanecc.edu. " + customer.GetDisplayText());
            Console.WriteLine();
        }
    }
}
