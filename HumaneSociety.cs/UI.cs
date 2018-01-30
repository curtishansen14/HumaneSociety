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
    }
}
