/*Вывести на экран, консольного приложения, прямоугольный треугольник из звездочек “*”, с длиной катета m.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("m = ");
        int m = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= m; i++)
        {
            int j = 0;
            while (j < i)
            {
                Console.Write("*");
                j++;
            }          

            Console.WriteLine();
        }
        
        Console.ReadLine();
    }
}