using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Classes
{
    abstract class Animal
    {
        private string Name { get; set; }

        public void SetName(string _name)
        {
            Name = _name;
        }

        public string GetName()
        {
            return Name;
        }

        public abstract void Eat();
    }

    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The Dog Is Eating.");
        }
    }
}
