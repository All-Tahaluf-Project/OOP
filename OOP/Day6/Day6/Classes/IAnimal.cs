using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Classes
{
    interface IAnimal1
    {
        void AnimalSound();
        void AnimalEat();
        void AnimalMove();

    }

    interface IAnimal2
    {
        void AnimalMove();
    }

    class Bee : IAnimal1, IAnimal2
    {
        public void AnimalSound()
        {
            Console.WriteLine("The Bee Says : Buzzz.");
        }

        public void AnimalEat()
        {
            Console.WriteLine("Bee Eat Flower Nectar."); ;
        }
        public void AnimalMove()
        {
            Console.WriteLine("Bee Flies. (Bee)");
        }


        void IAnimal1.AnimalMove()
        {
            Console.WriteLine("Bee Flies. (IAnima1)");
        }

        void IAnimal2.AnimalMove()
        {
            Console.WriteLine("Bee Flies. (IAnima2)");
        }
    }

    class Cat : IAnimal1, IAnimal2
    {
        public void AnimalSound()
        {
            Console.WriteLine("The Cat Says : Maui.");
        }

        public void AnimalEat()
        {
            Console.WriteLine("Cat Eat Fish."); ;
        }

        public void AnimalMove()
        {
            Console.WriteLine("Cat Walk. (Cat)");
        }

        void IAnimal1.AnimalMove()
        {
            Console.WriteLine("Cat Walk. (IAnimal1)");
        }

        void IAnimal2.AnimalMove()
        {
            Console.WriteLine("Cat Walk. (IAnimal2)");
        }
    }
}
