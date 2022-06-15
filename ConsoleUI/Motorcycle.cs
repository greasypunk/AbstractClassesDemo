using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            hasWindows = false;
        }

        public bool looksCool { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("oh what a nice motorbike");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("yeee haww!");
        }
    }
}
