// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите M");
int numM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите N");
int numN = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumNumbers(numM, numN));

int SumNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return n + SumNumbers(m, n - 1);
    }
}