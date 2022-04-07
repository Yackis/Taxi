using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApps;

namespace Taxi_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Taxi ungu = new Taxi();

            Console.WriteLine("--- DATA DRIVER TAXI ---");
            Console.WriteLine();

            Console.Write("Nama Driver :  ");
            ungu.Name = Console.ReadLine();

            Console.Write("On Duty [Yes or No] :  ");
            ungu.Status = Console.ReadLine().ToLower() == "yes" ? true : false;

            if (ungu.Status)
            {
                Console.Write("Number of Passanger:  ");
                ungu.Passenger = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                ungu.TaxiInfo();
                ungu.PickUpPassenger();
                ungu.DropOffPassenger();
            }
            else
            {
                Console.WriteLine();
                ungu.TaxiInfo();
                ungu.PickUpPassenger();
            }

            Console.ReadKey();

        }
    }
}