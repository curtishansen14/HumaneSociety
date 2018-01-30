using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety.cs
{
    class Profile
    {
        //memeber variables
        string firstName;
        string lastName;
        string age;
        string phoneNumber;

        //constructor
        public Profile()
        {
            firstName = Console.ReadLine();
            lastName = Console.ReadLine();
            age = Console.ReadLine();
            phoneNumber = Console.ReadLine();
        }

        //memeber methods
        public void GetAdopterName()
        {
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.Clear();
        }
        public void GetAdopterAge()
        {
            Console.WriteLine("What is your age?");
            age = Console.ReadLine();
            Console.Clear();
        }
        public void GetAdopterPhoneNumber()
        {
            Console.WriteLine("What is your phone number?");
            phoneNumber = Console.ReadLine();
        }
        public void GetProfileInfo()
        {
            Console.WriteLine("Name: {0} {1}\nAge: {2}\nPhone Number: {3}\n\nPress any key to continue.", firstName, lastName, age, phoneNumber);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
