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
            DataTypeConverter converter = new DataTypeConverter();

            var query = from line in allLines
                        let data = line.Split(',')
                        select new
                        {
                            aName = data[0],
                            aAdoption_Date = converter.ConvertStringToDateTime(data[1]),
                            aRoom_Number = data[2],
                            aAdopter = converter.ConvertStringToInt(data[3]),
                            aAge = converter.ConvertStringToInt(data[4]),
                            aPrice = converter.ConvertStringToDecimal(data[5]),
                            aMaintence_Score = converter.ConvertStringToInt(data[6]),
                            aShots =  data[7],
                            aSpecies = converter.ConvertStringToInt(data[8]),
                            aWeekly_consumption = converter.ConvertStringToInt(data[9])
                        };
            foreach(var item in query)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", item.aName, item.aAdoption_Date, item.aRoom_Number,item.aAdopter,item.aAge,item.aPrice, item.aMaintence_Score, item.aShots, item.aSpecies, item.aWeekly_consumption);
            }
        } 
    }
}
