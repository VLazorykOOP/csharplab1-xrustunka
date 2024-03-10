using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть периметр квадрата:");
        double perimeter = Convert.ToDouble(Console.ReadLine());

        // Отримання сторони квадрата за формулою периметра
        double side = perimeter / 4;

        // Обчислення площі квадрата
        double area = side * side;

        Console.WriteLine($"Площа квадрата з периметром {perimeter} дорівнює: {area}");
    }
}
