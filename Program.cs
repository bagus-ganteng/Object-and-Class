using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat object taxi
            Taxi taxi = new Taxi();

            //set nilai properties
            taxi.DriverName = "Joni";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //panggil method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
       
        }
    }
}
