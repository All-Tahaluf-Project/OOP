using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Classes
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            Id = 0;
            Name = "";
            Salary = 0.0;
        }

        public Employee (int id ,string name,float salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public double GetSalary()
        {
            return Salary;
        }

    }
}
