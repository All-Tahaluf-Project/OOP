using FinalProjectOOP.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProjectOOP.Encrypt;

namespace FinalProjectOOP
{
    class Operator
    {
        private string ConnectioString { get; set; }
        private FinalProjectOOPDB _context { get; set; }
        private SqlConnection SqlConnection { get; set; }

        public Operator()
        {
            ConnectioString = "Data Source=.;Initial Catalog=FinalProjectOOPDB;Integrated Security=True";
            _context = new FinalProjectOOPDB();
            SqlConnection = new SqlConnection(ConnectioString);
        }

        //Main View
        public void PrintLogInPage()
        {
            
            for (int i = 0; i < 50; i++) { Console.Write("*"); }
            Console.Write("\n*");
            for (int i = 1; i < 49; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 49; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 20; i++) { Console.Write(" "); }
            Console.Write("LogIn Page");
            for (int i = 1; i < 20; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 49; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 49; i++) { Console.Write(" "); }
            Console.Write("*\n");

            for (int i = 0; i < 50; i++) { Console.Write("*"); }
            Console.WriteLine();
        }
        //List Of Operators
        public void PrintOperatorsPage()
        {
            for (int i = 0; i < 50; i++) { Console.Write("*"); }
            Console.Write("\n*");
            for (int i = 1; i < 49; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 49; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 21; i++) { Console.Write(" "); }
            Console.Write("0 : Stop");
            for (int i = 1; i < 21; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 15; i++) { Console.Write(" "); }
            Console.Write("1 : Students Manager");
            for (int i = 1; i < 15; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 16; i++) { Console.Write(" "); }
            Console.Write("2 : Course Manager");
            for (int i = 1; i < 16; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 16; i++) { Console.Write(" "); }
            Console.Write("3 : Score Manager");
            for (int i = 1; i < 17; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 10; i++) { Console.Write(" "); }
            Console.Write("4 : Display Statics By Gender");
            for (int i = 1; i < 11; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 10; i++) { Console.Write(" "); }
            Console.Write("5 : Average Scores By Courses");
            for (int i = 1; i < 11; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 10; i++) { Console.Write(" "); }
            Console.Write("6 : Courses Table To Text File");
            for (int i = 1; i < 10; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 2; i++) { Console.Write(" "); }
            Console.Write("7 : Courses Table To Text File (Path From User)");
            for (int i = 1; i < 1; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 10; i++) { Console.Write(" "); }
            Console.Write("8 : Scores Table To Text File");
            for (int i = 1; i < 11; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 2; i++) { Console.Write(" "); }
            Console.Write("9 : Scores Table To Text File (Path From User)");
            for (int i = 1; i < 2; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 49; i++) { Console.Write(" "); }
            Console.Write("*\n");

            Console.Write("\n*");
            for (int i = 1; i < 49; i++) { Console.Write(" "); }
            Console.Write("*\n");

            for (int i = 0; i < 50; i++) { Console.Write("*"); }
            Console.WriteLine();
        }
        //LogIn
        public bool IsLogIn()
        {
            try
            {
            var PathUserName = @"E:\Tahaluf\OOP\FinalProject\FinalProjectOOP\Files\User\UserName.txt";
            var PathPassword = @"E:\Tahaluf\OOP\FinalProject\FinalProjectOOP\Files\User\Password.txt";

            if (!File.Exists(PathUserName) || !File.Exists(PathPassword))
            {
                using (FileStream NewFile = File.Create(PathUserName))
                {
                    //Enter User Name
                    for (int i = 1; i < 20; i++) { Console.Write(" "); }
                    Console.Write("User Name : ");
                    var UserName = Console.ReadLine();
                    for (int i = 1; i < 20; i++) { Console.Write(" "); }
                    Console.WriteLine();

                        UserName = AesOperation.EncryptString(UserName);
                    byte[] bytes = Encoding.UTF8.GetBytes(UserName);
                    NewFile.Write(bytes, 0, bytes.Length);
                }

                using (FileStream NewFile = File.Create(PathPassword))
                {
                    //Enter Password
                    for (int i = 1; i < 20; i++) { Console.Write(" "); }
                    Console.Write("Password : ");
                    var Password = Console.ReadLine();
                    for (int i = 1; i < 20; i++) { Console.Write(" "); }
                    Console.WriteLine();
                        Password = AesOperation.EncryptString(Password);
                        byte[] bytes = Encoding.UTF8.GetBytes(Password);
                    NewFile.Write(bytes, 0, bytes.Length);
                }

                return true;
            }
            else
            {
                    var UserNameInFile = "";
                    var PasswordInFile = "";

                    //Enter User Name
                    for (int i = 1; i < 20; i++) { Console.Write(" "); }
                    Console.Write("User Name : ");
                    var UserName = Console.ReadLine();
                    for (int i = 1; i < 20; i++) { Console.Write(" "); }
                    Console.WriteLine();

                    //Enter Password
                    for (int i = 1; i < 20; i++) { Console.Write(" "); }
                    Console.Write("Password : ");
                    var Password = Console.ReadLine();
                    for (int i = 1; i < 20; i++) { Console.Write(" "); }
                    Console.WriteLine();

                    using (StreamReader ReaduserName = new StreamReader(PathUserName))
                    {
                        UserNameInFile = ReaduserName.ReadLine();

                        if (UserName != AesOperation.DecryptString(UserNameInFile)) { return false; }
                    }

                    using (StreamReader ReadPassword = new StreamReader(PathPassword))
                    {
                        PasswordInFile = ReadPassword.ReadLine();

                        if (Password != AesOperation.DecryptString(PasswordInFile)) { return false; }
                    }
                    return true;
               }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine("Details : " + e.Message);
                return false;
            }
        }

        //Students
        public void AddStudent()
        {
            try
            {

                SqlConnection.Open();

                Student student = new Student();
                Console.Write("Please Enter Student Name : ");
                student.Name = Console.ReadLine();

                Console.Write("Please Enter Student Age : ");
                student.Age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please Enter Student Gender (0:Male,1:Female,2:N/A) : ");
                student.GenderId = Convert.ToInt32(Console.ReadLine());

                student.Id = _context.Student.Any() ? _context.Student.Max(a => a.Id) + 1 : 0;
                string Query = $"INSERT INTO Student (Id,Name, Age,GenderId)VALUES({student.Id},'{student.Name}', {student.Age},{student.GenderId})";

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.ExecuteNonQuery();


                Console.WriteLine("\n\nAdd Student Is Success");
                SqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nAdd Student Is UnSuccess");
                Console.WriteLine(e.Message);
                SqlConnection.Close();
            }
        }

        public void EditStudent()
        {

            try
            {

                SqlConnection.Open();
                Console.Write("Enter Employee Id : ");
                var Id = Convert.ToInt32(Console.ReadLine());
                var Student = _context.Student.FirstOrDefault(a => a.Id == Id);

                if (Student == null)
                {
                    Console.WriteLine("\n\nStudent Is Not Found (404).\n");
                }
                else
                {
                    Console.Write("Please Enter New Student Name (Just Press Enter To Do Not Edit) : ");
                    var Name = Console.ReadLine();
                    if (Name != "") { Student.Name = Name; }

                    Console.Write("Please Enter New Student Age (Enter -1 To Do Not Edit) :");
                    var Age = Convert.ToInt32(Console.ReadLine());
                    if (Age != -1) { Student.Age = Age; }

                    Console.Write("Please Enter Student Gender (0:Male,1:Female,2:N/A) (Enter Another Value To Do Not Edit) : ");
                    var GenderId = Convert.ToInt32(Console.ReadLine());
                    if (GenderId >= 0 || GenderId <= 2) { Student.GenderId = GenderId; }

                    string Query = $"UPDATE Student SET Name = '{Student.Name}',Age = {Student.Age},GenderId = {Student.GenderId} WHERE Id = {Id};";

                    SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                    sqlCommand.ExecuteNonQuery();


                    Console.WriteLine("\n\nUpdate Student Is Success");
                }

                SqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nUpdate Student Is UnSuccess");
                Console.WriteLine(e.Message);
                SqlConnection.Close();
            }
        }

        public void RemoveStudent()
        {
            try
            {
                SqlConnection.Open();

                Console.Write("Enter Student Id : ");
                var Id = Convert.ToInt32(Console.ReadLine());

                var Student = _context.Student.FirstOrDefault(a => a.Id == Id);

                if (Student == null)
                {
                    Console.WriteLine("\n\nStudent Is Not Found (404).\n");
                }
                else
                {
                    string QueryToDeleteScore = $"DELETE FROM Score WHERE IdStudent = {Id};";
                    string QueryToDeleteStudent = $"DELETE FROM Student WHERE Id = {Id};";

                    SqlCommand sqlCommand = new SqlCommand(QueryToDeleteScore, SqlConnection);
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand = new SqlCommand(QueryToDeleteStudent, SqlConnection);
                    sqlCommand.ExecuteNonQuery();


                    Console.WriteLine("\n\nDelete Student Is Success");
                }

                SqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Delete Student Is UnSuccess");
                Console.WriteLine(e.Message);
                SqlConnection.Close();
            }
        }

        public void DisplayStudentsList()
        {
            Console.WriteLine("\t***** List Of Students *****\t\n");

            Console.WriteLine($"|Name \t|\tAge \t|\tGender");
            Console.WriteLine("**************************************");
            foreach (var S in _context.Student)
            {
                Console.WriteLine($"|{S.Name} \t|\t{S.Age} \t|\t{S.Gender.Title}");
            }
        }

        public void SearchStudentByText()
        {
            Console.Write("Enter Student Name : ");
            var Name = Console.ReadLine();

            var Students = _context.Student.Where(a => a.Name.ToLower().Contains(Name.ToLower()));

            if (!Students.Any())
            {
                Console.WriteLine("\n\nNo Content(204).\n");
            }else
            {

                Console.WriteLine("\t\t***** List Of Students *****\t\n");

                Console.WriteLine($"Name \t\tAge \t\tGender");
                Console.WriteLine("**************************************");
                foreach (var S in Students)
                {
                    Console.WriteLine($"|{S.Name} \t|\t{S.Age} \t|\t{S.Gender.Title}");
                }
            }
        }

        public void SearchStudentById()
        {
            Console.Write("Enter Student Id : ");
            var Id = Convert.ToInt32(Console.ReadLine());

            var Student = _context.Student.FirstOrDefault(a => a.Id == Id);

            if (Student == null)
            {
                Console.WriteLine("\n\nStudent Is Not Found (404).\n");
            }
            else
            {
                Console.WriteLine($"Name \t\tAge \t\tGender");
                Console.WriteLine("**************************************");
                Console.WriteLine($"|{Student.Name} \t|\t{Student.Age} \t|\t{Student.Gender.Title}");
            }
        }

        public void ManageStudents()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t********** Manage Students List **********\t");
            Console.WriteLine("\t\t\t********** +++++ 1 To Add +++++ **********\t");
            Console.WriteLine("\t\t\t********** --- 2 To Remove ---- **********\t");
            Console.WriteLine("\t\t\t********** ++++ 3 To Edit +++++ **********\t");
            Console.WriteLine("\t\t\t********** ^ 4 To Display All ^ **********\t");
            Console.WriteLine("\t\t\t********** 5 To Search By Name  **********\t");
            Console.WriteLine("\t\t\t********** *6 To Search By Id*  **********\t");

            try
            {
                Console.Write("Enter Your Process : ");
                var Process = Convert.ToInt32(Console.ReadLine());

                switch (Process)
                {
                    case (1):{ AddStudent(); break; }
                    case (2): { RemoveStudent(); break; }
                    case (3): { EditStudent(); break; }
                    case (4): { DisplayStudentsList(); break; }
                    case (5): { SearchStudentByText(); break; }
                    case (6): { SearchStudentById(); break; }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n");
        }

        //Course
        public void AddCourse()
        {
            try
            {

                SqlConnection.Open();

                Course Course = new Course();
                Console.Write("Please Enter Course Name : ");
                Course.Name = Console.ReadLine();

                Course.Id = _context.Course.Any() ? _context.Course.Max(a => a.Id) + 1 : 0;
                string Query = $"INSERT INTO Course (Id,Name)VALUES({Course.Id},'{Course.Name}')";

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.ExecuteNonQuery();


                Console.WriteLine("\n\nAdd Course Is Success");
                SqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nAdd Course Is UnSuccess");
                Console.WriteLine(e.Message);
                SqlConnection.Close();
            }
        }

        public void EditCourse()
        {

            try
            {

                SqlConnection.Open();
                Console.Write("Enter Course Id : ");
                var Id = Convert.ToInt32(Console.ReadLine());
                var Course = _context.Course.FirstOrDefault(a => a.Id == Id);

                if (Course == null)
                {
                    Console.WriteLine("\n\nCourse Is Not Found (404).\n");
                }
                else
                {
                    Console.Write("Please Enter New Course Name (Just Press Enter To Do Not Edit) : ");
                    var Name = Console.ReadLine();
                    if (Name != "") { Course.Name = Name; }

                    string Query = $"UPDATE Course SET Name = '{Course.Name}' WHERE Id = {Id};";

                    SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                    sqlCommand.ExecuteNonQuery();


                    Console.WriteLine("\n\nUpdate Course Is Success");
                }

                SqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nUpdate Course Is UnSuccess");
                Console.WriteLine(e.Message);
                SqlConnection.Close();
            }
        }

        public void RemoveCourse()
        {
            try
            {
                SqlConnection.Open();

                Console.Write("Enter Course Id : ");
                var Id = Convert.ToInt32(Console.ReadLine());

                var Course = _context.Course.FirstOrDefault(a => a.Id == Id);

                if (Course == null)
                {
                    Console.WriteLine("\n\nCourse Is Not Found (404).\n");
                }
                else
                {
                    string QueryToDeleteScore = $"DELETE FROM Score WHERE IdCourse = {Id};";
                    string QueryToDeleteCourse = $"DELETE FROM Course WHERE Id = {Id};";

                    SqlCommand sqlCommand = new SqlCommand(QueryToDeleteScore, SqlConnection);
                    sqlCommand.ExecuteNonQuery();

                    sqlCommand = new SqlCommand(QueryToDeleteCourse, SqlConnection);
                    sqlCommand.ExecuteNonQuery();

                    Console.WriteLine("\n\nDelete Course Is Success");
                }

                SqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Delete Course Is UnSuccess");
                Console.WriteLine(e.Message);
                SqlConnection.Close();
            }
        }

        public void DisplayCoursesList()
        {
            Console.WriteLine("\t** List Of Courses **\t\n");

            Console.WriteLine($"\t|\tName\t|");
            Console.WriteLine("**************************************");
            foreach (var C in _context.Course)
            {
                Console.WriteLine($"\t|\t{C.Name}\t|");
            }
        }

        public void DisplayStudentsAndCoursesList()
        {
            Console.WriteLine("\t** List Of Courses **\t\n");
            Console.WriteLine("**************************************");
            foreach (var C in _context.Course)
            {
                Console.WriteLine($"\t|\t{C.Name}\t|");
                var Students = _context.Student.Where(a => a.Score.Where(S => S.IdCourse == C.Id).Any());
                Console.WriteLine("******* List Of Students *******\t\n");

                Console.WriteLine($"|Name \t|\tAge \t|\tGender");
                Console.WriteLine("**************************************");
                foreach (var S in Students)
                {
                    Console.WriteLine($"|{S.Name} \t|\t{S.Age} \t|\t{S.Gender.Title}");
                }

                Console.WriteLine("\n\n");
            }
        }

        public void ManageCourses()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t********** Manage Students List **********\t");
            Console.WriteLine("\t\t\t********** +++++ 1 To Add +++++ **********\t");
            Console.WriteLine("\t\t\t********** --- 2 To Remove ---- **********\t");
            Console.WriteLine("\t\t\t********** ++++ 3 To Edit +++++ **********\t");
            Console.WriteLine("\t\t\t********** ^ 4 To Display All ^ **********\t");
            Console.WriteLine("\t\t\t** 5 To Display Courses With Students  ***\t");

            try
            {
                Console.Write("Enter Your Process : ");
                var Process = Convert.ToInt32(Console.ReadLine());

                switch (Process)
                {
                    case (1): { AddCourse(); break; }
                    case (2): { RemoveCourse(); break; }
                    case (3): { EditCourse(); break; }
                    case (4): { DisplayCoursesList(); break; }
                    case (5): { DisplayStudentsAndCoursesList(); break; }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n");
        }

        //Score
        public void AddScoreToStudent()
        {
            try
            {

                SqlConnection.Open();

                Score score = new Score();
                Console.Write("Please Enter Id Student To Add Score : ");
                score.IdStudent = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please Enter Id Course : ");
                score.IdCourse = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please Enter Score : ");
                score.Score1 = Convert.ToInt32(Console.ReadLine());

                score.Datetime = DateTime.Now;

                score.Id = _context.Score.Any() ? _context.Score.Max(a => a.Id) + 1 : 0;
                string Query = $"INSERT INTO Score (Id,Score,Datetime,IdStudent,IdCourse)VALUES({score.Id},{score.Score1},'{score.Datetime:yyyy-MM-dd}',{score.IdStudent},{score.IdCourse})";

                SqlCommand sqlCommand = new SqlCommand(Query, SqlConnection);
                sqlCommand.ExecuteNonQuery();


                Console.WriteLine("\n\nAdd Score Is Success ^_^.");
                SqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\nAdd Student Is UnSuccess *_*.");
                Console.WriteLine(e.Message);
                SqlConnection.Close();
            }
        }

        public void RemoveScoreById()
        {
            try
            {
                SqlConnection.Open();

                Console.Write("Enter Score Id : ");
                var Id = Convert.ToInt32(Console.ReadLine());

                var Score = _context.Score.FirstOrDefault(a => a.Id == Id);

                if (Score == null)
                {
                    Console.WriteLine("\n\nScore Is Not Found (404).\n");
                }
                else
                {
                    string QueryToDeleteScore = $"DELETE FROM Score WHERE Id = {Id};";

                    SqlCommand sqlCommand = new SqlCommand(QueryToDeleteScore, SqlConnection);
                    sqlCommand.ExecuteNonQuery();

                    Console.WriteLine("\n\nDelete Score Is Success");
                }

                SqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Delete Score Is UnSuccess");
                Console.WriteLine(e.Message);
                SqlConnection.Close();
            }
        }

        public void RemoveScoreForStudent()
        {
            try
            {
                SqlConnection.Open();

                Console.Write("Enter Student Id : ");
                var IdStudent = Convert.ToInt32(Console.ReadLine());

                var Student = _context.Student.FirstOrDefault(a => a.Id == IdStudent);

                if(Student == null) { Console.WriteLine("\n\nStudent Is Not Found (404).\n");  }
                else
                {

                    var Scores = _context.Score.Where(a => a.IdStudent == IdStudent);
                    Console.WriteLine("\t\t\t\t\t***** List Scores *****");
                    Console.WriteLine($"\t|\tId\t|\tScore\t|\tCourse\t|\t\tDate\t\t|\t");
                    foreach (var S in Scores)
                    {
                        Console.WriteLine($"\t|\t{S.Id}\t|\t{S.Score1}\t|\t{S.Course.Name}\t|\t{S.Datetime}\t|\t");
                    }

                    if (!Scores.Any())
                    {
                        Console.WriteLine("\n\nNo Content(204).\n");
                    }
                    else
                    {
                        Console.Write("\nEnter Score Id : ");
                        var Id = Convert.ToInt32(Console.ReadLine());

                        var Score = _context.Score.FirstOrDefault(a => a.Id == Id);
                        if (Score == null)
                        {
                            Console.WriteLine("\n\nScore Is Not Found (404).\n");
                        }
                        else
                        {
                            string QueryToDeleteScore = $"DELETE FROM Score WHERE Id = {Id};";

                            SqlCommand sqlCommand = new SqlCommand(QueryToDeleteScore, SqlConnection);
                            sqlCommand.ExecuteNonQuery();

                            Console.WriteLine("\n\nDelete Score Is Success");
                        }
                    }
                }

                SqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Delete Score Is UnSuccess");
                Console.WriteLine(e.Message);
                SqlConnection.Close();
            }
        }

        public void ManageScores()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t********** Manage Score List **********\t");
            Console.WriteLine("\t\t\t********** +++++ 1 To Add +++++ **********\t");
            Console.WriteLine("\t\t\t********** --- 2 To Remove ---- **********\t");
            Console.WriteLine("\t\t\t**** ^3 To Remove Score For Student^ ****\t");

            try
            {
                Console.Write("Enter Your Process : ");
                var Process = Convert.ToInt32(Console.ReadLine());

                switch (Process)
                {
                    case (1): { AddScoreToStudent(); break; }
                    case (2): { RemoveScoreById(); break; }
                    case (3): { RemoveScoreForStudent(); break; }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n");
        }


        //Another
        public void DisplayStatics()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t********** Statics **********\t\n");
            Console.WriteLine("***************************************");
            Console.WriteLine($"\tCount Of Students : {_context.Student.Count()} \n\n");
            Console.WriteLine("**** Count Of Students By Gender *****\n");
            Console.WriteLine($"\t\t Male : {_context.Student.Where(a => a.GenderId == 1).Count()} ");
            Console.WriteLine($"\t\t Female : {_context.Student.Where(a => a.GenderId == 2).Count()} ");
            Console.WriteLine($"\t\t N/A : {_context.Student.Where(a => a.GenderId == 3).Count()} ");
            Console.WriteLine("\n");
        }

        public void AverageScoreByCourse()
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t********** Average List **********");

            Console.WriteLine($"\t|\tName\t|\tAVG\t|\t\n");
            foreach (var C in _context.Course)
            {
                Console.WriteLine($"\t|\t{C.Name}\t|\t{C.Score.Average(a => a.Score1)}\t|\t");
            }
            Console.WriteLine("\n");
        }

        //File
        public void CoursesToTextFile()
        {
            Console.WriteLine("\n\n\n");
            var Path = @"E:\Tahaluf\OOP\FinalProject\FinalProjectOOP\Files\CoursesTextFile.txt";

            if (!File.Exists(Path))
            {
                using (FileStream NewFile = File.Create(Path))
                {
                    var TXT = "\t********** Course List **********\n";

                    TXT += "\t|\tId\t|\tName\t|\n\n";
                    foreach (var C in _context.Course)
                    {
                        TXT += $"\t|\t{C.Id}\t|\t{C.Name}\t|\n";
                    }

                    byte[] bytes = Encoding.UTF8.GetBytes(TXT);
                    NewFile.Write(bytes, 0, bytes.Length);

                    Console.WriteLine("************************ Done ****************************");
                    Console.WriteLine("********** Copy Course List To New File Is Done **********");
                }
            }
            else
            {
                File.WriteAllText(Path, String.Empty);

                var CopyFile = new FileInfo(Path);
                using (StreamWriter Writer = CopyFile.AppendText())
                {
                    var TXT = "\t********** Course List **********\n";

                    TXT += "\t|\tId\t|\tName\t|\n\n";
                    foreach (var C in _context.Course)
                    {
                        TXT += $"\t|\t{C.Id}\t|\t{C.Name}\t|\n";
                    }
                    Writer.Write(TXT);
                }
                Console.WriteLine("************************ Done ****************************");
                Console.WriteLine("********** Copy Course List To New File Is Done **********");
            }

            Console.WriteLine("\n");
        }
        public void ScoreTextFile()
        {
            Console.WriteLine("\n\n\n");
            var Path = @"E:\Tahaluf\OOP\FinalProject\FinalProjectOOP\Files\ScoresTextFile.txt";

            if (!File.Exists(Path))
            {
                using (FileStream NewFile = File.Create(Path))
                {
                    var TXT = "\t\t\t********** Score List **********\n";

                    TXT += "\t|\tId\t|\tCourse\t|\tStudent\t|\t\tDatetime\t|\tScore\t|\n";
                    foreach (var S in _context.Score)
                    {
                        TXT += $"\t|\t{S.Id}\t|\t{S.Course.Name}\t|\t{S.Student.Name}\t|\t{S.Datetime}\t|\t{S.Score1}\t|\n";
                    }

                    byte[] bytes = Encoding.UTF8.GetBytes(TXT);
                    NewFile.Write(bytes, 0, bytes.Length);

                    Console.WriteLine("************************ Done ****************************");
                    Console.WriteLine("********** Copy Course List To New File Is Done **********");
                }
            }
            else
            {
                File.WriteAllText(Path, String.Empty);

                var CopyFile = new FileInfo(Path);
                using (StreamWriter Writer = CopyFile.AppendText())
                {
                    var TXT = "\t\t\t\t\t********** Score List **********\n";

                    TXT += "\t|\tId\t|\tCourse\t|\tStudent\t|\t\tDatetime\t|\tScore\t|\n";
                    foreach (var S in _context.Score)
                    {
                        TXT += $"\t|\t{S.Id}\t|\t{S.Course.Name}\t|\t{S.Student.Name}\t|\t{S.Datetime}\t|\t{S.Score1}\t|\n";
                    }

                    Writer.Write(TXT);
                }
                Console.WriteLine("************************ Done ****************************");
                Console.WriteLine("********** Copy Course List To New File Is Done **********");
            }

            Console.WriteLine("\n");
        }
        //The Path From User
        public void CoursesToTextFileWithUserPath()
        {
            Console.WriteLine("\n\n\n");
            var Path = "";

            try
            {
                Console.Write("Enter Your Path : ");
                Path = Console.ReadLine() + @"\CoursesTextFile.txt";

                if (!File.Exists(Path))
                {
                    using (FileStream NewFile = File.Create(Path))
                    {
                        var TXT = "\t********** Course List **********\n";

                        TXT += "\t|\tId\t|\tName\t|\n\n";
                        foreach (var C in _context.Course)
                        {
                            TXT += $"\t|\t{C.Id}\t|\t{C.Name}\t|\n";
                        }

                        byte[] bytes = Encoding.UTF8.GetBytes(TXT);
                        NewFile.Write(bytes, 0, bytes.Length);

                        Console.WriteLine("************************ Done ****************************");
                        Console.WriteLine("********** Copy Course List To New File Is Done **********");
                    }
                }
                else
                {
                    File.WriteAllText(Path, String.Empty);

                    var CopyFile = new FileInfo(Path);
                    using (StreamWriter Writer = CopyFile.AppendText())
                    {
                        var TXT = "\t********** Course List **********\n";

                        TXT += "\t|\tId\t|\tName\t|\n\n";
                        foreach (var C in _context.Course)
                        {
                            TXT += $"\t|\t{C.Id}\t|\t{C.Name}\t|\n";
                        }
                        Writer.Write(TXT);
                    }
                    Console.WriteLine("************************ Done ****************************");
                    Console.WriteLine("********** Copy Course List To New File Is Done **********");
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n");
        }
        public void ScoreTextFileWithUserPath()
        {
            Console.WriteLine("\n\n\n");
            var Path = "";

            try
            {
                Console.Write("Enter Your Path : ");
                Path = Console.ReadLine() + @"\ScoresTextFile.txt";

                if (!File.Exists(Path))
                {
                    using (FileStream NewFile = File.Create(Path))
                    {
                        var TXT = "\t\t\t********** Score List **********\n";

                        TXT += "\t|\tId\t|\tCourse\t|\tStudent\t|\t\tDatetime\t|\tScore\t|\n";
                        foreach (var S in _context.Score)
                        {
                            TXT += $"\t|\t{S.Id}\t|\t{S.Course.Name}\t|\t{S.Student.Name}\t|\t{S.Datetime}\t|\t{S.Score1}\t|\n";
                        }

                        byte[] bytes = Encoding.UTF8.GetBytes(TXT);
                        NewFile.Write(bytes, 0, bytes.Length);

                        Console.WriteLine("************************ Done ****************************");
                        Console.WriteLine("********** Copy Course List To New File Is Done **********");
                    }
                }
                else
                {
                    File.WriteAllText(Path, String.Empty);

                    var CopyFile = new FileInfo(Path);
                    using (StreamWriter Writer = CopyFile.AppendText())
                    {
                        var TXT = "\t\t\t\t\t********** Score List **********\n";

                        TXT += "\t|\tId\t|\tCourse\t|\tStudent\t|\t\tDatetime\t|\tScore\t|\n";
                        foreach (var S in _context.Score)
                        {
                            TXT += $"\t|\t{S.Id}\t|\t{S.Course.Name}\t|\t{S.Student.Name}\t|\t{S.Datetime}\t|\t{S.Score1}\t|\n";
                        }

                        Writer.Write(TXT);
                    }
                    Console.WriteLine("************************ Done ****************************");
                    Console.WriteLine("********** Copy Course List To New File Is Done **********");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\n");
        }


        ~Operator()
        {
            Console.Clear();
            Console.WriteLine("\n\n\n********** Good Bay **********\n\n\n");
        }
    }
}
