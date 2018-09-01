﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IA
{
    void AMethod();

}

interface IB
{
    void BMethod();
}

class A:IA
{
    public void AMethod()
    {
        Console.WriteLine("A");
    }
}

class B:IB
{
    public void BMethod()
    {
Console.WriteLine("B");
    }
}

class AB:IA,IB
{
    A a=new A();
    B b=new B();
    public void AMethod()
    {
         a.AMethod();
    }

    public void BMethod()
    {
        b.BMethod();
    }
}
class Program
{
    public static void Main()
    {
        AB ab=new AB();

        ab.AMethod();
        ab.BMethod();
    }
}