using System;
using System.IO;

namespace DisposeDemo
{
    class DisposeExample : IDisposable
    {
        private FileStream fs;

        public DisposeExample(string path)
        {
            fs = new FileStream(path, FileMode.Create);
            Console.WriteLine("Constructor: FileStream created");
        }

        public void Dispose()
        {
            fs.Close();
            Console.WriteLine("Dispose: FileStream closed");
        }

        static void Main()
        {
            using (var obj = new DisposeExample("demo.txt"))
            {
                Console.WriteLine("Using block: Working with the object");
            }

            Console.WriteLine("Main method completed");
        }
    }
}
