// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine()!);
double x = 0;
double y = 0;

if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются.");
}
else
{
    double FindX(double k1, double b1, double k2, double b2)
    {

        x = (b2 - b1) / -(k2 - k1);
        x = Math.Round(x, 3);
        return x;
    }
    double FindY(double k1, double b1)
    {;

        y = k1 * x + b1;
        y = Math.Round(y, 3);
        return y;
    }
    Console.WriteLine();
    Console.Write("Точка пересечения данных прямых: (" + FindX(k1, b1, k2, b2) + "; ");
    Console.Write(FindY(k1, b1) + ")");
}