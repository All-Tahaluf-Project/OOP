using Day10.Classes;
using Day10.Classes.Static_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product product1 = new Product();
            //Product.TotalNumProducts++;
            //Product product2 = new Product();
            //Product.TotalNumProducts++;
            //Product product3 = new Product();
            //Product.TotalNumProducts++;
            //Console.WriteLine($"Total Number Of Products : {Product.TotalNumProducts}");





            //Product product1 = new Product();
            //Product.SetTotalNumProduct(Product.TotalNumProducts + 1);

            //Product product2 = new Product();
            //Product.SetTotalNumProduct(Product.TotalNumProducts + 1);

            //Product product3 = new Product();
            //Product.SetTotalNumProduct(Product.TotalNumProducts + 1);

            //Console.WriteLine($"Total Number Of Products : {Product.TotalNumProducts}");



            //Employee employee = new Employee();
            //employee.Greet();
            //Author.Details();






            //Console.WriteLine("Name : " + Country.CountryName);
            //Console.WriteLine("States : " + Country.NoOfStates);
            //Country.GetNoOfUnionTerritories();





            Book obook = new Book(100);
            Book o2book = obook;

            Console.WriteLine(obook.Id);
            Console.WriteLine(o2book.Id);
            obook.Id = 150;
            Console.WriteLine("\n\n");

            Console.WriteLine(obook.Id);
            Console.WriteLine(o2book.Id);
            Console.WriteLine("\n\n");


            int x = 100;
            int y = x;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
            Console.WriteLine("\n\n");

            x = 150;

            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }
    }
}
