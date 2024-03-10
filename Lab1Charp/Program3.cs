using System;

class Program3
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть координату x точки:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть координату y точки:");
        double y = Convert.ToDouble(Console.ReadLine());

        if (y > x)
        {
            Console.WriteLine("Точка знаходиться всередині заштрихованої області");
        }
        else if (y < x / 2)
        {
            Console.WriteLine("Точка знаходиться поза заштрихованою областю");
        }
        else if (y == x)
        {
            Console.WriteLine("Точка знаходиться на межі заштрихованої області");
        }
        else
        {
            Console.WriteLine("Точка знаходиться поза заштрихованою областю");
        }
    }
}
