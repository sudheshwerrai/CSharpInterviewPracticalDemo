
using System;

namespace CSharpInterviewPractical
{
    class Program
    {
        //Dynamic Keyword In C#

        public int MyProperty { get; set; }

        dynamic MyMethod(dynamic abc)
        {
            //Console.WriteLine("My method");
            return abc;
        }

        static void Main()
        {
            //int i;
            //dynamic value = 123;
            //Console.WriteLine(value.GetType());
            //dynamic obj = new Program();
            //Console.WriteLine(obj.MyProperty1);
            //obj.MyMethod();            

            //Console.WriteLine(obj.MyMethod("Test"));

            //object value = 123;
            //int number =(int) value;

            //dynamic myValue = 1234;
            //int myNumber = myValue;
            //Console.WriteLine(number);
            //Console.WriteLine(myNumber);

            //var abc = null;
            // dynamic number = null;

            dynamic anyValue = 123;
            anyValue = "Test";
            anyValue = 100.34;
            Console.WriteLine(anyValue);

            //int number = 123;
            

        }
}
}
