using System;

//Private Constructor IN C#
public class Singleton
{   
    private static Singleton _instance;
    private static int counter = 0;

    private Singleton()
    {
        counter++;
        Console.WriteLine("Instance Created:" + counter);
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
}

class Program
{
    static void Main()
    {
        //Singleton obj1 = new Singleton();
        //Singleton obj2 = new Singleton();

        Singleton obj1 = Singleton.GetInstance();
        Singleton obj2 = Singleton.GetInstance();

        Console.WriteLine(object.ReferenceEquals(obj1, obj2)); 
    }
}
