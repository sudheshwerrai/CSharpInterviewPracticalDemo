using System;

namespace FinalizeDemo
{
    class FinalizeExample
    {
        public FinalizeExample()
        {
            Console.WriteLine("Constructor: FinalizeExample object created");
        }

        ~FinalizeExample()
        {
            Console.WriteLine("Finalizer: FinalizeExample object is being finalized");
        }

        static void CreateObject()
        {
            FinalizeExample obj = new FinalizeExample();
        }

        static void Main()
        {
            CreateObject();
            GC.Collect(); // Force garbage collection
            GC.WaitForPendingFinalizers(); // Wait for finalizer to run

            Console.WriteLine("Main method completed");
        }
    }


}
