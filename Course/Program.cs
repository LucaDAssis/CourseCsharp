using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Produto p = new Produto("TV", 500.00, 10);
        Console.WriteLine("Entre os dados do produto:");
        Console.Write("Nome: ");
        String Nome = Console.ReadLine();
        Console.Write("Preço: ");
        double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade no estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Dados do produto: " + p);
        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        int qte = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qte);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);
        Console.WriteLine();
        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoverProdutos(qte);
        Console.WriteLine();
        Console.WriteLine("Dados atualizados: " + p);

    }
}