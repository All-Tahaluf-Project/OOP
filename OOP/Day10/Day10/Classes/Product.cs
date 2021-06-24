using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.Classes
{
    class Product
    {
        public int ProductId;
        public string ProductName;
        public double Cost;
        public int QuantityInStock;
        public static int TotalNumProducts;


        public Product()
        {
            Console.WriteLine("Default Constructor.");
        }

        public static void SetTotalNumProduct(int Value)
        {
            TotalNumProducts = Value;
        }

        public static int GetTotalNumProduct()
        {
            return TotalNumProducts;
        }

        public void MethodeToAccessStaticFields()
        {
            TotalNumProducts = 0;
            Product.TotalNumProducts = 0;
        }
    }
}
