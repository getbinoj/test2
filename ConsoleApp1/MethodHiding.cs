using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am in Base class");
        }
    }

    public class Derived : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("I am in derived class");
        }

    }

    public class Derived2 : BaseClass
    {
       

    }

    public class Program
    {

        public static void Main()
        {
            BaseClass D=new Derived();
            D.Print();

            BaseClass D1 = new Derived2();
            D1.Print();

        }



    }
}
