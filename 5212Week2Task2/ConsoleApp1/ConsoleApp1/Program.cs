using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        //Person object properties
        string fName, lName, account;
        float tax, pay;

        /*----- Getters and Setters -----*/
        //Standard getters and setters
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                fName = value;
            }
        }
        public string LName
        {
            get{return lName;}
            set{lName = value;}
        }
        public string Account{get{return account;}set{account = value;}}

        //Arrow notation(Expression bodied methods)C#7.0
        public float Tax
        {
            get => tax;
            set => tax = value;
        }
        public float Pay { get => pay; set => pay = value; }

        //Constructor
        public Person(string _fName, string _lName, float _pay, float _tax, string _account)
        {
            //ensure your referncing the setter and not the property
            FName = _fName;
            LName = _lName;
            Tax = _tax;
            Pay = _pay;
            Account = _account;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //One way to create a Person object while theres a constructor.
            Person employee2 = new Person("Jacob", "Van Silfhout", 15000, 15, "00-0000-0000000-00");
            //Another way
            Person employee1 = new Person("", "", 0, 0, "");
            employee1.FName = "Hemi";
            employee1.LName = "Te Whiti";
            employee1.Pay = 60000;
            employee1.Tax = 0.15F;
            employee1.Account = "02-3456-9876543-21";

            Console.WriteLine($"Employee 1.\nName: {employee1.FName} {employee1.LName}\nPay: {employee1.Pay}\nTax: {employee1.Tax}\nAccount: {employee1.Account}\n");
            Console.WriteLine("Employee 2.\nName: {0} {1}\nPay: {2}\nTax: {3}\nAccount: {4}\n",employee2.FName, employee2.LName, employee2.Pay, employee2.Tax, employee2.Account);

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
