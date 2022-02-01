using System;
using WhoTrial.Common.Models;
using WhoTrial.Logic;

namespace WhoTrial.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            IHospitalLogic hospitalLogic = new HospitalLogic();
            foreach(HospitalModel hosp in hospitalLogic.GetAll())
            {
                Console.WriteLine($"{hosp.Id}: {hosp.Detail} -- {hosp.CountryDetail}");
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(hospitalLogic.GetById(3).Detail);

            Console.ReadKey();
        }
    }
}
