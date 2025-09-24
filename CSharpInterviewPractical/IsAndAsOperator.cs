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
            //Is Example
            //object number = 123;
            //if (number is int newNumber)
            //    Console.WriteLine("Yes,true"+ newNumber);
            //else
            //    Console.WriteLine("No,false");

            //As Example
            //object name = "Sudheshwer";
            //string userName = name as string;
            //Console.WriteLine(userName);

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

            Developer dev = emp as Developer;
            if (dev != null)
            {
                dev.WriteCode();
            }
            else
            {
                Console.WriteLine("Not a Manager.");
            }
            #endregion
        }
    }
}
