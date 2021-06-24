using FinalProjectOOP.Encrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectOOP
{
    class Program
    {


        static void Main(string[] args)
        {
            Operator Operators = new Operator();

            Operators.PrintLogInPage();


            if (Operators.IsLogIn())
            {
                Console.Clear();
                Operators.PrintOperatorsPage();

                var Process = 0;
                try
                {
                    Console.Write("\t\tEnter Your Process : ");
                    Process = Convert.ToInt32(Console.ReadLine());
                }catch
                {
                    Console.WriteLine("\n\t\t\tEnter Numbers Please\n");
                    Process = 100;
                }

                while (Process != 0)
                {
                    try
                    {
                        switch (Process)
                        {
                            case (1): { Operators.ManageStudents(); Console.ReadKey(); Console.Clear(); Operators.PrintOperatorsPage(); break; }
                            case (2): { Operators.ManageCourses(); Console.ReadKey(); Console.Clear(); Operators.PrintOperatorsPage(); break; }
                            case (3): { Operators.ManageScores(); Console.ReadKey(); Console.Clear(); Operators.PrintOperatorsPage(); break; }
                            case (4): { Operators.DisplayStatics(); Console.ReadKey(); Console.Clear(); Operators.PrintOperatorsPage(); break; }
                            case (5): { Operators.AverageScoreByCourse(); Console.ReadKey(); Console.Clear(); Operators.PrintOperatorsPage(); break; }
                            case (6): { Operators.CoursesToTextFile(); Console.ReadKey(); Console.Clear(); Operators.PrintOperatorsPage(); break; }
                            case (7): { Operators.CoursesToTextFileWithUserPath(); Console.ReadKey(); Console.Clear(); Operators.PrintOperatorsPage(); break; }
                            case (8): { Operators.ScoreTextFile(); Console.ReadKey(); Console.Clear(); Operators.PrintOperatorsPage(); break; }
                            case (9): { Operators.ScoreTextFileWithUserPath(); Console.ReadKey(); Console.Clear(); Operators.PrintOperatorsPage(); break; }
                        }

                        Console.Write("\t\t\tEnter Your Process : ");
                        Process = Convert.ToInt32(Console.ReadLine());
                    }catch
                    {
                        Process = 100;
                        Console.WriteLine("\n\t\t\tEnter Numbers Please\n");
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\nUsername Or Password Is Incorrect\n\n");
            }
        }
    }
}
