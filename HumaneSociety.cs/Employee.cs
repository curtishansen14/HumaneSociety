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
            UI.DisplayMesage("1 for Dog, 2 for Cat, 3 for Kangaroo, 4 for Turtle");
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


        public void AddAdopter(Adopter adopter)
        {
            Adopters_Log Adopter = adopter.AdopterForm();
            Database.Adopters_Log.Add(Adopter);
            Database.SaveChanges();
        }

        public void CheckHotelRooms()
        {
            
            List<int> availableRooms = (from row in Database.Animal_Hotel
                                  where row.Availablity == true
                                  select row.Room_Number).ToList();
            UI.DisplayMesage("The available rooms are:");
            for (int i = 0; i < availableRooms.Count; i++)
            {
                Console.WriteLine(availableRooms[i]);
            }

            Console.ReadKey();
        }


        public void getShotStatus()
        {
            var shotStatus = (from row in Database.Animal_Log
                              select row.Shots).ToList();
            UI.DisplayMesage("Animal Shot status:");

            for (int i = 0; i <shotStatus.Count; i++)
            {
                Console.WriteLine(shotStatus[i]);
            }
        }

        public void getShotStatus(int AnimalID)
        {
            var shotStatus = (from row in Database.Animal_Log
                              where row.Animal_ID == AnimalID
                              select row.Shots);
            UI.DisplayMesage("Animal's Shot Status:");
            Console.WriteLine(shotStatus);

        }

        public void getWeeklyConsumption(int AnimalID)
        {
            var weeklyConsumption = (from row in Database.Animal_Log
                                     where row.Animal_ID == AnimalID
                                     select row.Weekly_Consumption);

            Console.WriteLine("{1} cups of food per a week", weeklyConsumption);
        }

        public List<int> SearchBySpiecesType()
        {

            switch (UI.getUserInput().ToLower())
            {
                case "dog":
                    List<int> ListOfDogs = (from row in Database.Animal_Log
                                      where row.Species == 1
                                      select row.Animal_ID).ToList();
                    return ListOfDogs;

                case "cat":

                    var ListofCats = (from row in Database.Animal_Log
                                      where row.Species == 2
                                      select row.Animal_ID).ToList();
                    return ListofCats;

                case "kangaroo":

                    var ListofKangaroos = (from row in Database.Animal_Log
                                          where row.Species == 3
                                           select row.Animal_ID).ToList();
                    return ListofKangaroos;

                case "turtle":

                    var ListofTurtles = (from row in Database.Animal_Log
                                         where row.Species == 4
                                         select row.Animal_ID).ToList();
                    return ListofTurtles;

                default:
                    Console.WriteLine("Species not housed");
                    return null;
            }  
        }
        public List<int> SearchByAge()
        {
            switch (UI.getUserInput().ToLower())
            {
                case "1":
                    List<int> ListOfAgeOne = (from row in Database.Animal_Log
                                        where row.Age == 1
                                        select row.Animal_ID).ToList();
                    return ListOfAgeOne;

                case "2":
                    List<int> ListOfAgeTwo = (from row in Database.Animal_Log
                                              where row.Age == 2
                                              select row.Animal_ID).ToList();
                    return ListOfAgeTwo;

                case "3":

                    List<int> ListofAgeThree = (from row in Database.Animal_Log
                                                where row.Age == 3
                                                select row.Animal_ID).ToList();
                    return ListofAgeThree;

                case "4": 

                    List<int> ListofAgeFour = (from row in Database.Animal_Log
                                               where row.Age == 4
                                               select row.Animal_ID).ToList();
                    return ListofAgeFour;

                default:

                    List<int> ListOfOldGuard = (from row in Database.Animal_Log
                                                where row.Age > 4 
                                                select row.Animal_ID).ToList();
                    return ListOfOldGuard;
            }
        }

        public List<int> SearchByMaintence()
        {
            switch (UI.getUserInput().ToLower())
            {
                case "1":
                    List<int> ListofLowMaintence = (from row in Database.Animal_Log
                                                    where row.Maintence_Score == 1
                                                    select row.Animal_ID).ToList();
                    return ListofLowMaintence;

                case "2":
                    List<int> ListofMediumMaintence = (from row in Database.Animal_Log
                                                    where row.Maintence_Score == 2
                                                    select row.Animal_ID).ToList();
                    return ListofMediumMaintence;

                case "3":
                    List<int> ListofHighMaintence = (from row in Database.Animal_Log
                                                    where row.Maintence_Score == 3
                                                    select row.Animal_ID).ToList();
                    return ListofHighMaintence;
                default:
                    Console.WriteLine("No Animals of that maintence level. Please enter 1 for low 2 for medium or 3 for high. Please enter new search");
                    return null;
                    
            }
        }

        public List<int> SearchByMultiple(string Search)
        {

            List<int> FilteredAnimals = (from row in Database.Animal_Log
                                         where row.Adoption_Date == null
                                         select row.Animal_ID).ToList(); 
            string[] SearchTerms = Search.ToLower().Split(' ');
            for (int i = 0; i < SearchTerms.Length; i++)
            {
                switch (SearchTerms[i])
                {
                    case "spieces":
                        FilteredAnimals = SearchBySpiecesType();
                        return FilteredAnimals;
                    case "maintence":
                        FilteredAnimals = SearchByMaintence();
                        return FilteredAnimals;
                    case "age":
                        FilteredAnimals = SearchByAge();
                        return FilteredAnimals;
                    default:
                        return FilteredAnimals;           
                }
            }
            return FilteredAnimals;
        }
    }
}
