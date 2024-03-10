using System;

class Program6
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть значення для a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть значення для b:");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = a + ((a + b - 1) / (Math.Pow(a, 2) + 1)) - (a * b);

        Console.WriteLine($"Результат виразу: {result}");
    }
}
