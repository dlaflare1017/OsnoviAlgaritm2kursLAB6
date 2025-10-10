using System;

class Program
{
    static void Main()
    {
        // Массивы со сторонами трёх треугольников
        double[,] triangles =
        {
            { 3, 3.5, -2.1 },
            { 21, -6.55, 0.1 },
            { -9, -3.7, -0.1 }
        };

        for (int i = 0; i < 3; i++)
        {
            double a = triangles[i, 0];
            double b = triangles[i, 1];
            double c = triangles[i, 2];

            Console.WriteLine($"\nТреугольник {i + 1}: a={a}, b={b}, c={c}");

            if (a > 0 && b > 0 && c > 0)
            {
                // Проверяем существование треугольника
                if (a + b > c && a + c > b && b + c > a)
                {
                    // Проверка по теореме Пифагора
                    bool isRight =
                        Math.Abs(a * a + b * b - c * c) < 1e-6 ||
                        Math.Abs(a * a + c * c - b * b) < 1e-6 ||
                        Math.Abs(b * b + c * c - a * a) < 1e-6;

                    if (isRight)
                        Console.WriteLine("→ Треугольник является прямоугольным.");
                    else
                        Console.WriteLine("→ Треугольник не является прямоугольным.");
                }
                else
                {
                    Console.WriteLine("→ Такой треугольник не существует.");
                }
            }
            else
            {
                Console.WriteLine("→ Стороны должны быть положительными числами!");
            }
        }
    }
}
