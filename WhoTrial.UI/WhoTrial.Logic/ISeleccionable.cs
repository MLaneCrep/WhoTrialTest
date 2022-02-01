using System.Collections.Generic;
using WhoTrial.Common.Models;

namespace WhoTrial.Logic
{
    public interface ISeleccionable
    {
        SeleccionableModel GetById(int id);
        List<SeleccionableModel> GetAll();
    }
}
