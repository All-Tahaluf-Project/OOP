using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classes
{
    class ZooAnimal
    {
        public string Name { get; set; }
        public int CageNumber { get; set; }
        public int NumAnimals { get; set; }
        public ZooAnimal()
        {

        }

        public ZooAnimal(string name,int cageNumber, int numAnimals)
        {
            Name = name;
            CageNumber = cageNumber;
            NumAnimals = numAnimals;
        }

        ~ZooAnimal()
        {
            Console.WriteLine("Destructure Is Done");
        }
    }

    class Cat : ZooAnimal
    {
        public Cat():base()
        {

        }

        public Cat(string name, int cageNumber, int numAnimals) : base(name,cageNumber,numAnimals)
        {
            Name = name;
            Console.WriteLine("My Name Is : {0}", name);
        }
    }
}
