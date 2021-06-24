using Day8.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            //String str1 = "Hello";
            //string str2 = "World";

            //Console.WriteLine(str1.GetType().FullName);
            //Console.WriteLine(str2.GetType().FullName);





            //var Name = "Osama";
            //var Date = DateTime.Now;

            //Console.WriteLine("Hello, {0}! Today is {1}, It's {2:HH,mm} now.",Name, Date.DayOfWeek, Date);
            //Console.WriteLine($"Hello, {Name}! Today is {Date.DayOfWeek}, It's {Date:yyyy/MM/dd , HH:mm:ss} now.");





            //var List = new List<int>(10) {5,2,19,63,26,55,129,42,46,88 };

            //foreach(var V in List)
            //{
            //    Console.WriteLine("Value {0} Is : {1}",List.IndexOf(V),V);
            //}

            //Console.WriteLine("\n\n***** Square *****");
            //foreach (var V in List)
            //{
            //    Console.WriteLine("Value Number {0} ({1}^2) Is : {2}", List.IndexOf(V),V, Math.Pow(V,2));
            //}

            //Console.WriteLine("\n\n***** Divisible By 3  *****");
            //foreach (var V in List.FindAll(a=>a%3 == 0))
            //{
            //    Console.WriteLine("Value Number {0} ({1} / 3) = {2}", List.IndexOf(V),V, V/3);
            //}








            //var Deteils = new List<Student>(5)
            //{
            //    new Student{ RollNo = 1,Name="Osama" },
            //    new Student{ RollNo = 2,Name="Ahmad" },
            //    new Student{ RollNo = 3,Name="Mahmood" },
            //    new Student{ RollNo = 4,Name="Mohammad" },
            //    new Student{ RollNo = 5,Name="Esa" },
            //};

            //var NewDetails = Deteils.OrderBy(a=>a.Name);

            //foreach(var Value in NewDetails)
            //{
            //    Console.WriteLine("Index ({0}) / {1} : {2}", Array.IndexOf(NewDetails.ToArray(),Value), Value.RollNo,Value.Name);
            //}




            //double Number 1 : Type Of Parameter
            //double Number 2 : Type Of Output
            //Func<double, double> func = x => 
            //{
            //    var S = x * 2;
            //    return S; 
            //};

            //Console.WriteLine(func(3));





            //Console.WriteLine("\n\n\n");
            ////Construction
            //Teacher teacher = new Teacher();

            //Console.WriteLine("\n\n\n");
            ////Construction Age
            //teacher = new Teacher(24);


            //Console.WriteLine("\n\n\n");
            ////Construction Name & Age
            //teacher = new Teacher("Osama", 24);




            //Library library = new Library();
            //library.Dispose();


            Cat cat = new Cat();

            cat = new Cat("Cat",1,2);
        }
    }
}
