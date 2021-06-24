using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Classes
{
    public class Exercise
    {
        public void Show<TypeOfValue>(string msg,TypeOfValue value)
        {
            Console.WriteLine("{0}: {1}",msg,value);
        }
    }
}
