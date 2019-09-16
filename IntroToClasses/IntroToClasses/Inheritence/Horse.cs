using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToClasses.Inheritence
{
    class Horse : Animal
    {
        public override void MakeAnimalSound()
        {
            Console.WriteLine("Neeeeeh!");
        }
        public override void PerformAnimalAction()
        {
            Console.WriteLine("Swat flies with tail.");
        }
    }
}
