using System;

namespace TaxiApps
{
    public class Taxi
    {
        //membuat properti
        public string Name { get; set; }
        public bool Status { get; set; }
        public int Passenger { get; set; }

        //membuat method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", Name);
            Console.WriteLine("On Duty Status : {0}", Status);
            Console.WriteLine("Number of Passenger : {0}", Passenger);
        }

        public void PickUpPassenger()
        {
            Console.WriteLine("{0} On Duty picking up passenger", Name);
        }

        public void DropOffPassenger()
        {
            Console.WriteLine("{0} Done droping off passenger", Name);
        }
    }
}