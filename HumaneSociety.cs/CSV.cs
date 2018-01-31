using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using Microsoft.VisualBasic.FileIO;


namespace HumaneSociety.cs
{
    class CSV
    {

        string csv_path = @"C:\Users\User\Documents\HumaneSociety.csv";

        

        private static DataTable GetDataTabletFromCSVFIL(string csv_path)
        {
            DataTable csvData = new DataTable();
            try {
                using (TextFieldParser csvReader = new TextFieldParser(csv_path))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] columns_fields = csvReader.ReadFields();
                    foreach (string column in columns_fields)
                    {
                        DataColumn datacolumn = new DataColumn(column);
                        datacolumn.AllowDBNull = true;
                        csvData.Columns.Add(datacolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
                catch (Exception)
                    {return null;}
                        return csvData;
            }
        static void InsertDataIntoSQLUsingBulkCopy(DataTable csvFileData, string TableName)
        {
            string connectionString = "data source=DESKTOP-KCT0PF7;initial catalog=HumaneSociety;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            using (SqlConnection dbconnection = new SqlConnection(connectionString))
            {
                dbconnection.Open();
                using(SqlBulkCopy Bulkcopy = new SqlBulkCopy(dbconnection))
                {
                    Bulkcopy.DestinationTableName = TableName;
                    foreach (var column in csvFileData.Columns)
                    {
                        Bulkcopy.ColumnMappings.Add(column.ToString(), column.ToString());
                        Bulkcopy.WriteToServer(csvFileData);
                    }
                        
                }
                dbconnection.Close();
            }
        }    
    }

        
}

