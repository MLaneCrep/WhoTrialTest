using System.Collections.Generic;
using WhoTrial.Common.Models;

namespace WhoTrial.Logic
{
    public interface IHospitalLogic
    {
        HospitalModel GetById(int id);
        List<HospitalModel> GetAll();
    }
}
