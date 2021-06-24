using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        class GenericClass<T>
        {
            public T[] ListOfMarks;
            private double[] DoubleArray;

            public GenericClass()
            {
                ListOfMarks = new T[5];
            }

            public bool RedirectToDouble()
            {
                try
                {
                    DoubleArray = Array.ConvertAll(ListOfMarks, s => double.Parse(s.ToString()));
                    return true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\nNot a Valid Format. Please Try Again.\n");
                    return false;
                }
            }

            public double GetAVG()
            {
                    return DoubleArray.Average();
            }

            public void GetAboveOfAVGList()
            {
                    foreach (var Value in DoubleArray.Where(a => a > DoubleArray.Average()))
                    {
                        Console.WriteLine(" Marke {0}", Value);
                    }

                    Console.WriteLine("Number Of Markes Is Above Avarage : {0}", DoubleArray.Where(a => a > GetAVG()).Count());
            }

            public void GetBelowOfAVGList()
            {
                    var DoubleArray = Array.ConvertAll(ListOfMarks, s => double.Parse(s.ToString()));

                    foreach (var Value in DoubleArray.Where(a => a < GetAVG()))
                    {
                        Console.WriteLine(" Marke {0}", Value);
                    }

                    Console.WriteLine("\n\nNumber Of Markes Is Below Avarage : {0}", DoubleArray.Where(a => a < DoubleArray.Average()).Count());
            }
        }

        static void SquareTwoNumbers(double Num1,double Num2)
        {
                Console.WriteLine("\nSquare Root For {0} : {1}\nSquare Root For {2} : {3} ", Num1, Math.Sqrt(Num1), Num2, Math.Sqrt(Num2));
        }

        static void Main(string[] args)
        {

            var GenericClass = new GenericClass<double>();

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Console.Write("Enter Value Number {0} : ", i+1);
                    GenericClass.ListOfMarks[i] = Convert.ToDouble(Console.ReadLine());
                    //GenericClass.ListOfMarks[i] = Console.ReadLine();
                    //GenericClass.ListOfMarks[i] = Convert.ToInt32(Console.ReadLine());
                    //GenericClass.ListOfMarks[i] = Convert.ToChar(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Not a Valid Format. Please Try Again.\n\n");
                    i--;
                }
            }

            if (GenericClass.RedirectToDouble())
            {
                Console.WriteLine("\n\n\n\n\n*** Average ***");
                Console.WriteLine("Average : " + GenericClass.GetAVG());

                Console.WriteLine("\n\n*** Above Of Average ***");
                GenericClass.GetAboveOfAVGList();

                Console.WriteLine("\n\n*** Below Of Average ***");
                GenericClass.GetBelowOfAVGList();
            }

            try
            {
                Console.WriteLine("\n\n\n\n*** Square Root ***");

                Console.Write("Enter First Number : ");
                var Num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("\n\nEnter Second Number : ");
                var Num2 = Convert.ToDouble(Console.ReadLine());
                SquareTwoNumbers(Num1, Num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error.\n");
                Console.WriteLine(ex.Message + "\n\n\n");
            }
        }
    }
}
