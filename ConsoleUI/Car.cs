using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {
            hasWindows = true;
        }
        public bool hatchback { get; set; } = false;

        public override void DriveAbstract()
        {
            //throw new NotImplementedException();
            Console.WriteLine("time to go to the mall");
        }
    }
}
