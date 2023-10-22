using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Cat :Animal
    {
        // This is Unique Property for cat
        public bool HasGreenEyes { get; }

        //This is constructor for Cat, it takes parametrs to initialize propeties inherited from Animal.
        //The constructor also calls the base class constructor base to intialize the common properties
        public Cat(string name, string color, string gender, string sound, int size, bool hasGreenEyes) :base (name, color,gender, sound, size)
        {
            HasGreenEyes = hasGreenEyes;
           
        }
        public override void MakeSound()// That method inherited from animal class
        {
            Console.WriteLine("katten Jamar");
        }
        public void Climb()// This is unique method for cat
        {
            Console.WriteLine("Katten kan klättra"); 
        }

        public override void Eat()// That method inherited from animal class
        {
            Console.WriteLine("Katten äter fisk");
        }

        public override void Sleep()// That method inherited from animal class
        {
            Console.WriteLine("Katten sover på höbalen\n");
        }
    }
}
