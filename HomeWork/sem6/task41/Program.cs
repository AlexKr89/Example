// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество цифр: ");
int number = int.Parse(Console.ReadLine()!);
int[] arr = new int[number];

Console.WriteLine($"Количество цифр больше нуля -> {CounterPosNum(UserFillArray(arr))}");

int[] UserFillArray(int[] array)
{
    for (int i = 0; i < number; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        arr[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int CounterPosNum(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > 0)
        {
            count++;
        }
    }
    return count;
}