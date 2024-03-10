using System;

class Program4
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть порядковий номер місяця:");
        int month = Convert.ToInt32(Console.ReadLine());

        // Перевірка на валідність номера місяця
        if (month < 1 || month > 12)
        {
            Console.WriteLine("Невірно введений номер місяця.");
            return;
        }

        // Кількість місяців, які залишилися до кінця року
        int monthsLeft = 12 - month;

        Console.WriteLine($"Залишилося {monthsLeft} місяців до кінця року.");
    }
}
