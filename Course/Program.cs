using System.Globalization;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";
        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';
        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;

        Console.WriteLine("Produtos: ");
        Console.WriteLine($"{produto1}, Cujo o preço é ${preco1}");
        Console.WriteLine($"{produto2}, cujo o preço é ${preco2}");

        Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero{genero}");

        // Exibir medida com oito casas decimais
        Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");

        // Arredondar para três casas decimais e exibir
        Console.WriteLine($"Arredondado (três casas decimais): {Math.Round(medida, 3)}");

        // Exibir medida com três casas decimais usando CultureInfo.InvariantCulture
        Console.WriteLine(medida.ToString("F3", CultureInfo.InvariantCulture));
    

    }
}