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
    class Employee
    {


        //member variables
        HumanSocietyDB Database;


        //constructor
        public Employee()
        {
            Database = new HumanSocietyDB();
        }

        //member methods 
        public void AddAnimal()
        {
            HumanSocietyDB db = new HumanSocietyDB();
            db.Animal_Log.Add(new Animal_Log() { Animal_Name = "Max", Adoption_Date = null, Age = 2, Price = 20, Maintence_Score = 1, Shots = null, Species = 1, Weekly_Consumption = 3 });
        }



        public void CheckHotelRoom(HumanSocietyDB Database)
        {
            //var database = new HumanSocietyDB();
            List<int> availableRooms = (from row in Database.Animal_Hotel
                                  where row.Availablity == true
                                  select row.Room_Number).ToList();
        }

        //LINQ foreach compare parameter to Animal_Log SELECT Room_Number

        //public void assignHotelRoom(HumanSocietyDB Database, int GivenRoom_Number)
        //{
            
        //    var availableRooms = from row in Database.Animal_Hotel
        //                         where (row.Availablity == true && GivenRoom_Number == row.Room_Number)
        //                         select row.Room_Number;
        //    foreach (Room_Number in availableRooms)
        //    {
        //       //row.availability = false;
        //    }
        //}

        public void CheckShotStatus(HumanSocietyDB Database)
        {
            var shotStatus = (from row in Database.Animal_Log
                              select row.Shots).ToList();
        }











































        //public decimal Register(List<Coin> money)
        //{
        //    int total = 0;
        //    for (int i = 0; i < money.Count; i++)
        //    {
        //        total += money[i].Value;
        //    }
        //    return total;
        //}
        
        public bool Add(Animal animal)
        {
            //Linq update database
            return false;
        } 

        public bool SetAdoptionStatus()
        {
            //Linq updates data base
            return false;
        }

        public bool giveShot()
        {
            //Linq update shot status
            return false;
        }

        public bool checkShotStatus()
        {
            //Linq read table
            return false;
        }

        public void setAnimalType(Animal animal)
        {
            //LINQ to Animal_Log update Species  
        }

        public void checkConsumption(Animal animal)
        {
            //foreach given return int food consumption
        }

        public bool acceptPayment(Animal animal)
        {
            //LINQ update Animal_Log paid for
            //call setAdoptionStatus
            return false;
        }
    }
}
