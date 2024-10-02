using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Entre o número da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        String nome = Console.ReadLine();
        Console.Write("Haverá depósito inicial (s/n)?");
        char resp = char.Parse(Console.ReadLine());
        if (resp == 's' || resp == 'S')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            double deposito = double.Parse(Console.ReadLine());
            ContaBancaria conta = new ContaBancaria(numero, nome,deposito);
            Console.WriteLine(conta);
        }
        else
        {
            ContaBancaria conta = new ContaBancaria(numero, nome);
            Console.WriteLine(conta);
        }


        

    }
}