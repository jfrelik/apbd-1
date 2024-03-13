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
        for (int j = 0; j < tab.Length; j++)
        {
            avg += tab[j];
        }

        return avg / tab.Length;
    }

    static int findMax(int[] tab)
    {
        return tab.Max();
    }
}