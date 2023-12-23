using System;

public class Reverse
{
    public static void Main(string[] args)
    {
        int n, m, reverse=0;
        Console.Write("Enter the Number = ");
        n=int.Parse(Console.ReadLine());
        while(n!=0)
        {
            m=n%10;
            reverse=reverse*10+m;
            n=n/10;
        }
        Console.Write("Reverse of number = "+reverse);
    }
}
