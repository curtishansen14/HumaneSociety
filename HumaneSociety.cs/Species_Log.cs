namespace HumaneSociety.cs
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Species_Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Species_ID { get; set; }

        [StringLength(50)]
        public string Species_type { get; set; }
    }
}
