using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal abstract class  Animal
    {
        // Thes are propurties that store infromation about animal.
        public string Name { get; } 
        public string Color { get; }
        public string Gender { get;  }
        public string Sound { get; }
        public int Size { get; }

        // This is constructor of the animal and that parameters initialize properties of the animal.
        public Animal(string name, string color, string gender, string sound, int size) 
        {
            Name = name;
            Color = color;
            Gender = gender;
            Sound = sound;
            Size = size;
        }        
        public abstract void MakeSound(); // This is method for sound
        public abstract void Eat(); // This is method for Eat
        public abstract void Sleep(); // This is method for sleep              
    }
}
