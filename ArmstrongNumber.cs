using System.IO;
using System;
//Check if a number is an Armstrong number or not.
class Program {
    static void Main(string[] args) {
      int num=153;
      int temp = num;
      int length = Convert.ToString(num).Length;
      int sum=0;
      for(int i=0;i<length;i++)
      {
        int x = num%10;
        sum += fun(x,length);
        num = num/10;
      }
      Console.WriteLine(sum);
        if(sum==temp)
        {
          Console.WriteLine("Armstrong Number");
        }
        else{
          Console.WriteLine("Not an Armstrong Number");
        }
    
    }
    
    public static int fun(int a, int length)
    {
        int result=1;
      for(int i=0;i<length;i++)
      {
        result *= a;     
          
      }
      return result;
    }
}
