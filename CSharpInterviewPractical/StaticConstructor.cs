using System;

namespace CSharpInterviewPractical
{
    //What is Static Constructor in C#?

    #region Static Constructor Points

    //Key Points:-
    //1-A static constructor is used to initialize static members of a class.
    //2-It is invoked automatically before the first instance is created
    //or any static members are accessed.
    //3-Static constructors cannot be public, private, protected, or internal.
    //4-You can't pass parameters to static constructors.
    //5-Static constructor runs just once—ever—for that class.
    //6-Only one static constructor you can created.
    //7-Static Constructor you can create inside the static class as well as non-static class.

    #endregion

    #region Static Constructor Example

   static class Logger
    {
        private static string logFilePath;

        // Static constructor
        static Logger()
        {
            logFilePath = "C:\\Logs\\app_log.txt";
            Console.WriteLine("Logger initialized with path: " + logFilePath);
            //Console.WriteLine("I am a Static Constructor");
        }        

        public static void Log(string message)
        {
            // Imagine writing the message to the log file here
            Console.WriteLine("Log entry: " + message);
        }

        //public void TestFirst()
        //{
        //    Console.WriteLine("Test First");
        //}

        //public void TestSecond()
        //{
        //    Console.WriteLine("Test Second");
        //}
    }

    // Usage
    class Program
    {
        static void Main()
        {
            //var objFirst = new Logger();
            //objFirst.TestFirst();

            //var objSecond = new Logger();
            //objSecond.TestSecond();

            //Console.WriteLine("Main Method Started");

            Logger.Log("App started");
            Logger.Log("User logged in");
        }
    }

    #endregion
}
