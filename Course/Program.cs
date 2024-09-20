using System.Globalization;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bom Dia!!");
        Console.Write("Boa Noite");
        Console.Write("Bom Dia!!");

        char gener = 'A';
        int idade = 10;
        double saldo = 100.449494949;
        String nome = "Luscas";

        Console.WriteLine("------------------------------------");

        Console.WriteLine(nome);
        Console.WriteLine(idade);
        Console.WriteLine(saldo.ToString("F2"));
        Console.WriteLine(saldo.ToString("F4"));
        Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
        Console.WriteLine(gener);

        //placehoder
        Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais", nome, idade, saldo);

        //placehoder melhor
        Console.WriteLine($"{nome} tem {idade} anos e tem saldo igal a {saldo:F2} reais");

        //Concatenação
        Console.WriteLine(nome + "tem " + idade + "anos e tem saldo igual a " + saldo + "reais");

    }
}