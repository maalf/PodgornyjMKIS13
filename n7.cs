/*Посчитать количество и сумму парных чисел в диапазоне от 1 до N.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("N = ");
        int N = Convert.ToInt32(Console.ReadLine());

        var count = 0;
        var sum = 0;
        while (N > 0)
        {
            if (N % 2 == 0)
            { 
                count++;
                sum += N;
            }

            N -= 1;
        }

        Console.WriteLine("Количество парных {0}; Сумма парных: {1}", count, sum);

        Console.ReadLine();
    }
}