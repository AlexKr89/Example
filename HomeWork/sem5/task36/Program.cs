// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// Размер массива, минимальное значение и максимальное значение вводим через консоль

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int numsize = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение");
int min = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение");
int max = int.Parse(Console.ReadLine()!);

int[] newArray = GenerateArray(numsize, min, max);
Console.WriteLine();

PrintArray(newArray);

int[] GenerateArray(int size, int min, int max)
{
    int[] arrayRnd = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrayRnd[i] = new Random().Next(min, max + 1);
    }
    return arrayRnd;
}

int sumOdd(int[] newArray)
{
    int summ = 0;
    for (int i = 1; i < newArray.Length; i += 2)
    {

        summ += newArray[i];
    }
    return summ;
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

Console.Write("Сумма нечетных = " + sumOdd(newArray));