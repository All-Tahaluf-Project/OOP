using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Day9
{
    class Operations
    {
        public Operations()
        {

        }

        //Department Table
        public void InsertDepartment()
        {
            ConsoleOOPDay9Entities _context = new ConsoleOOPDay9Entities();

            SqlConnection SQLConnection;
            string SQLConnectionString = "Data Source=.;Initial Catalog=ConsoleOOPDay9;Integrated Security=True";

            try
            {
                SQLConnection = new SqlConnection(SQLConnectionString);
                var Department = new Department();

                SQLConnection.Open();

                Console.Write("Please Enter Department Name : ");
                Department.Name = Console.ReadLine();

                Console.Write("Please Enter Department Location : ");
                Department.Location = Console.ReadLine();

                Department.Id = _context.Department.Max(a => a.Id) + 1;
                string Query = $"INSERT INTO Department (Id,Name,Location)VALUES({Department.Id},'{Department.Name}','{Department.Location}')";
                SqlCommand sqlCommand = new SqlCommand(Query, SQLConnection);
                sqlCommand.ExecuteNonQuery();

                Console.WriteLine("Add Department Is Success\n\n");
                SQLConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nAdd Department Is UnSuccess");
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateDepartment()
        {
            ConsoleOOPDay9Entities _context = new ConsoleOOPDay9Entities();

            SqlConnection SQLConnection;
            string SQLConnectionString = "Data Source=.;Initial Catalog=ConsoleOOPDay9;Integrated Security=True";

            try
            {
                SQLConnection = new SqlConnection(SQLConnectionString);
                SQLConnection.Open();

                Console.Write("Enter Department Id : ");
                var Id = Convert.ToInt32(Console.ReadLine());
                var Department = _context.Department.FirstOrDefault(a => a.Id == Id);

                if(Department == null)
                {
                    Console.WriteLine("\n\nDepartment Is Not Found.\n");
                }else
                {
                    Console.Write("Please Enter New Department Name : ");
                    var Name = Console.ReadLine();
                    if (Name != "") { Department.Name = Name; }

                    Console.Write("Please Enter New Department Location : ");
                    var Location = Console.ReadLine();
                    if (Location != "") { Department.Name = Location; }

                    string Query = $"UPDATE Department SET Name = '{Department.Name}',Location = '{Department.Location}' WHERE Id = {Id};";
                    SqlCommand sqlCommand = new SqlCommand(Query, SQLConnection);
                    sqlCommand.ExecuteNonQuery();


                    Console.WriteLine("Update Department Is Success.\n\n");
                    SQLConnection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nUpdate Employee Is UnSuccess.");
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteDepartment()
        {
            ConsoleOOPDay9Entities _context = new ConsoleOOPDay9Entities();

            SqlConnection SQLConnection;
            string SQLConnectionString = "Data Source=.;Initial Catalog=ConsoleOOPDay9;Integrated Security=True";

            try
            {
                SQLConnection = new SqlConnection(SQLConnectionString);

                SQLConnection.Open();

                Console.Write("Enter Department Id : ");
                var Id = Convert.ToInt32(Console.ReadLine());

                var Department = _context.Department.FirstOrDefault(a => a.Id == Id);

                if(Department == null)
                {
                    Console.WriteLine("\n\nDepartment Is Not Found.\n");
                }else
                {
                    if(Department.Employee.Any())
                    {
                        Console.WriteLine("\n\nThat Department Has Employees.\n");

                        Console.WriteLine("***** List Of Empalyees *****\n");
                        foreach (var E in Department.Employee)
                        {
                            Console.WriteLine($"Id : {E.Id} , Full Name : {E.FirstName} {E.LastName} , Gender : {E.Gender} , Salary : {E.Salary} , Department Name : {E.Department.Name}");
                        }
                    }
                    else
                    {
                        string Query = $"DELETE FROM Department WHERE Id = {Id};";

                        SqlCommand sqlCommand = new SqlCommand(Query, SQLConnection);
                        sqlCommand.ExecuteNonQuery();
                        Console.WriteLine("\n\nDelete Department Is Success.\n");
                        SQLConnection.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nDelete Department Is UnSuccess");
                Console.WriteLine(e.Message);
            }
        }

        public void DisplayALLDepartments()
        {
            ConsoleOOPDay9Entities _context = new ConsoleOOPDay9Entities();


            Console.Clear();
            Console.WriteLine("\n\n***** List Of Departments *****\n");
            foreach(var D in _context.Department)
            {
                Console.WriteLine($"Name : {D.Name} , Location : {D.Location} \n");
            }
        }

        public void SearchDepartmentById()
        {
            ConsoleOOPDay9Entities _context = new ConsoleOOPDay9Entities();

            try
            {
                Console.Write("Enter Department Id : ");
                var Id = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("\n\n\n***** Department Informations *****\n\n");
                var Department = _context.Department.FirstOrDefault(a => a.Id == Id);

                if (Department == null) { Console.WriteLine("Department Is Not Found."); }
                else
                {
                    Console.WriteLine($"Name : {Department.Name} , Location : {Department.Location}\n");

                    Console.WriteLine("\n\n***** List Of Empalyees *****\n");
                    foreach (var E in Department.Employee)
                    {
                        Console.WriteLine($"Id : {E.Id} , Full Name : {E.FirstName} {E.LastName} , Gender : {E.Gender} , Salary : {E.Salary} , Department Name : {E.Department.Name}");
                    }
                    Console.WriteLine("\n\n");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\n\nError");
                Console.WriteLine("Details : " + e.Message);
            }
        }


        //Employee Table

        public void InsertEmployee()
        {
            ConsoleOOPDay9Entities _context = new ConsoleOOPDay9Entities();

            SqlConnection SQLConnection;
            string SQLConnectionString = "Data Source=.;Initial Catalog=ConsoleOOPDay9;Integrated Security=True";

            try
            {
                SQLConnection = new SqlConnection(SQLConnectionString);
                var Employee = new Employee();

                SQLConnection.Open();

                Console.Write("Please Enter Employee Frist Name :");
                Employee.FirstName = Console.ReadLine();

                Console.Write("Please Enter Employee Last Name :");
                Employee.LastName = Console.ReadLine();

                Console.Write("Please Enter Employee Gender :");
                Employee.Gender = Console.ReadLine();

                Console.Write("Please Enter Employee Salary :");
                Employee.Salary = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please Enter Employee Department Id :");
                Employee.DepartmentId = Convert.ToInt32(Console.ReadLine());

                Employee.Id = _context.Employee.Max(a => a.Id)+1;
                string Query = $"INSERT INTO Employee (Id,FirstName, LastName, Gender, Salary,DepartmentId)VALUES({Employee.Id},'{Employee.FirstName}', '{Employee.LastName}', '{Employee.Gender}',{Employee.Salary},{Employee.DepartmentId})";

                SqlCommand sqlCommand = new SqlCommand(Query, SQLConnection);
                sqlCommand.ExecuteNonQuery();


                Console.WriteLine("\n\nAdd Employee Is Success");
                SQLConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nAdd Employee Is UnSuccess");
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateEmployee()
        {
            ConsoleOOPDay9Entities _context = new ConsoleOOPDay9Entities();

            SqlConnection SQLConnection;
            string SQLConnectionString = "Data Source=.;Initial Catalog=ConsoleOOPDay9;Integrated Security=True";

            try
            {
                SQLConnection = new SqlConnection(SQLConnectionString);

                SQLConnection.Open();

                Console.Write("Enter Employee Id : ");
                var Id = Convert.ToInt32(Console.ReadLine());
                var Employee = _context.Employee.FirstOrDefault(a => a.Id == Id);

                if (Employee == null) { Console.WriteLine("Employee Is Not Found."); }
                else
                {
                    Console.Write("Please Enter New Employee Frist Name :");
                    var FirstName = Console.ReadLine();
                    if (FirstName != "") { Employee.FirstName = FirstName; }

                    Console.Write("Please Enter New Employee Last Name :");
                    var LastName = Console.ReadLine();
                    if (LastName != "") { Employee.LastName = LastName; }

                    Console.Write("Please Enter New Employee Gender :");
                    var Gender = Console.ReadLine();
                    if (Gender != "") { Employee.Gender = Gender; }

                    Console.Write("Please Enter New Employee Salary (Enter -1 To not edit) :");
                    var Salary = Convert.ToInt32(Console.ReadLine());
                    if (Salary != -1) { Employee.Salary = Salary; }

                    Console.Write("Please Enter New Employee Department Id :");
                    var DepartmentId = Convert.ToInt32(Console.ReadLine());
                    if (DepartmentId != -1) { Employee.DepartmentId = DepartmentId; }

                    string Query = $"UPDATE Employee SET FirstName = '{Employee.FirstName}',LastName = '{Employee.LastName}',Gender = '{Employee.Gender}',Salary = {Employee.Salary},DepartmentId = {Employee.DepartmentId} WHERE Id = {Id};";

                    SqlCommand sqlCommand = new SqlCommand(Query, SQLConnection);
                    sqlCommand.ExecuteNonQuery();


                    Console.WriteLine("\n\nUpdate Employee Is Success");
                    SQLConnection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nUpdate Employee Is UnSuccess");
                Console.WriteLine(e.Message);
            }
        }

        public void DeleteEmployee()
        {
            ConsoleOOPDay9Entities _context = new ConsoleOOPDay9Entities();

            SqlConnection SQLConnection;
            string SQLConnectionString = "Data Source=.;Initial Catalog=ConsoleOOPDay9;Integrated Security=True";

            try
            {
                SQLConnection = new SqlConnection(SQLConnectionString);

                SQLConnection.Open();

                Console.Write("Enter Employee Id : ");
                var Id = Convert.ToInt32(Console.ReadLine());

                var Employee = _context.Employee.FirstOrDefault(a => a.Id == Id);

                if (Employee == null)
                {
                    Console.WriteLine("\n\nEmployee Is Not Found.\n");
                }
                else
                {

                    string Query = $"DELETE FROM Employee WHERE Id = {Id};";

                    SqlCommand sqlCommand = new SqlCommand(Query, SQLConnection);
                    sqlCommand.ExecuteNonQuery();


                    Console.WriteLine("\n\nDelete Employee Is Success");
                    SQLConnection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Delete Employee Is UnSuccess");
                Console.WriteLine(e.Message);
            }
        }

        public void DisplayALLEmployees()
        {
            ConsoleOOPDay9Entities _context = new ConsoleOOPDay9Entities();

            Console.Clear();
            Console.WriteLine("\n\n\n***** List Of Empalyees *****\n");
            foreach (var E in _context.Employee)
            {
                Console.WriteLine($"Full Name : {E.FirstName} {E.LastName} , Gender : {E.Gender} , Salary : {E.Salary} , Department Name : {E.Department.Name}"); 
            }
        }

        public void SearchByName()
        {
            ConsoleOOPDay9Entities _context = new ConsoleOOPDay9Entities();

            Console.Write("Enter Emplyee FirstName : ");
            var FirstName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\n\n\n***** List Of Empalyees *****\n\n");
            foreach (var E in _context.Employee.Where(a => a.FirstName.Contains(FirstName)))
            {
                Console.WriteLine($"Full Name : {E.FirstName} {E.LastName} , Gender : {E.Gender} , Salary : {E.Salary} , Department Name : {E.Department.Name}\n");
            }
        }

        public void SearchById()
        {
            ConsoleOOPDay9Entities _context = new ConsoleOOPDay9Entities();

            try
            {
                Console.Write("Enter Emplyee Id : ");
                var Id = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("\n\n\n***** Empalyee Informations *****\n\n");
                var Employee = _context.Employee.FirstOrDefault(a => a.Id == Id);

                if (Employee == null) { Console.WriteLine("Employee Is Not Found."); }
                else
                {
                    Console.WriteLine($"Full Name : {Employee.FirstName} {Employee.LastName} , Gender : {Employee.Gender} , Salary : {Employee.Salary} , Department Name : {Employee.Department.Name}\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nError");
                Console.WriteLine("Details : " + e.Message);
            }
        }

        //All Information
        public void GetAllInformation()
        {
            ConsoleOOPDay9Entities _context = new ConsoleOOPDay9Entities();

            Console.Clear();
            Console.WriteLine("\n\n***** All Information *****\n\n");

            foreach(var D in _context.Department)
            {
                Console.WriteLine("\n\n\n***** Department *****");
                Console.WriteLine($"Name : {D.Name} , Location : {D.Location}\n");
                Console.WriteLine("***** List Of Empalyees *****\n");

                foreach (var E in D.Employee)
                {
                    Console.WriteLine($"Full Name : {E.FirstName} {E.LastName} , Gender : {E.Gender} , Salary : {E.Salary} , Department Name : {E.Department.Name}");
                }
            }
        }
    }
}
