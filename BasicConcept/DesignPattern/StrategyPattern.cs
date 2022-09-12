using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConcept.DesignPattern
{
    public interface IBirdBehaviour
    {
        void Fly();
        void Eat();
    }

    public abstract class BirdBehaviour : IBirdBehaviour
    {
        public void Eat()
        {
            Console.WriteLine("Bird can eat...");
        }

        public void Fly()
        {
            Console.WriteLine("Fly can eat...");
        }

        public abstract void Walk();
    }
    public class Pegon : BirdBehaviour
    {
        public override void Walk()
        {
            Console.WriteLine(" Pegon Walk...");
        }
    }

    public class Crow : BirdBehaviour
    {
        public override void Walk()
        {
            Console.WriteLine();
        }
    }
}
