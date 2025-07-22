using System;

namespace CSharpInterviewPractical
{
    //Const & ReadOnly IN C#

    class BankAccount
    {
        #region Const And ReadOnly
        
        // Const: Compile-time constant
        public const string BankName = "State Bank of India"; // Fixed for all accounts

        // Readonly: Assigned once at runtime
        public readonly string AccountNumber;

        public BankAccount(string accNumber)
        {            
            AccountNumber = accNumber; // Can only be assigned here            
        }

        public void ShowDetails()
        {            
            Console.WriteLine($"Bank: {BankName}");
            Console.WriteLine($"Account Number: {AccountNumber}");
        }
        #endregion

        static void Main()
        {
            //Const: Value is fixed at compile time and cannot change —
            //like Pi (π) or Days in a week.            

            //Readonly: Value is assigned at runtime, usually in
            //constructor, and cannot be changed after that —
            //like a bank account number.

            BankAccount bankAccount = new BankAccount("SBIN00012345");
            bankAccount.ShowDetails();
            
             //bankAccount.AccountNumber = "SBIN999999"; ❌ Not allowed - readonly
             //BankName = "Another Bank"; ❌ Not allowed - const

            //Recap
            //Use const when the value is always the same, for everyone and forever.
            //Use readonly when the value is set once per object, like IDs or keys.
        }
    }
}
