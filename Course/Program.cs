using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {  

        Pessoas p1 = new Pessoas();
        Pessoas p2 = new Pessoas();
        Pessoas p3 = new Pessoas();

        Console.WriteLine("Dados da Primeira Pessoa: ");
        p1.nome = Console.ReadLine();
        p1.idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Dados da Segunda Pessoa: ");
        p2.nome = Console.ReadLine();
        p2.idade = int.Parse(Console.ReadLine());

        if (p1.idade > p2.idade)
        {
            Console.WriteLine(p1.nome);
        }
        else
        {
            Console.WriteLine(p2.nome);
        }


        Funcionario f1 = new Funcionario();
        Funcionario f2 = new Funcionario();

        Console.WriteLine("Dados do primeiro funcionário: ");
        f1.nome = Console.ReadLine(); 
        f1.salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Dados do Segundo Funcionário: ");
        f2.nome = Console.ReadLine();
        f2.salario = double.Parse(Console.ReadLine());

        double medio = (f1.salario + f2.salario) / 2;

        Console.WriteLine(medio);



    }
}