using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Classes
{
    interface IDisposable
    {
        void Dispose();
    }

    class Library : IDisposable
    {
        public string Name { get; set; }
        StreamReader File = new StreamReader(@"E:\Tahaluf\OOP\Day8\Files\TextFile.txt");

        public Library()
        {
            Name = "";
            Console.WriteLine("Library Is Open.");
        }
        public void Dispose()
        {
            Console.WriteLine("Library Close.");
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        private bool Disposed { get; set; }
        protected virtual void Dispose(bool disposing)
        {
            if (!Disposed)
            {
                if (disposing)
                {
                    File.Dispose();
                }
                Disposed = true;
                FreeChuck();
                File = null;
            }
        }

        bool isFreed = false;
        private void FreeChuck()
        {
            if(isFreed)
            {
                return;
            }

            File.Close();
        }

        ~Library()
        {
            Dispose(true);
            Console.WriteLine("Library Close in Destructure.");
        }
    }
}
