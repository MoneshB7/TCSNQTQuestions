using System.IO;
using System;

class Program {
    static void Main(string[] args) {
      int num=5;
      int temp=0;
      int a=0;
      int b=1;
      int c=0;
      Console.Write(0+" "+1+" ");
      for(int i=0;i<=num;i++)
      {
          c=a+b;
          a=b;
          b=c;
          Console.Write(c +" ");
      }
    }
}
