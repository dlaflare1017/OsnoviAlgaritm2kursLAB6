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

      string result = (a, b, c) switch

      {

        // Проверяем, что стороны положительные

        var (x, y, z) when x <= 0 || y <= 0 || z <= 0

          => "→ Стороны должны быть положительными числами!",



        // Проверяем существование треугольника

        var (x, y, z) when !(x + y > z && x + z > y && y + z > x)

          => "→ Такой треугольник не существует.",



        // Проверяем, является ли прямоугольным

        var (x, y, z) when Math.Abs(x * x + y * y - z * z) < 1e-6

                || Math.Abs(x * x + z * z - y * y) < 1e-6

                || Math.Abs(y * y + z * z - x * x) < 1e-6

          => "→ Треугольник является прямоугольным.",



        // Иначе просто существующий, но не прямоугольный

        _ => "→ Треугольник не является прямоугольным."

      };



      Console.WriteLine(result);

    }

  }

}
