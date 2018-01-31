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
    class CRUD
    {
        
       string connectionString = "data source=DESKTOP-KCT0PF7;initial catalog=HumaneSociety;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"
       SqlConnection connection;
        SqlCommand command;

        public CRUD()
        {
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
        }

        public void AssignRoomNumber(int Room_Number, int Animal_ID)
        {
            command.CommandText = "Update Animal_Log SET Room_Number = @room Where @animalID";

            command.Parameters.AddWithValue("@room", Room_Number);
            command.Parameters.AddWithValue("@animalID", Animal_ID);
             
        }

        public void GiveShot(int Animal_ID)
        {
            command.CommandText = "Update Animal_Log SET Shots = true Where @animalID";

            command.Parameters.AddWithValue("@animalID", Animal_ID); 
        }
       
    //Create
    //Read
    //Update
    //Delete

    //Update SQL data base
    //LinQ?

    //Interface?
}
}
