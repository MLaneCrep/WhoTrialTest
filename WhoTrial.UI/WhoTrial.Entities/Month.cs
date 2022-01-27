namespace WhoTrial.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Month")]
    public partial class Month
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Month()
        {
            Data_Registration = new HashSet<Data_Registration>();
        }

        [Key]
        public int Id_Month { get; set; }

        [Required]
        [StringLength(12)]
        public string Detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Data_Registration> Data_Registration { get; set; }
    }
}
