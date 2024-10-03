using Course;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Now;
        Console.WriteLine(dateTime);

        DateTime data = DateTime.Now;
        DateTime data1 = DateTime.Today;
        DateTime d1 = DateTime.Parse("07/12/1994");

        Console.WriteLine(data);
        Console.WriteLine(data1);
        Console.WriteLine(d1);

        TimeSpan t1 = new TimeSpan();
        TimeSpan t2 = new TimeSpan(9000000L);
        TimeSpan t3 = new TimeSpan(2, 11, 21);

        Console.WriteLine(t1);
        Console.WriteLine(t3);
        Console.WriteLine(t2);
    }
}