using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4.Classes
{
    abstract class Course
    {
        public string Name { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal Fees { get; set; }

        public Course(string _name, TimeSpan _duration,decimal _fees)
        {
            Name = _name;
            Duration = _duration;
            Fees = _fees;
        }

        public virtual void Print()
        {
            Console.WriteLine("Name : {0}",Name);
            Console.WriteLine("Duration : {0}", Duration);
            Console.WriteLine("Fees : {0}", Fees);
        }

        public abstract double GetTotalFeel();

    }

    class Course_Prat_Time : Course
    {
        public TimeSpan Time_Course { get; set; }
        public Course_Prat_Time(string _name, TimeSpan _duration, decimal _fees, TimeSpan _timeSpan) 
            : base (_name,_duration,_fees) 
        {
            Time_Course = _timeSpan;
        }

        public override double GetTotalFeel()
        {
            return Convert.ToDouble(Fees) * 1.1;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Time Course : {0}", Time_Course);
        }
    }

    class Course_On_Site :Course
    {
        public string Company_Name { get; set; }
        public int Number_Of_Students { get; set; }
        public Course_On_Site(string _name, TimeSpan _duration, decimal _fees, string _company_Name, int _number_Of_Students) 
            : base(_name, _duration, _fees)
        {
            Company_Name = _company_Name;
            Number_Of_Students = _number_Of_Students;
        }

        public override double GetTotalFeel()
        {
            return Convert.ToDouble(Fees) * 0.9;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Company_Name : {0}", Company_Name);
            Console.WriteLine("Number Of Students : {0}", Number_Of_Students);
        }
    }
}
