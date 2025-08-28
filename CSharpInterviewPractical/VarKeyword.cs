
using System;
using System.Collections;

namespace CSharpInterviewPractical
{
    class Program
    {

        int i = 10;
        double j = 20.4;
        char k = 'C';
        bool l = true;
        string m = "Test";
        object n = null;

        static void Main()
        {
            //Var Keyword in C#
           

            var program = new Program();
            var o = 10;

            var arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add("Ten");
            arrayList.Add(10.00);
            arrayList.Add(true);
            arrayList.Add('C');

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
