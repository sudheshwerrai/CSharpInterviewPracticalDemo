using System;

namespace CSharpInterviewPractical
{
    class NullAndCoalescingOperator
    {        
        static void Main()
        {                  
            int? age = null;

            if (age.HasValue)
                Console.WriteLine($"Age: {age}");
            else
                Console.WriteLine("Age: Not provided");

            int? inputAge = null;
            int finalAge = inputAge ?? 18;
            Console.WriteLine(finalAge);
        }
    }
}
