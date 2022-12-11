// Задача 29: Напишите программу, которая принимает на вход числа n, min, max. Затем генерирует массив размером n и заполняет его случайными числами в диапазоне от min до max.

// 5, 1, 19 -> [1, 2, 5, 7, 19]

// 3, 1, 33 -> [6, 1, 33]

Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение: ");
int max = int.Parse(Console.ReadLine()!);


int[] array = new int[n];

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(array[position] + " ");
        position++;
    }
}
FillArray(array);

PrintArray(array);