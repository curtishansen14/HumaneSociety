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
        CRUD crud;


        //constructor
        public Employee()
        {
            Database = new HumanSocietyDB();
            crud = new CRUD();
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
            UI.DisplayMesage("What species is it?");
            AnimalToAdd.Species = UI.getAnimalType();
            UI.DisplayMesage("What is the animal's age?");
            AnimalToAdd.Age = UI.getUserInputInt();
            UI.DisplayMesage("How much does the animal cost?");
            AnimalToAdd.Price = UI.getUserInputdecimal();
            UI.DisplayMesage("What is the animal's maintence score?");
            UI.DisplayMesage("1 for low maintence, 2 for medium, 3 for high");
            AnimalToAdd.Maintence_Score = UI.getUserInputInt();
            UI.DisplayMesage("How many cups of food does the animal eat per a week?");
            AnimalToAdd.Weekly_Consumption = UI.getUserInputInt();
            
            return AnimalToAdd;
        }


        public void CheckHotelRoom()
        {
            
            List<int> availableRooms = (from row in Database.Animal_Hotel
                                  where row.Availablity == true
                                  select row.Room_Number).ToList();

            // for each to diplay
        }


        public void getShotStatus()
        {
            var shotStatus = (from row in Database.Animal_Log
                              select row.Shots).ToList();

            //for each to display
        }

        public void getShotStatus(int AnimalID)
        {
            var shotStatus = (from row in Database.Animal_Log
                              where row.Animal_ID == AnimalID
                              select row.Shots);
        }

        public void getWeeklyConsumption(int AnimalID)
        {
            var weeklyConsumption = (from row in Database.Animal_Log
                                     where row.Animal_ID == AnimalID
                                     select row.Weekly_Consumption);

            Console.WriteLine("{1} cups of food per a week", weeklyConsumption);
        }

        public decimal acceptPayment()
        {
            decimal payment = 0;
            //LINQ update Animal_Log paid for
            //call setAdoptionStatus
            return payment;
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
    }
}
