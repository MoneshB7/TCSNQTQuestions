//Find greatest of three numbers

using System.IO;
using System;

class Program
{
    static void Main()
    {
        int a=10;
        int b=6;
        int c=7;
        
        if(a>b && a>c)
        {
                    Console.WriteLine("{0} is the greatest number",a);
        }
        else if(b>a && b>c)
        {
                     Console.WriteLine("{0} is the greatest number",b);
        }
        else if(c>a && c>b)
        {
                     Console.WriteLine("{0} is the greatest number",c);
        }
    }
}
