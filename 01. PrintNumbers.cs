//Write a program that prints all the numbers from 1 to N.

using System;
class Program
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Printing numbers from 1 to {0}, including {0}:", inputNumber);
        for (int i = 1; i <= inputNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}
