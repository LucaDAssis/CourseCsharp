using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Entrada:  ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int soma = a + b;
        Console.WriteLine("Soma = " + soma);

        Console.WriteLine("===========================");
        Console.WriteLine("Entrada: Valor do Raio");
        double d = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(d, 2);
        Console.WriteLine($"Saída: A={area:F4}");

        Console.WriteLine("======================================");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());
        int n4 = int.Parse(Console.ReadLine());
        int diferenca = (n1 * n2 - n3 * n4);
        Console.WriteLine("Diferença = " + diferenca);

       
        
    }
}