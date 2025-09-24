using System;

namespace IsAndAsOperator
{
    #region Realtime Example
    class Employee
    {
        public string Name { get; set; }
    }

    class Manager : Employee
    {
        public void ApproveLeave()
        {
            Console.WriteLine($"{Name} approved leave.");
        }
    }

    class Developer : Employee
    {
        public void WriteCode()
        {
            Console.WriteLine($"{Name} is writing code.");
        }
    }

    #endregion

    class Program
    {
        static void Main()
        {
            //object number = "123";
            //if (number is string value)
            //    Console.WriteLine("True"+ value);
            //else
            //    Console.WriteLine("False");

            //object name = 123;
            //string newName = name as string;
            //Console.WriteLine(newName);

            #region Realtime example
            //Using is:
            //Employee emp = new Developer { Name = "Sudheshwer" };

            //if (emp is Manager m)
            //{
            //    m.ApproveLeave();
            //}
            //else if (emp is Developer d)
            //{
            //    d.WriteCode();
            //}

            //Using as:

            Employee emp = new Manager { Name = "Disha" };

            Manager manager = emp as Manager;
            if (manager != null)
            {
                manager.ApproveLeave();
            }
            else
            {
                Console.WriteLine("Not a Manager.");
            }
            #endregion
        }
    }
}
