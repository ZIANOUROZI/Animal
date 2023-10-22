using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Bird :Animal
    {
        public bool CanFlyging { get; set; }// This is Unique Property for bird
        //This is constructor for Bird, it takes parametrs to initialize propeties inherited from Animal.
        //The constructor also calls the base class constructor base to intialize the common properties
        public Bird(string name, string color, string gender, string sound, int size, bool canFlyging = true) :base(name, color, gender, sound, size)
        {
            CanFlyging = canFlyging;
            
        }

        public override void Eat()// That method inherited from animal class
        {
            Console.WriteLine("Fågel äter mask");
        }

        public override void MakeSound()// That method inherited from animal class
        {
            Console.WriteLine("Fågeln Chech Chech");
        }
        public void Sing()// This is unique method for bird
        {
            Console.WriteLine("Fågel kan sjunga");
        }

        public override void Sleep()// That method inherited from animal class
        {
            Console.WriteLine("Fågel sover i sitt fågelbo\n");
        }
    }
}
