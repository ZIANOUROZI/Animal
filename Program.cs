using System.Security.Cryptography.X509Certificates;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I creat three different animal instances and calls their methods to disply their behaviors
            Dog MyDog = new Dog("Dores", "Svart", "Male", "Wooff ", 5, 2010);
            Cat MyCat = new Cat("Asta", "Vit", "Male", "Mejoo", 10, true);
            Bird MyBird = new Bird("Asman", "Blå", "Male", "tjip", 12);
           
            Console.WriteLine("My Dog");
            MyDog.MakeSound();
            MyDog.Protection();
            MyDog.Eat();
            MyDog.Sleep();           
            
            Console.WriteLine("My Cat");
            MyCat.MakeSound();
            MyCat.Climb();
            MyCat.Eat();
            MyCat.Sleep();

            Console.WriteLine("My Bird");
            MyBird.MakeSound();
            MyBird.Sing();
            MyBird.Eat();
            MyBird.Sleep();
        }
    }
}