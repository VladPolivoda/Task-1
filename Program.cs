using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Назва коледжу: Коледж економіки, права та інформаційних технологій");
        Console.WriteLine("Назва дисципліни: Технологія створення ПЗ");
        Console.WriteLine("ПІБ студента: Полівода Владислав Олегович");
        Console.WriteLine("Група: КН 21к-1");

        Console.WriteLine("Введіть коефіцієнти квадратного рівняння ax^2 + bx + c = 0");
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double D = b * b - 4 * a * c;

        Console.WriteLine($"Квадратне рівняння: {a}x^2 + {b}x + {c} = 0");

        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine($"Рішення: x1 = {x1}, x2 = {x2}");
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Рішення: x = {x}");
        }
        else
        {
            Console.WriteLine("Рівняння не має реальних коренів.");
        }
    }
}
