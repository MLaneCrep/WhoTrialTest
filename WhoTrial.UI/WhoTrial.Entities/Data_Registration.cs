namespace WhoTrial.Entities
{
    using System.ComponentModel.DataAnnotations;

    public partial class Data_Registration
    {
        [Key]
        public int Id_Data_Registration { get; set; }

        public int Id_Hospital { get; set; }

        public int Year { get; set; }

        public int Id_Month { get; set; }

        public int Vaginal_Birth { get; set; }

        public int Cesarean_Section { get; set; }

        public int SCRscompleted { get; set; }

        public int RandomizedPatients { get; set; }

        public virtual Hospital Hospital { get; set; }

        public virtual Month Month { get; set; }
    }
}
