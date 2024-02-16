using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in en mening");
        string[] x = Console.ReadLine().Split(' ');
        Uppercase(x);

        Console.WriteLine();
    }

    static void Uppercase(string[] mening)
    {
        bool nextToUpper = true;

        foreach (string ord in mening)
        {
            if (nextToUpper)
            {
                Console.Write(ord.ToUpper() + " ");
            }
            else
            {
                Console.Write(ord.ToLower() + " ");
            }

            nextToUpper = !nextToUpper;
        }
    }
}
