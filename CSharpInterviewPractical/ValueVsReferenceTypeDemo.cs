using System;

namespace ValueVsReferenceTypeDemo
{
    class Student
    {
        public string Name;
    }

    class Program
    {
        
        static void Main()
        {
            //Value type example
            int x = 10;
            int y = x;
            y = 20;
            Console.WriteLine(x); // Output: 10
            Console.WriteLine(y); // Output: 20

            //Referece type example
            Student s1 = new Student();
            s1.Name = "Divyanshu";
            Student s2 = s1;
            s2.Name = "Sudheshwer";
            Console.WriteLine(s1.Name); // Output: Sudheshwer
            Console.WriteLine(s2.Name); // Output: Sudheshwer

            
        }
    }
}
