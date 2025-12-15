using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты ферзя (от 1 до 8):");
        int queenX = int.Parse(Console.ReadLine());
        int queenY = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите координаты фигуры противника (от 1 до 8):");
        int enemyX = int.Parse(Console.ReadLine());
        int enemyY = int.Parse(Console.ReadLine());
        
        bool onSameRow = queenX == enemyX;
        bool onSameColumn = queenY == enemyY;
        bool onSameDiagonal = Math.Abs(queenX - enemyX) == Math.Abs(queenY - enemyY);
        
        if (onSameRow || onSameColumn || onSameDiagonal)
            Console.WriteLine("Ферзь бьет фигуру");
        else
            Console.WriteLine("Ферзь не бьет фигуру");
    }
}