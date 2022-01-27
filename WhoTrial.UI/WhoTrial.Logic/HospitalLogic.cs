using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoTrial.Data;

namespace WhoTrial.Logic
{
    public class HospitalLogic
    {
        private readonly IonicAppContext context;

        public HospitalLogic()
        {
            context = new IonicAppContext();
        }

    }
}
