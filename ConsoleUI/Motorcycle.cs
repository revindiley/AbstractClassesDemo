﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }


        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is swerving");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcycle's virtual drive method ");
        }
    }
}
