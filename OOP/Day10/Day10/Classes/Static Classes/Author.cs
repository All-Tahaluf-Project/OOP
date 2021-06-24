using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.Classes.Static_Classes
{
    static class Author
    {
        public static void Details()
        {
            Console.WriteLine("The Details Of Author Is :");
        }
    }


    class Employee
    {
        public void Greet()
        {
            Console.WriteLine("Hello Everyone.");
        }
    }


    static class Country
    {
        public static string CountryName = "Jordan";
        public static int NoOfStates = 12;

        public static int GetNoOfUnionTerritories()
        {
            return 1;
        }
    }
}
