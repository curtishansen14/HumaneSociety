using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HumaneSociety.cs
{
    public static class UI
    {
        public static string getUserInput()
        {
            string userInput = Console.ReadLine();
            return userInput; 
        }

        public static void DisplayMesage(string message)
        {
            Console.WriteLine(message);
        }

        public static bool getUserInputBool()
        {
            //does the animal have it's shots
            //utilize if statement to return true or false 
            return false;
        }

        public static decimal getUserInputdecimal()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            return number;
          
        }
        //method to get species put switch case choose number. 

        //method to display all Animal_Log information 
    }
}
