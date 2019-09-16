using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToClasses.Inheritence
{
    abstract class Animal
    {
        #region Fields and Properties

        private string _animalName;
        public string AnimalName { get { return _animalName; }}
        public string Color { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        
        #endregion

        /// <summary>
        /// Constructor for the Animal Class, this is ALWAYS called when an animal is created
        /// </summary>
        public Animal(){
            this._animalName = this.ToString();
        }

        public void Sleep()
        {
            Console.WriteLine("Zzz Zzz Zzz from Animal Base Class");
        }

        public virtual void MakeAnimalSound()
        {
            Console.WriteLine("Raaaaaawwrrrrr from Animal Base Class");
        }

        public abstract void PerformAnimalAction();

    }
}
