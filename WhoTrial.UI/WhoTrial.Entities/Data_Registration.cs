namespace WhoTrial.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Data_Registration
    {
        [Key]
        public int Id_Data_Registration { get; set; }

        public int Id_Hospital { get; set; }

        public int Year { get; set; }

        public int Id_Month { get; set; }

        public virtual Hospital Hospital { get; set; }

        public virtual Month Month { get; set; }
    }
}
