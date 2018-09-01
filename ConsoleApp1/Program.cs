using System;

interface ICustomer1
{
   void Print1();
    
}

interface ICustomer2:ICustomer1
{
    void Print2();
}

public class customer : ICustomer2
{
    public void Print1()
    {
        Console.WriteLine("Print1");
    }

    public void Print2()
    {
        Console.WriteLine("Print2");
    }
}

public class sample
{

}

public class Program 
{
    public static void Main()
    {
        ICustomer1 c1 = new customer();
        c1.Print1();
       // c1.Print2();
        //c1.Print();

    }
}