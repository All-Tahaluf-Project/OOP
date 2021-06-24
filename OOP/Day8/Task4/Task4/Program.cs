using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static bool IsPalindrome(string Text)
        {
            Text = Text.ToLower();
            var ArrayOfChar = Text.ToArray();
            Array.Reverse(ArrayOfChar);

            return new string(ArrayOfChar) == Text;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("### Just Enter Press To Stop ###");
            Console.Write("Input Your Text : ");
            var MyText = Console.ReadLine();

            while (true)
            {
                if (MyText == "") { break; }

                if (IsPalindrome(MyText))
                {
                    Console.WriteLine("***** Your Text Is Palindrome ***** ^_^");
                }
                else
                {
                    Console.WriteLine("!!! Your Text Is Not Palindrome !!! *_*");
                }

                Console.Write("\n\n\nInput Your Text : ");
                MyText = Console.ReadLine();
            }
        }
    }
}
