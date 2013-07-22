//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.


using System;

class Program
{
    static void Main()
    {
        Console.Write("How many numbers will you compare? ");
        int lastNumber = int.Parse(Console.ReadLine());
        int currentNumber, min, max;
        Console.Write("Enter the 1 number: ");
        currentNumber = int.Parse(Console.ReadLine());
        min = max = currentNumber;
        for (int i = 1; i < lastNumber; i++)
        {
            Console.Write("Enter the {0} number: ", i + 1);
            currentNumber = int.Parse(Console.ReadLine());
            if (max < currentNumber)
            {
                max = currentNumber;
            }
            if (min > currentNumber)
            {
                min = currentNumber;
            }
        }
        Console.WriteLine("The smallest is {0}", min);
        Console.WriteLine("The biggest is {0}", max);
    }
}
