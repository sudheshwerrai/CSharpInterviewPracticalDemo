using System;

namespace CSharpInterviewPractical
{
    //What is Constructor and Constructor types in C#

    #region Constructor In C#
    //Key Points to Remember
    //Constructor name must match the class name.
    //It does not have a return type, not even void.
    //It is automatically invoked when an object is created.
    //It is used to initialize fields.
    
    #endregion

    #region Program
    public class Student
    {
        public int RollNumber;//0
        public string Name;//null

        // Constructor
        public Student()
        {
            //RollNumber = 101;
            //Name = "Rahul";
            Console.WriteLine("Constructor called: Object initialized");
        }

        public void Display()
        {
            Console.WriteLine($"Roll Number: {RollNumber}, Name: {Name}");
        }

        public static void Main()
        {
            // When object is created,
            // constructor is called automatically
            Student student = new Student();
            student.Display();
        }
    }
    #endregion

    #region Constructor Types in C#
    //Types of Constructors
    //1-Default Constructor
    //2-Parameterized Constructor
    //3-Static Constructor
    //4-Private Constructor
    //5-Copy Constructor
    #endregion
}
