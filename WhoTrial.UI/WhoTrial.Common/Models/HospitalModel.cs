using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoTrial.Common.Models
{
    public class HospitalModel : SeleccionableModel
    {
        public int CountryId { get; set; }
        public string CountryDetail { get; set; }
    }
}
