using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HumaneSociety.cs
{
    class DataTypeConverter
    {

        public DateTime ConvertStringToDateTime(string input)
        {
            DateTime output = Convert.ToDateTime(input);
            return output;
        }

        public int ConvertStringToInt(string input)
        {
            int output = Convert.ToInt32(input);
            return output;
        }

        public decimal ConvertStringToDecimal(string input)
        {
            decimal output = Convert.ToDecimal(input);
            return output;

        }

        public bool ConvertStringToBool(string input)
        {
            bool shots = false;
            if (input == "1")
            {
                shots = true;
                return shots;
            }
            else
            {
                return shots;
            }
        }
    }
}
