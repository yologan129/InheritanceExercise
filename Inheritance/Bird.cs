using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }

        public bool CanFly{ get; set; }
        public bool HasFeathers { get; set; }
        public bool DoMigrate { get; set; }
        public bool LaysEggs { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"{CanFly}{HasFeathers}{DoMigrate}{LaysEggs}");
        }

   
    


    }
}
