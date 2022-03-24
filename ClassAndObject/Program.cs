using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApps
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat object taksi
            Taxi ungu = new Taxi();
            //pengesetan nilai properties
            ungu.Name = "bejon";
            ungu.Status = true;
            ungu.Passenger = 3;

            //pemanggilan method
            ungu.TaxiInfo();
            ungu.PickUpPassenger();
            ungu.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
