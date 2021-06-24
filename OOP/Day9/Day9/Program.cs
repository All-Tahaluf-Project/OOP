using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day9
{
    class Program
    {

        static void Main(string[] args)
        {
            Operations operations = new Operations();

            Console.WriteLine("***** Department *****");
            Console.WriteLine("***** 1 To Insert *****");
            Console.WriteLine("***** 2 To Update *****");
            Console.WriteLine("***** 3 To Delete *****");
            Console.WriteLine("***** 4 To Display ALL Departments *****");
            Console.WriteLine("***** 5 To Search Department By Id *****\n\n");

            Console.WriteLine("***** Employee *****");
            Console.WriteLine("***** 6 To Insert *****");
            Console.WriteLine("***** 7 To Update *****");
            Console.WriteLine("***** 8 To Delete *****");
            Console.WriteLine("***** 9 To Display ALL Employees *****");
            Console.WriteLine("***** 10 Search By Name *****");
            Console.WriteLine("***** 11 To Search Employee By Id *****\n\n");

            Console.WriteLine("****** Get All Informations (12) *****");

            Console.WriteLine("### Enter 0 To Stop ###");
            int MyProcess = 0;
            try
            {
                Console.Write("\n\n\nEnter Your Process : ");
                MyProcess = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter Number Please...");
                Console.WriteLine("Restart Project If You Want Continue\n\n");
            }

            while (MyProcess != 0)
            {
                switch (MyProcess)
                {
                    case 1:
                        { operations.InsertDepartment(); break; }
                    case 2:
                        { operations.UpdateDepartment(); break; }
                    case 3:
                        { operations.DeleteDepartment(); break; }
                    case 4:
                        { operations.DisplayALLDepartments(); break; }
                    case 5:
                        { operations.SearchDepartmentById(); break; }
                    case 6:
                        { operations.InsertEmployee(); break; }
                    case 7:
                        { operations.UpdateEmployee(); break; }
                    case 8:
                        { operations.DeleteEmployee(); break; }
                    case 9:
                        { operations.DisplayALLEmployees(); break; }
                    case 10:
                        { operations.SearchByName(); break; }
                    case 11:
                        { operations.SearchById(); break; }
                    case 12:
                        { operations.GetAllInformation(); break; }
                }


                try
                {
                    Console.Write("\n\n\nEnter Your Process : ");
                    MyProcess = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter Number Please...");
                    MyProcess = 100;
                }
            }

        }
    }
}
