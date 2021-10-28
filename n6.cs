/* Вычислить факториал числа p(при p > 0), используя цикл do while.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write(" p = ");
        int p = Convert.ToInt32(Console.ReadLine());
        int i = p;
        int factorial = 1;
        do
        {
            factorial = factorial * i;
        }
        while (i > 1);

        Console.WriteLine("{p}! = {factorial}");
        Console.WriteLine();

    }
}