using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int result = Calculadora.soma(10, 20, 30, 40);
        Console.WriteLine(result);

        int a = 10;
        Calculadora.Triple(ref a);
        Console.WriteLine(a);


    }
}