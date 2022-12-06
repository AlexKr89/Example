//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число обозначающее день недели: ");
int dayNumber = int.Parse(Console.ReadLine()!);

if ((dayNumber > 0) && (dayNumber < 8))
{
    if ((dayNumber == 6) || (dayNumber == 7))
    {
        Console.Write("Да -> Выходной ");
    }
    else
    {
        Console.Write("Нет -> Не выходной ");
    }
}
else
{
    Console.Write("Число не является днем недели ");
}