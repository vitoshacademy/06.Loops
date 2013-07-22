//Write a program to calculate the Nth Catalan number by given N.


using System;
using System.Collections.Generic;

class CatalansNumbers
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
        int n = int.Parse(Console.ReadLine());


        Console.WriteLine(
            CalculateFactoriel(2 * n)
            /
            (CalculateFactoriel(n + 1) * CalculateFactoriel(n))
            );
    }
}
