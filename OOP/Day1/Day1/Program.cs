using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day1.Classes;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee
            //var Employee = new Employee(0, "Osama", 860);

            //var Employees = new Employee[10];

            //for(int i = 0;i<Employees.Length;i++)
            //{
            //    Employees[i] = new Employee(i,"Name"+i,i*10); 
            //}

            //for (int i = 0; i < Employees.Length; i++)
            //{
            //    Console.WriteLine("Id : " +  Employees[i].Id + "Name : " + Employees[i].Name , "Salary : " + Employees[i].Salary);
            //}

            //Console.WriteLine("Id : " + Employee.Id + " Name : " + Employee.Name + " Salary : " + Employee.Salary);

            //Console.WriteLine("By Method : " + Employee.GetSalary());






            //Student Class
            //var Student = new Student(0, "Osama", 90);


            //Console.WriteLine("Id : " + Student.Id + "Name : " + Student.Name + " GPA : " + Student.GPA + " GetGPA : " + Student.GetGPA(2));








            //Car Class
            try
            {
                Console.Write("Input Id : ");
                var Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input Make : ");
                var Make = Console.ReadLine();

                Console.Write("Input Model : ");
                var Model = Console.ReadLine();

                Console.Write("Input Registration : ");
                var Registration = Console.ReadLine();

                Console.Write("Input Year : ");
                var Year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input Current Value : ");
                var CurrentValue = Convert.ToDouble(Console.ReadLine());

                var car = new Car(0, "Make", "Model", "Registration", Year, CurrentValue);

                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("***** Current Value *****");
                Console.WriteLine(car.GetCurrentValue(car.Id));
                Console.WriteLine("***** Year *****");
                Console.WriteLine(car.GetYearOfCar(car.Id));
                Console.WriteLine("***** Full Info *****");
                Console.WriteLine(car.GetFullInfo(car.Id));
            }
            catch
            {
                Console.WriteLine("Make Sure Type Of Value");
            }
        }
    }
}
