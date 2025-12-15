using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите день: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Введите месяц: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Введите год: ");
        int year = int.Parse(Console.ReadLine());
        
        int[] daysInMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        
        // Проверка на високосный год
        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        if (isLeapYear)
            daysInMonth[1] = 29;
        
        day++;
        if (day > daysInMonth[month - 1])
        {
            day = 1;
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
        }
        
        Console.WriteLine($"Дата следующего дня: {day:D2}.{month:D2}.{year}");
    }
}   