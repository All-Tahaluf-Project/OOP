using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            //var ListOfChar = new List<char>
            //{
            //    'A', 'B', 'C', 'D','E','F','G','A','A'
            //};

            //foreach(var MyChar in ListOfChar)
            //{
            //    Console.WriteLine("Character Value Number Of {0} Is : {1}", ListOfChar.IndexOf(MyChar),MyChar);
            //}

            //Console.WriteLine("Enter Any String Value To Stop Loop.");
            //while(true)
            //{
            //    try
            //    {
            //        Console.Write("Enter Your Character : ");
            //        var MyChar = Convert.ToChar(Console.ReadLine());
            //        Console.WriteLine("Number Of {0} : {1}" ,MyChar,
            //            // ListOfChar.Count(a=>a == MyChar)
            //           ( from Char in ListOfChar
            //            where Char == MyChar
            //            select Char).Count()
            //            );
            //    }catch
            //    {
            //        break;
            //    }
            //}


            Console.Write("Enter Your String : ");
            var MyString = Console.ReadLine();

            foreach(var MyChar in MyString)
            {
                Console.WriteLine("Character Value Number Of {0} Is : {1}", MyString.IndexOf(MyChar), MyChar);
            };

            foreach(var Char in MyString)
            {
                Console.WriteLine("\nNumber Of Character ({0}) Is : {1}", Char,
                                   (from C in MyString
                                    where C == Char
                                    select C).Count()
                                    );
            }

            var ListOfInt = new List<int>();

            Console.WriteLine("\n\n\n\nEnter Any Value not Integer Type To Stop Loop.");
            while (true)
            {
                try
                {
                    Console.Write("Enter Your Number : ");
                    var MyInteger = Convert.ToInt32(Console.ReadLine());

                    ListOfInt.Add((MyInteger + 2) * 5);
                }
                catch
                {
                    break;
                }
            }

            Console.WriteLine("\n\n");
            foreach (var MyInt in ListOfInt)
            {
                Console.WriteLine("Integer Value Number Of {0} Is : {1}", ListOfInt.IndexOf(MyInt), MyInt);
            }
        }
    }
}
