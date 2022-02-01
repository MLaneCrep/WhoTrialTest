using System.Collections.Generic;
using System.Linq;
using WhoTrial.Common.Models;
using WhoTrial.Entities;

namespace WhoTrial.Logic
{
    public class HospitalLogic : BaseLogic, IHospitalLogic
    {

        public HospitalModel GetById(int id)
        {
            Hospital hospital = context.Hospital.First(h => h.Id_Hospital == id);

            HospitalModel hospitalModel = new HospitalModel
            {
                Id = hospital.Id_Hospital,
                Detail = hospital.Detail,
                CountryId = hospital.Id_Country,
                CountryDetail = hospital.Country.Detail
            };
            return hospitalModel;
        }
        public List<HospitalModel> GetAll()
        {
            List<HospitalModel> hospitals = context.Hospital.Select(m => new HospitalModel
            {
                Id = m.Id_Hospital,
                Detail = m.Detail,
                CountryId = m.Id_Country,
                CountryDetail = m.Country.Detail
            }).ToList();

            return hospitals;
        }
    }
}
