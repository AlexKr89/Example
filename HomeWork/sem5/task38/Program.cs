// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Размер массива, минимальное значение и максимальное значение вводим через консоль
// Для генерации вещественных числе, по аналогии с int, есть функция NextDouble()

// [3 7 22 2 78] -> 76

Random rnd = new Random();

Console.Write("Введите размер массива: ");
int numsize = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите минимальное значение");
double min = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите максимальное значение");
double max = double.Parse(Console.ReadLine()!);

double[] newArray = GenerateArray(numsize, min, max);
Console.WriteLine();

PrintArray(newArray);

double[] GenerateArray(int size, double min, double max)
{
    double[] arrayRnd = new double[size];
    for (int i = 0; i < size; i++)
    {
        arrayRnd[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
    }
    return arrayRnd;
}

double resultDiff(double[] newArray)
{
    double findMin = newArray[0];
    double findMax = newArray[0];
    for (int i = 1; i < newArray.Length; i++)
    {
        if (findMin > newArray[i]) findMin = newArray[i];
        if (findMax < newArray[i]) findMax = newArray[i];
    }
    return Math.Round((findMax - findMin), 2);
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.Write("Разница между максимальным и минимальным элементов массива = " + resultDiff(newArray));