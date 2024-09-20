using System.Globalization;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double a;
        float b;

        a = 5.1;
        b = (float)a;

        Console.WriteLine(b);

        int c = 5;
        int y = 2;

        double resultado = (double) c / y;

        Console.WriteLine(resultado);

    }
}