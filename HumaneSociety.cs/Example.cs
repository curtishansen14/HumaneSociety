﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety.cs
{
    [Table(Name = "Customers")]

    public class Customer
    {
        private string _CustomerID;
        [Column(IsPrimaryKey = true, Storage = "_CustomerID")]
        public string CustomerID
        {
            get { return this._CustomerID; }
            set { this._CustomerID = value; }
        }

        private string _City;
        [Column(Storage = "_City")]
        public string City
        {
            get { return this._City; }
            set { this._City = value; }
        }
    }
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
    }
}

