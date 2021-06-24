using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    string Location = @"E:\Tahaluf\OOP\Day7\Day7\Files\new.txt";

            //    FileInfo fileInfo = new FileInfo(Location);

            //    if (fileInfo.Exists)
            //    {
            //        //Reade
            //        string content = File.ReadAllText(Location);
            //        Console.WriteLine("Current content of file:");
            //        Console.WriteLine(content);

            //        fileInfo.Delete();
            //        Console.WriteLine("Delete Of File Is Successfull.");

            //        //Update
            //        //Console.WriteLine("Please enter new content for the file:");
            //        //string newContent = Console.ReadLine();
            //        //File.WriteAllText(Location, newContent);

            //    }
            //    else
            //    {
            //fileInfo.Create();
            //        Console.WriteLine("Creation Of File Is Successfull.");
            //    }
            //}
            //catch(IOException e)
            //{

            //    Console.WriteLine("Failed Attempt To Creaete File " + e.Message);
            //}






            //try
            //{
            //    var Location = @"E:\Tahaluf\OOP\Day7\Day7\Files\new.txt";
            //    FileInfo fileInfo = new FileInfo(Location);

            //    using (StreamWriter SW = fileInfo.AppendText())
            //    {
            //        for (int i = 0; i < 5; i++)
            //        {
            //            SW.WriteLine("Hello Number {0}", i);
            //        }

            //        SW.Close();
            //    }

            //    Console.WriteLine(File.ReadAllText(Location));
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e);
            //}








            //try
            //{
            //    var Location = @"E:\Tahaluf\OOP\Day7\Day7\Files\NewFile.txt";
            //    FileInfo fileInfo = new FileInfo(Location);

            //    if (!fileInfo.Exists)
            //    {

            //        fileInfo.Create();
            //        Console.WriteLine("Creation Of File Is Successfull.");
            //    }

            //    using (StreamWriter SW = fileInfo.AppendText())
            //    {

            //        Console.Write("Enter Your String : ");
            //        var StringValue = Console.ReadLine();

            //        SW.WriteLine(StringValue);

            //        SW.Close();
            //    }

            //    Console.WriteLine(File.ReadAllText(Location));
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e);
            //}











            //var def = @"E:\Tahaluf\OOP\Day7\Day7\Files\NewFile.txt";

            //using (StreamWriter SW = File.AppendText(def))
            //{
            //    SW.WriteLine("Welcome to Stream Class C#");

            //    try
            //    {
            //        using (StreamReader Read = new StreamReader(def))
            //        {
            //            string Line1;

            //            while((Line1 = Read.ReadLine()) != null)
            //            {
            //                Console.WriteLine(Line1);
            //            }
            //        }

            //    }catch(IOException e)
            //    {
            //        Console.WriteLine(e);
            //    }
            //}














            //var Location1 = @"E:\Tahaluf\OOP\Day7\Day7\Files\Copy1.txt";
            //var Location2 = @"E:\Tahaluf\OOP\Day7\Day7\Files\Copy2.txt";

            //try
            //{
            //    string Line1;
            //    using (StreamReader Read = new StreamReader(Location1))
            //    {
            //        Line1 = Read.ReadLine();
            //    }

            //    var CopyFile = new FileInfo(Location2);

            //    using (StreamWriter Writer = CopyFile.AppendText())
            //    {
            //        Writer.Write(Line1.ToUpper());
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
    }
}
