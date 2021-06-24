using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {


        static void Main(string[] args)
        {

            //Q1
            var Location = @"E:\Tahaluf\OOP\Day7\Task3\Task3\MyFiles\MyFile.txt";

            try
            {
                Console.WriteLine("Count Of Characters In File Is : {0}", File.ReadAllText(Location).Count());
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }





            //Optional
            Console.WriteLine("\n\n\nHello User, Give Me Your Text File Path To Give You How Many Characters.");
            Console.WriteLine("***** Enter Stop To Stop Loop *****");

            Console.Write("Input Path File : ");
            var MyPath = Console.ReadLine();
            while (MyPath != "Stop")
            {
                try
                {
                    Console.WriteLine("Count Of Character In File Is : {0}", File.ReadAllText(MyPath).Count());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\nCould Not Find Path");
                    Console.WriteLine("More Details : " + e.Message);
                }
                Console.Write("\nInput Path File : ");
                MyPath = Console.ReadLine();
            }










            Console.Clear();
            //Q2
            var Location1 = @"E:\Tahaluf\OOP\Day7\Task3\Task3\MyFiles\MyFile.txt";

            try
            {
                string MyText;
                using (StreamReader Read = new StreamReader(Location1))
                {
                    MyText = Read.ReadLine();
                }

                var OldFile = new FileInfo(Location1);

                var PathCharList = OldFile.FullName.ToArray();
                Array.Resize<char>(ref PathCharList, PathCharList.Length - OldFile.Extension.Length);

                var NewPath = new string(PathCharList) + ".inv";

                if (!File.Exists(NewPath))
                {
                    using (FileStream NewFile = File.Create(NewPath))
                    {
                        var NewText = MyText.ToArray();
                        Array.Reverse(NewText);
                        byte[] bytes = Encoding.UTF8.GetBytes(NewText);
                        NewFile.Write(bytes, 0, bytes.Length);

                        Console.WriteLine("********** Done **********");
                        Console.WriteLine("********** We Have Copy Your File To New Path With Extension (inv) **********");
                    }
                }
                else
                {
                    //Clear File
                    File.WriteAllText(NewPath, String.Empty);

                    var CopyFile = new FileInfo(NewPath);
                    using (StreamWriter Writer = CopyFile.AppendText())
                    {
                        var NewText = MyText.ToArray();
                        Array.Reverse(NewText);
                        Writer.Write(NewText);
                    }
                    Console.WriteLine("********** Done **********");
                    Console.WriteLine("********** We Have Copy Your File To New Path With Extension (inv) **********");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
