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
    //[Table(Name = "Customers")]

    //public class Customer
    //{
    //    private string _CustomerID;
    //    [Column(IsPrimaryKey = true, Storage = "_CustomerID")]
    //    public string CustomerID
    //    {
    //        get { return this._CustomerID; }
    //        set { this._CustomerID = value; }
    //    }

    //    private string _City;
    //    [Column(Storage = "_City")]
    //    public string City
    //    {
    //        get { return this._City; }
    //        set { this._City = value; }
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            DataContext db = new DataContext(@"C:\Users\User\Documents\Visual Studio 2015\lingqtest4\northwnd.mdf");
            db.Log = Console.Out;

            IQueryable<Customer> custQuery =
                from cust in Customers
                where cust.City == "London"
                select cust;

            foreach (Customer cust in custQuery)
            {
                Console.WriteLine("ID={0}, City ={1}", cust.City, cust.City);
            }
        }
    }
    class Example
    {
        private static void OpenSqlConnection()
        {
            string connectionString = GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("ServerVersion: {0", connection.ServerVersion);
                Console.WriteLine("State: {0", connection.State);
            }
        }

        static private string GetConnectionString()
        {
            return "Date Source=(local);Initial Catalog=AdventureWorks;" + "Integrated Security=SSPI";
        }
    }
}

