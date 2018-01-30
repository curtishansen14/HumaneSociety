using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety.cs
{

      //////////////////////////////////////////////////////////////////
     ///////////Designating properties in this class //////////////////
    /////////////to represent database columns////////////////////////
   //////////////////////////////////////////////////////////////////

    [Table(Name = "Animal_Log")]
    class Animal_log
    {
        private string _Animal_ID;
        [Column(IsPrimaryKey = true, Storage = "_Animal_ID")]

        private string _Animal_Name;
        [Column(Storage = "_Animal_Name")]

        private string _Adoption_Date;
        [Column(Storage = "_Adoption_Date")]

        private string _Room_Number;
        [Column(Storage = "_Room_Number")]

        private string _Adopter;
        [Column(Storage = "_Adopter")]

        private string _Age;
        [Column(Storage = "_Age")]

        private string _Price;
        [Column(Storage = "_Price")]

        private string _Maintence_Score;
        [Column(Storage = "_Maintence_Score")]

        private string _Shots;
        [Column(Storage = "_Shots")]

        private string _Species;
        [Column(Storage = "_Species")]

        private string _Weekly_Consumption;
        [Column(Storage = "_Weekly_Consumption")]




          //////////////////////////////////////////////////////////////////
         ///////////////Getters and Setters////////////////////////////////
        //////////////////////////////////////////////////////////////////
        public string Animal_ID
        {
            get { return this._Animal_ID; }
            set { this._Animal_ID = value; }
        }

        public string Animal_Name
        {
            get { return this._Animal_Name; }
            set { this._Animal_Name = value; }
        }

        public string Adoption_Date
        {
            get { return this._Adoption_Date; }
            set { this._Adoption_Date = value; }
        }

        public string Room_Number
        {
            get { return this._Room_Number; }
            set { this._Room_Number = value; }
        }

        public string Adopter
        {
            get { return this._Adopter; }
            set { this._Adopter = value; }
        }

        public string Age
        {
            get { return this._Age; }
            set { this._Age = value; }
        }

        public string Price
        {
            get { return this._Price; }
            set { this._Price = value; }
        }

        public string Maintence_Score
        {
            get { return this._Maintence_Score; }
            set { this._Maintence_Score = value; }
        }

        public string Shots
        {
            get { return this._Shots; }
            set { this._Shots = value; }
        }

        public string Species
        {
            get { return this._Species; }
            set { this._Species = value; }
        }

        public string Weekly_Consumption
        {
            get { return this._Weekly_Consumption; }
            set { this._Weekly_Consumption = value; }
        }
    }
}
