using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }
    }

    public class Bird:Animal
    {
        public void Fly()
        {
            Console.WriteLine("Birds fly");

        }
    }

    public class Parrot:Bird
    {
        public void Speak()
        {
            Console.WriteLine("Parrots speak");
        }
    }

    public class Fish:Animal
    {
        public void Swim()
        {
            Console.WriteLine("Fish swim");
        }
    }


    public class BabyShark:Fish
    {
        public void Sing()
        {
            Console.WriteLine("Babyshark is singing");
        }
    }
}
