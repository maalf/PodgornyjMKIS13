/* Напишите программу, которая сравнивает, введенное пользователем, целое число с нулем, и выводит одно из сообщений:
число отрицательное;
число равно нулю;
число положительное.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        int n1 = Convert.ToInt32(Console.ReadLine());
        if (n1 >= 0)
            Console.WriteLine("число положительное");
        if (n1 <= 0)
            Console.WriteLine("число отрицательное");
        if (n1 == 0)
            Console.WriteLine("число равно нулю");
        
    }
}
