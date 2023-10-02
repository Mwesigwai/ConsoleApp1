using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IFlyable
    {
        void Fly();
    }
    public abstract class Animal
    {
        public abstract void Eat();
        public abstract void Sleep();
    }

    public class Lion : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Lion...Here I am, I eat meat");
        }
        public override void Sleep()
        {
            Console.WriteLine("I sleep in the den\n");
        }
    }

    public class Elephant:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("As an elephant, I eat grass");
        }
        public override void Sleep()
        {
            Console.WriteLine("I sleep on the ground \n");
        }
    }

    public class Bird : Animal, IFlyable
    {
        public override void Eat()
        {
            Console.WriteLine("Hello, I am a bird, I eat like this...");
        }

        public override void Sleep()
        {
            Console.WriteLine("I sleep in nests or on trees");
        }
        public void Fly()
        {
            Console.WriteLine("I am flying from bird\n");
        }
    }

    public class Plane:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I am a plane flying from plane class");
            
        }
    }
}
