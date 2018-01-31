using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HumaneSociety.cs
{
    class CSVreader
    {
        string[] allLines;

        public void ParseCSV()
        {
            allLines = File.ReadAllLines(@"C:\Users\User\Documents\HumaneSociety.csv");

            var query = from line in allLines
                        let data = line.Split(',')
                        select new
                        {
                            aName = data[0],
                            aAdoption_Date = data[1],
                            aRoom_Number = data[2],
                            aAdopter = data[3],
                            aAge = data[4],
                            aPrice = data[5],
                            aMaintence_Score = data[6],
                            aShots = data[7],
                            aSpecies = data[8],
                            aWeekly_consumption = data[9]
                        };
            foreach(var item in query)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", item.aName, item.aAdoption_Date, item.aRoom_Number,item.aAdopter,item.aAge,item.aPrice, item.aMaintence_Score, item.aShots, item.aSpecies, item.aWeekly_consumption);
            }
        } 
    }
}
