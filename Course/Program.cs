using System.Globalization;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10;
        Console.WriteLine(a);

        a += 2;
        Console.WriteLine(a);

        a++;
        Console.WriteLine(a);

        a--;
        Console.WriteLine(a);


        int b = a++;
        Console.WriteLine(b);

        int c = ++a;
        Console.WriteLine(c);

    }
}