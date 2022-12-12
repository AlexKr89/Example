void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Index0f(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // Если элемента который мы ищем нет то выводится значение -1
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array); // Заполнение массива
array[4] = 4; //Принудительная цифра 4 на 4м индексе
array[6] = 4; //Принудительная цифра 4 на 6м индексе
PrintArray(array);
Console.WriteLine();

int pos = Index0f(array, 444); // Метод поиска значения в массиве
Console.WriteLine(pos);