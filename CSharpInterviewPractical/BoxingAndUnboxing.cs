
using System;

namespace CSharpInterviewPractical
{
    class BoxingAndUnboxing
    {
        //Boxing & Unboxing In C#

        static void Main()
        {
            //What is Boxing ?
            //Boxing is the process of converting a value
            //type(e.g., int, float, bool) to a reference type(object).

            //This happens implicitly.

            //Example:-
            int number = 50;          // Value type
            object obj = number;      // Boxing

            Console.WriteLine("Boxed object: " + obj);

            //What is Unboxing?
            //Unboxing is the process of converting a
            //reference type (object) back to a value type.

            //This requires an explicit cast.

            int unboxedNumber = (int)obj;   // Unboxing
            Console.WriteLine("Unboxed int: " + unboxedNumber);
        }
    }
}
