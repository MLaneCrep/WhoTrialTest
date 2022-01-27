using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoTrial.Data;
using WhoTrial.Entities;

namespace WhoTrial.Logic
{
    public class MonthLogic
    {
        private readonly IonicAppContext context;
        public MonthLogic()
        {
            context = new IonicAppContext();   
        }

        public List<Month> GetAll()
        {
            return context.Month.ToList();
        }
    }
}
