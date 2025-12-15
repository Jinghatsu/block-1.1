using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты коня (от 1 до 8):");
        int knightX = int.Parse(Console.ReadLine());
        int knightY = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите координаты фигуры противника (от 1 до 8):");
        int enemyX = int.Parse(Console.ReadLine());
        int enemyY = int.Parse(Console.ReadLine());
        
        int dx = Math.Abs(knightX - enemyX);
        int dy = Math.Abs(knightY - enemyY);
        
        if ((dx == 1 && dy == 2) || (dx == 2 && dy == 1))
            Console.WriteLine("Конь бьет фигуру");
        else
            Console.WriteLine("Конь не бьет фигуру");
    }
}