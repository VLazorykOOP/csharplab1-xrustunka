using System;

class Program5
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть перше ціле число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введіть друге ціле число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = Sum(num1, num2);

        Console.WriteLine($"Сума чисел {num1} і {num2} дорівнює {sum}.");
    }

    static int Sum(int a, int b)
    {
        return a + b;
    }
}
