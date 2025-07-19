
using System;

namespace CSharpInterviewPractical
{
    class ImplicitAndExplicitConversion
    {
        static void Main()
        {
            #region Implicit Conversion

            //Implicit Conversion (Automatic) - 

            //No need to cast.
            //Safe because long can hold all int values.

            //Console.WriteLine("Int Max Value:" + int.MaxValue);//2147483647
            //Console.WriteLine("Long Max Value:" + long.MaxValue);//9223372036854775807

            int num = 1000000000;
            long bigNum = num;  // Implicit conversion (int → long)

            //Console.WriteLine(bigNum);   // Output: 1000000000

            #endregion

            #region Explicit Converison

            //Explicit Conversion (Manual using cast)

            //Console.WriteLine("Int Max Value:" + int.MaxValue);//2147483647
            //Console.WriteLine("Short Max Value:" + short.MaxValue);//32767

            int largeNum = 32767;
            short smallNum =(short)largeNum;// Explicit conversion (int → short)

            Console.WriteLine(smallNum);

            //You must write (short) to cast.
            //Risky: Chances of data loss.


            #endregion
        }
    }
}
