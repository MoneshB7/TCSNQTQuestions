//Check if a string is plaindrome or not

using System.IO;
using System;

class Program
{
    static void Main()
    {
        string name="MALAYALAM";
        string nameReversed = string.Empty;
        for(int i=name.Length-1;i>=0;i--)
        {
            nameReversed+=name[i];
        }
        if(name==nameReversed)
        {
            Console.Write("Palindrome String");
        }
        else
        {
            Console.Write("Not a Palindrome String");
        }
    }

}
