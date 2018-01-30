using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety.cs
{
    class Employee
    {


        //member variables


        //constructor


        //member methods 
        public decimal Register(List<Coin> money)
        {
            int total = 0;
            for (int i = 0; i < money.Count; i++)
            {
                total += money[i].Value;
            }
            return total;
        }
        
        public bool Add(Animal animal)
        {
            //Linq update database
            return false;
        } 


        public int CheckHotelRoom(int Animal_ID)
        {
            int Room_Number = 1;
            //LINQ foreach compare parameter to Animal_Log SELECT Room_Number

            return Room_Number;
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
