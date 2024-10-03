using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {   
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string[] values = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(values[j]);
            }
        }

        Console.WriteLine("Main Diagonal: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(mat[i, i] + " ");
        }
        Console.WriteLine();

        int contagem = 0;
        //estrutura base para correr um matrix
        for( int i = 0;i < n; i++)
        {
            for (int j = 0;j < n; j++)
            {
                if (mat[i, j] < 0)
                {
                    contagem++;
                }
            }
        }
        Console.WriteLine("Negative numbers: " + contagem);
    }


}
