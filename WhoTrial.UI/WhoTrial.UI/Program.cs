using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoTrial.Entities;
using WhoTrial.Logic;

namespace WhoTrial.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonthLogic monthLogic = new MonthLogic();

            foreach(Month month in monthLogic.GetAll())
            {
                Console.WriteLine($"{month.Id_Month} - {month.Detail}");
            }

            Console.ReadLine(); 
        }
    }
}
