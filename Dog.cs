using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Dog :Animal
    {
        // This is Unique Property for dog years, the property is readonly and that cannot changed after it has been assigned in the constructor

        public int AgeInDogYears { get; }
        //This is constructor for dog, it takes parametrs to initialize propeties inherited from Animal.
        //The constructor also calls the base class constructor base to intialize the common properties.
        public Dog(string name, string color, string gender, string sound, int size, int ageInDagYears) :base(name, color, gender, sound, size)
        {
            AgeInDogYears = ageInDagYears;
        }
        
        public void Protection() // This is unique method for dog
        {

            Console.WriteLine("Hunden skyddar sina ägare"); 
        }

        public override void MakeSound() // That method inherited from animal class
        {
            Console.WriteLine("Hunden skäller");
        }

        public override void Eat() //That method interited from animal class
        {
            Console.WriteLine("Hunden äter kött");
        }

        public override void Sleep() //That method inherited from animal class
        {
            Console.WriteLine("Hunden sover i hundkojan\n");
        }
    }

}
