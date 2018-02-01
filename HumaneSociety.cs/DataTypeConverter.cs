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
        //String to Datetime
        //string to int
        //string to decimal 

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

        public decimal ConvertSrtingToDecimal(string input)
        {
            decimal output = Convert.ToDecimal(input);
            return output;

        }
    }
}
