using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classes
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("Person Say : Hi.");
        }

        ~Person()
        {
            Console.WriteLine("Person Destructure Was Called.");
        }
    }


    class Teacher : Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Teacher()
        {
            Console.WriteLine("Teacher Say: Hi.");
            Name = "";
            Age = 0;
        }

        public Teacher(int age): this()
        {
            Age = age;
            Console.WriteLine("My Age Is {0}", age);
        }

        public Teacher(string name,int age) :this(age)
        {
            Name = name;
            Console.WriteLine("My Name Is : {0}",name);
        }

        ~Teacher()
        {
            Console.WriteLine("Teacher Destructure Was Called.");
        }
    }
}
