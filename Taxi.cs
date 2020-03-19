using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Taxi
    {
        public string DriverName;
        public bool OnDuty;
        public int NumPassenger;
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}  ", this.DriverName );
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else
            {
                Console.WriteLine("On Duty : No");
            }
            Console.WriteLine("Number of Passenger : {0}  ", this.NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("Joni sedang menjemput penumpang");
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("Joni sedang mengantar penumpang");
        }
    }

}
