//Swap two numbers without using a third variable
using System;

class Program {
    static void Main(string[] args) {
        int a=6;
        int b=5;
        Console.WriteLine("Before Swapping - a:{0}, b:{1} ",a,b);
        a=a+b;
        b=a-b;
        a=a-b;
        Console.WriteLine("After Swapping - a:{0}, b:{1} ",a,b);
    }
}
