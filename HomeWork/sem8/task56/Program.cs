// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите m");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine()!);

int[,] myMatrix = Create2DArray(m, n, 1, 10);
Print2DArray(myMatrix);
Console.WriteLine(SumMaxString(myMatrix) + " строка");

int SumMaxString(int[,] matrix)
{
    int str = 0;
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int newSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newSum += matrix[i, j];
        }
        if (newSum > sum)
        {
            sum = newSum;
            str = i + 1;
        }
    }
    return str;
}

int[,] Create2DArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}