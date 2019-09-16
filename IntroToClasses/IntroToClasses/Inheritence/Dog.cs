using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToClasses.Inheritence
{
    class Dog : Animal
    {
        public override void MakeAnimalSound()
        {
            Console.WriteLine("Woof!");
        }
        public override void PerformAnimalAction()
        {
            Console.WriteLine("Chase Cat.");
        }
    }
}
