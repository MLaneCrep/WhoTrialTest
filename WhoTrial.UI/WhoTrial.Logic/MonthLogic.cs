using System.Collections.Generic;
using System.Linq;
using WhoTrial.Common.Models;
using WhoTrial.Entities;

namespace WhoTrial.Logic
{
    public class MonthLogic : BaseLogic, ISeleccionable
    {
        public SeleccionableModel GetById(int id)
        {
            Month month = context.Month.First(m => m.Id_Month == id);

             SeleccionableModel monthModel = new SeleccionableModel
            {
                Id = month.Id_Month,
                Detail = month.Detail
            };
            return monthModel;
        }
        public List<SeleccionableModel> GetAll()
        {
            List<SeleccionableModel> months = context.Month.Select(m => new SeleccionableModel
            {
                Id = m.Id_Month,
                Detail = m.Detail
            }).ToList();
            return months;
        }
    }
}
