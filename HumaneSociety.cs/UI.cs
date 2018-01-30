using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HumaneSociety.cs
{
    class UI
    {
        public string getUserInput()
        {
            string userInput = Console.ReadLine();
            return userInput; 
        }
    }
}
