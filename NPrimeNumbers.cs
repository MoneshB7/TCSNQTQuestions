//Given a number N, the task is to find the Prime Numbers from 1 to N
using System.IO;
using System;

class Program
{
    static void Main()
    {
        int a=20;
        for(int i=1;i<=a;i++)
        {
            int result = primeFunc(i);
            if(result==1)
            {
                Console.WriteLine(i);
            }
        }

    }
    
   static int primeFunc(int x)
    {
        int count=0;
        for(int i=1;i<=x;i++)
        {
            if(x%i==0)
            {
                count+=1;
            }
        }
        if(count==2)
        {
            return 1;
        }
        return 0;
    }
}
