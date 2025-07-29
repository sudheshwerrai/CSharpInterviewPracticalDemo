using System;

namespace CSharpInterviewPractical
{
    //Topic-Parameterized Constructor In C#
    #region Points to keep in mind
    //1-A parameterized constructor is used to pass values at the time of object creation.
    //2-It helps in initializing objects with specific values instead of using default values.
    //3-You can define multiple constructors with different parameters (constructor //overloading).
    //4-If you define any constructor (parameterized or not), the default constructor
    //won’t be //available unless explicitly defined.
    #endregion

    #region Real time example
    class BankAccount
    {
        public string AccountHolderName;
        public string AccountNumber;
        public double Balance;

        // Parameterized Constructor
        public BankAccount(string name, string accNumber, double initialBalance)
        {
            AccountHolderName = name;
            AccountNumber = accNumber;
            Balance = initialBalance;
        }
        

        public void DisplayAccountInfo()
        {
            Console.WriteLine("Account Holder: " + AccountHolderName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating object with initial values using parameterized constructor
            BankAccount account1 = new BankAccount("Sudheshwer Rai", "ACC123456", 5001.00);
            BankAccount account2 = new BankAccount("Divyanshu Rai", "ACC123457", 5003.00);
            account1.DisplayAccountInfo();
            account2.DisplayAccountInfo();
        }
    }
    #endregion
}
