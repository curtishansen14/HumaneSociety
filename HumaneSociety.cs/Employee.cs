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
            Animal_Log Animal = AnimalForm();
            Database.Animal_Log.Add(Animal); 
            Database.SaveChanges();
        }

        public Animal_Log AnimalForm()
        {
            Animal_Log AnimalToAdd = new Animal_Log();
            UI.DisplayMesage("What is the animal's name?");
            AnimalToAdd.Animal_Name = UI.getUserInput();
            //repeat for all AnimalToAdd.Things 
            //for true and false one I will need a second step
            return AnimalToAdd;
        }

        public void AssignRoom()
        {

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



        public bool acceptPayment()
        {
            //LINQ update Animal_Log paid for
            //call setAdoptionStatus
            return false;
        }
    }
}
