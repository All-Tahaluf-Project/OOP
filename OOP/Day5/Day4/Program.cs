using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day4.Classes;

namespace Day4
{
    class Program
    {
        //static bool IsAlphabetic(string Text)
        //{
        //    return Text.Where(c => !(c >= 'A' && c <= 'Z' || c >= 'a' && c <= 'z')).Count()==0;
        //}
        static void Main(string[] args)
        {
            //Console.Write("Input Your Text : ");
            //var Text = Console.ReadLine();

            //while (Text != "")
            //{
            //    if (IsAlphabetic(Text))
            //    {
            //        Console.WriteLine("***** ^_^ ***** \n\n\n (True) \n\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine("***** *_* ***** \n\n\n(False)\n\n");
            //    }

            //    Console.Write("Input Your Text : ");
            //    Text = Console.ReadLine();
            //}













            //var Dog = new Dog();

            //Console.Write("Input Dog Name : ");
            //Dog.SetName(Console.ReadLine());

            //Console.WriteLine("\n\n\nName Of Dog : {0}",Dog.GetName());
            //Dog.Eat();












            

            var Course_On_Site = new Course_On_Site("On Site",TimeSpan.Parse("00:08:00:00.0000000"),300,"Arabic",15);
            var Course_Prat_Time = new Course_Prat_Time("Prat Time", TimeSpan.Parse("00:08:00:00.0000000"), 300, TimeSpan.Parse("00:08:00:00.0000000"));

            Console.WriteLine("***** Course On Site *****");
            Console.WriteLine("***** Information *****");
            Course_On_Site.Print();

            Console.WriteLine("\n***** Total Feel ******");
            Console.WriteLine("Total Feel : {0}", Course_On_Site.GetTotalFeel());


            Console.WriteLine("\n\n\n***** Course Prat Time *****");
            Console.WriteLine("\n***** Information *****");
            Course_Prat_Time.Print();

            Console.WriteLine("\n***** Total Feel ******");
            Console.WriteLine("Total Feel : {0}" , Course_Prat_Time.GetTotalFeel());
        }
    }
}
