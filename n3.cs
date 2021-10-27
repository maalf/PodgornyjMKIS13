using System;

class Program
{
    static void Main(string[] args)
    {
        int n1 = Convert.ToInt32(Console.ReadLine());
        if (n1 >= 0)
            Console.WriteLine("положительное");
        if (n1 <= 0)
            Console.WriteLine("отрицательное");
        if (n1 == 0)
            Console.WriteLine("равно нулю");
        
    }
}