using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface I1
{
    void InterfaceMethod();
}

interface I2
{
    void InterfaceMethod();
}


public class Program:I1,I2
{
     public void InterfaceMethod()
    {
        Console.WriteLine("I1 interface method");
    }

    void I2.InterfaceMethod()
    {
        Console.WriteLine("Interface 2 method");
    }

    public static void Main()
    {
        I1 P=new Program();
        P.InterfaceMethod();
        ((I1)P).InterfaceMethod();
        ((I2)P).InterfaceMethod();
    }
}