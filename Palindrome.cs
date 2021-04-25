//Given a number, the task is to check if this number is Palindrome or not

using System.IO;
using System;

class Program {
    static void Main(string[] args) {
        int num=123329;
        int rev=0;
        int lastDigit=0;
        int temp=num;
        while(num!=0)
        {
            lastDigit = num%10;
            rev = (rev*10) + lastDigit; 
            num = num/10;
        }
        if(rev==temp)
        {
            Console.WriteLine("Palindrome Number");
        }
        else
        {
            Console.WriteLine("Not a Palindrome Number");
        }
        
    }
}
