using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Customer
{
    private int id;
    public abstract void Print();

}


public interface Icustomer
{

   
    void Print();

} 



public  class Program : Customer
{
    public static void Main()
    {
        Customer P=new Program();

        P.Print();

       P.Print();



    }

    public override void Print()
    {
        Console.WriteLine("Print Method");
    }
}