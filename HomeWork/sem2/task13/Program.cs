// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number < 0) number = Math.Abs(number);

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number >= 1000)
    {
        number /= 10;
    }
    Console.WriteLine(number % 10);
}