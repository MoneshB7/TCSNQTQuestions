using System.IO;
using System;
//Print Factorial of a number
class Program {
    static void Main(string[] args) {
        int num=6;
        int fact=1;
        for(int i=1;i<=num;i++)
        {
            fact = fact*i; 
        }
        Console.WriteLine(fact);
    }
}
