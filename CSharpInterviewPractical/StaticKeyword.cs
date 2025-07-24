using System;
using System.Runtime.CompilerServices;
namespace CSharpInterviewPractical
{
    //Topic - Static Keyword

    //1-Static members belong to the class, not objects.
    //2-You can’t use this in static methods.
    //3-You can access static members with: ClassName.Member.
    //4-A static class cannot be instantiated or inherited.
    //5-Static class only allow static members.
    //6-Static class will only allow single static constructor.
    //7-Access modifier are not allowed in static constructor.

    #region Part 1- Understand Static Keyword Use
   // static class First
   // {
   //     const string name = "Abc";
   //     static First()
   //     {
            
   //     }
   //     public static int number = 0;
   // }

   //class Second
   // {
   //     string name;
   //     static void Test()
   //     {

   //     }
   //     static void Main()
   //     {
   //         var obj = new First();

   //     }
   // }

    #endregion

    #region Part 2- Real Time Static Examle
    public static class TaxHelper
    {
        public static decimal taxRate = 0.18m;

        // Static method to calculate tax
        public static decimal CalculateTax(decimal amount)
        {
            return amount * taxRate;
        }
    }

    public class Invoice
    {
        public int InvoiceId;
        public decimal Amount;

        public void PrintInvoice()
        {
            decimal tax = TaxHelper.CalculateTax(Amount);
            decimal total = Amount + tax;

            Console.WriteLine($"Invoice ID: {InvoiceId}");
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Tax (@{TaxHelper.taxRate * 100}%): {tax}");
            Console.WriteLine($"Total: {total}");
        }
    }

    class Program
    {
        static void Main()
        {
            var inv1 = new Invoice { InvoiceId = 1, Amount = 1000 };
            inv1.PrintInvoice();

            var inv2 = new Invoice { InvoiceId = 2, Amount = 500 };
            inv2.PrintInvoice();
        }
    }

    #endregion

}
