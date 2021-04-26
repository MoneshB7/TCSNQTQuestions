using System.IO;
using System;

class Program
{
    static void Main()
    {
        int a=5;
        int count=0;
        for(int i=1;i<=a;i++)
        {
            if(a%i==0)
            {
                count+=1;
            }
        }
        if(count==2)
        {
            Console.WriteLine("Prime Number");
        }
        else{
            Console.WriteLine("Not a Prime Number");
        }
    }
}
