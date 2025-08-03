using System;

namespace CSharpInterviewPractical
{
    //Copy Constructor In C#

    #region Definition
    //What is a Copy Constructor?
    //A constructor that takes an object of the same class and copies its values.

    //Why Use It?
    //To create a new object that is a copy of an existing object (not just a reference).

    //Output
    //Copy constructor creates an independent object.
    //Changing the original doesn’t affect the copy.
    #endregion

    #region Example of Copy Constructor
    public class Person
    {
        public string Name;
        public int Age;

        // Parameterized constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Copy constructor
        public Person(Person other)
        {
            Name = other.Name;
            Age = other.Age;
        }

        public void Display(string label)
        {
            Console.WriteLine($"--- {label} ---");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // Original object
            Person original = new Person("Divyanshu", 27);
            original.Display("Original");

            // Copy using Copy Constructor
            Person copy = new Person(original);
            copy.Display("Copy");

            // Modify original
            original.Name = "Sudheshwer";
            original.Age = 35;

            // Display after modification
            original.Display("Original (After Change)");
            copy.Display("Copy (Unaffected)");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
    #endregion
}

