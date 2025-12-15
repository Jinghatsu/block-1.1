using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число от 1 до 999: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number < 1 || number > 999)
        {
            Console.WriteLine("Число должно быть от 1 до 999");
            return;
        }
        
        string rubleForm;
        int lastDigit = number % 10;
        int lastTwoDigits = number % 100;
        
        if (lastTwoDigits >= 11 && lastTwoDigits <= 19)
            rubleForm = "рублей";
        else if (lastDigit == 1)
            rubleForm = "рубль";
        else if (lastDigit >= 2 && lastDigit <= 4)
            rubleForm = "рубля";
        else
            rubleForm = "рублей";
        
        Console.WriteLine($"{number} {rubleForm}");
    }
}