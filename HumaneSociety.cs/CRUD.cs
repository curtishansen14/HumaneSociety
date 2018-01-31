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

            command.Parameters.AddWithValue("@room", Room_Number);
            command.Parameters.AddWithValue("@animalID", Animal_ID);

            command.CommandText = "Update Animal_Log SET Room_Number = @room Where @animalID";   
        }

        public void GiveShot(int Animal_ID)
        {
            command.Parameters.AddWithValue("@animalID", Animal_ID);

            command.CommandText = "Update Animal_Log SET Shots = true Where @animalID";    
        }

        /////////////////////////////////////////////////////////////////////////
       //////////Adoption Date indicates when/if an Animal was Adopted//////////
      /////////////////////////////////////////////////////////////////////////

        public void SetAdoptionDate( DateTime AdoptionDate, int Animal_ID)
        {
            command.Parameters.AddWithValue("@AdoptionDate", AdoptionDate);
            command.Parameters.AddWithValue("@Animal_ID", Animal_ID);

            command.CommandText = "Update Animal_Log SET Adoption_Date = @AdoptionDate Where Animal_ID =@Animal_ID";
        }

        public void SetAnimalType(int? EmployeeInput, int Animal_ID)
        {
            command.Parameters.AddWithValue("@EmployeeInput", EmployeeInput);
            command.Parameters.AddWithValue("@Animal_ID", Animal_ID);

            command.CommandText = "UPDATE Animal_Log SET Species = @EmployeeInput WHERE Animal_Id = @Animal_ID";
        }
       

}
}
