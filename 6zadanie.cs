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
        
        bool isValid = true;
        
        if (month < 1 || month > 12)
            isValid = false;
        else if (day < 1)
            isValid = false;
        else
        {
            int[] daysInMonth = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            
            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            if (isLeapYear && month == 2)
                daysInMonth[1] = 29;
            
            if (day > daysInMonth[month - 1])
                isValid = false;
        }
        
        Console.WriteLine(isValid ? "Дата корректна" : "Дата некорректна");
    }

}
