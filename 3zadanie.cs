using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите три целых числа: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        
        // Сортировка
        if (a > b) (a, b) = (b, a);
        if (b > c) (b, c) = (c, b);
        if (a > b) (a, b) = (b, a);
        
        Console.WriteLine($"Числа в порядке возрастания: {a}, {b}, {c}");
    }
}