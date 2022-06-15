using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }

        public bool hasWindows { get; set; } = true;
        public string Make  {get; set;} = "Make";
        public string Model {get; set;} = "Model";
        public int Year { get; set;} = 1776;

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("god bless america");
        }
        


    }
}
