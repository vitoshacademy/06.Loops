using System;
using System.Collections.Generic;

class NFactorielAndKFactorielDivide
{
    static decimal CalculateFactoriel(int number)
    {
        decimal factoriel = 1M;
        for (int i = 1; i <= number; i++)
        {
            factoriel *= i;
        }

        return factoriel;
    }
    static void Main()
    {
        Console.Write("n=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k=");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine(CalculateFactoriel(n) / CalculateFactoriel(k));
    }
}
