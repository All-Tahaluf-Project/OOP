using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Classes
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }

        public Student(int id,string name,double gPA)
        {
            Id = id;
            Name = name;
            GPA = gPA;
        }

        public double GetGPA(int _id)
        {
            if(_id == Id)
            {
                return GPA;
            }
            else
            { return 0; }
        }
    }
}
