namespace CSharpInterviewPractical
{
    using System;
    using System.IO;

    class FileHandler
    {
        private StreamWriter writer;
        private string fileName;

        public FileHandler(string fileName)
        {
            this.fileName = fileName;
            writer = new StreamWriter(fileName, true);
            Console.WriteLine("File opened: " + fileName);
        }

        public void WriteData(string data)
        {
            writer.WriteLine(data);
            Console.WriteLine("Data written: " + data);
        }

        ~FileHandler()
        {
            if (writer != null)
            {
                writer.Close();
                Console.WriteLine("File closed: " + fileName);
            }
        }
    }

    class Program
    {
        static void Main()
        {

            FileHandler fh = new FileHandler($"DestructorExample.txt");
            fh.WriteData("Destructor example");

            Console.WriteLine("Objects created. Destructor will be called automatically by GC later.");
            Console.ReadLine();
        }
    }
}
