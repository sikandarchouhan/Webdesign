using System;

public class Swap
{
    public static void Main(string[] args)
    {
        int a, b;
        Console.Write("Input a = ");
        a=int.Parse(Console.ReadLine());
        Console.Write("Input b = ");
        b=int.Parse(Console.ReadLine());
        Console.WriteLine("Before swap a = "+a+" and b ="+b);
        a=a*b;
        b=a/b;
        a=a/b;
         Console.WriteLine("After swap a = "+a+" and b ="+b);
    }
}
