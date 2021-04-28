using System;

namespace NestedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();

            Animal.Cat c = new Animal.Cat();
            c.print();


            Console.ReadKey();
        }
    }
    class Animal
    {
        private static string voice = "Sommething";
        public class Cat
        {
            public void print()
            {
               // Console.WriteLine("CAT CLASS");
                Console.WriteLine(Animal.voice="Meow!");               
            }
        }
    }
}
