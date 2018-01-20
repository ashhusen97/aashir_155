using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sirwasiq
{
    class Program
    {
class NumOperation{
private int a;
private int b;

public void setvalue(int a,int b)
{
this.a = a ;
this.b=b;
}

public void swap()
{
Console.WriteLine("Numbers Before Swapped -->"+a+" "+b);
int temp;
temp=a;
a=b;
b=temp;
Console.WriteLine("Swapped Numbers -->"+a+" "+b);
}
public void add()
{
Console.WriteLine("========================================\n\n");
int temp;
temp = a+b;
Console.WriteLine("Addition of " + a + " + "+b+" = " + temp);
}
public void evenodd(int num)
{
Console.WriteLine("========================================\n\n");
if(num%2==0)
{
Console.WriteLine(num+" is Even Number.");
}
else
Console.WriteLine(num+" is Odd Number.");
}
public void factorial(int n)
{
int i;
Console.WriteLine("========================================\n\n");

     long factorial = 1;
    if(n<0)
Console.WriteLine("Factorial of negative number is not allowed");
else
{
for(i=1; i<=n; ++i)
        {
            factorial *= i;             
        }
Console.WriteLine("Factorial of "+n+" is --> "+factorial);
}
}


}
        static void Main(string[] args)
        {
 NumOperation n = new NumOperation();
n.setvalue(10,20);           
n.swap();
n.add();
n.evenodd(19);
n.factorial(5);
Console.ReadKey();
        }
    }
}
