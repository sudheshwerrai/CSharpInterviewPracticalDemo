using System;

namespace CSharpInterviewPractical
{
    //What is a Default/Parameterless Constructor?
    #region Key points    
    //1-A constructor with no parameters.
    //2-Automatically provided by the compiler if no other constructors are defined.
    //3-Can be explicitly defined by the developer.
    //4-Whenever an object is instantiated using the new keyword without passing arguments.
    //5-To initialize default values.
    //6-Only one default constructer you can create.
    #endregion

    public class Student
    {
        public string name;//null
        public int age;//0

        // Parameterless Constructor
        public Student()
        {
            name = "Unknown";
            age = 10;
            Console.WriteLine("Parameterless constructor called. Student initialized.");
        }

        public Student(string name)
        {
            
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Student obj = new Student(); // Default / Parameterless constructor is called
            obj.DisplayInfo();
        }
    }
}
