using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoTrial.Data;

namespace WhoTrial.Logic
{
    public class BaseLogic
    {
        protected readonly IonicAppContext context;
        public BaseLogic()
        {
            context = new IonicAppContext();
        }
    }
}
