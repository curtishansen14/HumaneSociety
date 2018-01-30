namespace HumaneSociety.cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Animal_Log
    {
        [Key]
        public int Animal_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Animal_Name { get; set; }

        public DateTime? Adoption_Date { get; set; }

        public int? Room_Number { get; set; }

        public int? Adopter { get; set; }

        public int? Age { get; set; }

        public decimal? Price { get; set; }

        public int? Maintence_Score { get; set; }

        public bool? Shots { get; set; }

        public int? Species { get; set; }

        public int? Weekly_Consumption { get; set; }

        public virtual Adopters_Log Adopters_Log { get; set; }

        public virtual Animal_Hotel Animal_Hotel { get; set; }
    }
}
