using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Classes
{
    public class A
    {
        public A(int Number)
        {
            Console.WriteLine("Start Class A : " + Number);
        }

    }

    public class B : A
    {
        public B(int Number) : base(Number)
        {
            Console.WriteLine("Start Class B : " + Number);
        }
    }
}
