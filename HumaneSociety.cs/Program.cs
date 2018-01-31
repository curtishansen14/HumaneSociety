using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HumaneSociety.cs
{
    public class Program
    {
        static void Main(string[] args)
        {
            CSVreader reader = new CSVreader();
            reader.ParseCSV();
            Console.ReadKey();
        }
    }
}
