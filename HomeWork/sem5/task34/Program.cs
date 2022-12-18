// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Размер массива вводим через консоль

// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int numsize = int.Parse(Console.ReadLine()!);

int[] newArray = GenerateArray(numsize);
Console.WriteLine();

PrintArray(newArray);

int[] GenerateArray(int size)
{
    int[] arrayRnd = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrayRnd[i] = new Random().Next(100, 1000);
    }
    return arrayRnd;
}

int sumOdd(int[] newArray)
{
    int calc = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] % 2 == 0)
        {
            calc++;
        }
    }
    return calc;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.Write("Количество четных = " + sumOdd(newArray));