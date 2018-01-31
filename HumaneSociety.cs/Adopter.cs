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
    class Adopter
    {


        public Adopters_Log AdopterForm()
        {
            Adopters_Log AdopterToAdd = new Adopters_Log();
            UI.DisplayMesage("What is adopters first name?");
            AdopterToAdd.First_Name = UI.getUserInput();
            UI.DisplayMesage("What is adopters last name?");
            AdopterToAdd.Last_Name = UI.getUserInput();

            return AdopterToAdd;
        }

    }
}
