using System;
namespace CSharpInterviewPractical
{  
    //Class object VS Object Data Type

    class Employee
    {       
        public string Name;
        public int Age;
        public string Department;
      
        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Department: {Department}");
        }
    }

    class Program
    {
        static void Main()
        {
            #region Class Object Example

            //An object in C# is an instance of a class.
            //It is created in memory and used to access the members
            //(fields,properties, methods, etc.) of that class.

            //👨‍💼 Real-Time Example: Employee Management System
            //Let’s say you're developing an employee management app.

            //You have a class called Employee, and you'll create objects
            //for different employees to store their data.

            // Creating an object of Employee class
            Employee emp1 = new Employee();

            // Assigning values to the object
            emp1.Name = "Sudheshwer Rai";
            emp1.Age = 30;
            emp1.Department = "IT";

            // Accessing method using the object
            emp1.DisplayDetails();

            // Creating another object
            var emp2 = new Employee();
            emp2.Name = "Disha";
            emp2.Age = 28;
            emp2.Department = "HR";

            emp2.DisplayDetails();

            //🧠 Key Points:
            //A class is like a design (e.g., Employee template).
            //An object is like a real person based on that design
            //(e.g., Sudheshwer or Disha).
            //You can create multiple objects from a single class.
            //Through objects, you can set values, call methods,
            //and access class members.

            #endregion

            #region Object Data Type
            //object is a built-in data type in C#. It is the base class
            //for all data types, whether value types (like int, bool)
            //or reference types (like string, class, array, etc.).

            object a = 10;            // int assigned to object
            object b = "Hello";       // string assigned to object
            object c = new Employee(); // class object assigned to object
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c.GetType());

            //🧠 Key Concepts:
            //object can store any type of data — integer, string, class, etc.
            //When a value type is stored in object, it's boxed.
            //You can later unbox it by casting it back to the original type.

            //⚠️ Important Notes:
            //Declaring with object means you lose compile-time type checking.
            //Use object only when you really need to store multiple types in one
            //variable or collection.

            #endregion
        }
    }

}
