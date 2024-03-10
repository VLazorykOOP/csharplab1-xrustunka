using System;

class Program2
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть перше число:");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть друге число:");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Визначення максимального значення
        double maxNumber = Math.Max(number1, number2);

        Console.WriteLine($"Максимальне значення: {maxNumber}");
    }
}
