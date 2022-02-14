using System.Collections.Generic;
using System.Linq;
using WhoTrial.Common.Models;
using WhoTrial.Entities;

namespace WhoTrial.Logic
{
    public class CountryLogic : BaseLogic, ISeleccionable
    {
        public SeleccionableModel GetById(int id)
        {
            Country country = context.Country.First(m => m.Id_Country == id);

            SeleccionableModel countryModel = new SeleccionableModel
            {
                Id = country.Id_Country,
                Detail = country.Detail
            };
            return countryModel;
        }
        public List<SeleccionableModel> GetAll()
        {
            List<SeleccionableModel> countries = context.Country.Select(m => new SeleccionableModel
            {
                Id = m.Id_Country,
                Detail = m.Detail
            }).ToList();
            return countries;
        }
    }
}
