// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        int g = 10;

        Console.WriteLine("Hello world");

        Console.WriteLine("Buenos dias");
    }

    static int calculateAvg(int[] tab)
    {
        int avg = 0;
        for (int x = 0; x < tab.Length; x++)
        {
            avg += tab[x];
        }

        return avg / tab.Length;
    }
}