/*  Найти сумму первых N членов арифметической прогрессии с использованием цикла for.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(" n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine("Сумма первых {0} {1} членов арифметической прогрессии равна", n, sum);
        Console.WriteLine();

    }
}