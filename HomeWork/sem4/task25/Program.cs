
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

int exponent = numberA;

for (int i = 1; i < numberB; i++)
{
    exponent = exponent * numberA;
}
while (numberA == 0 && numberB == 0)
{
    Console.Write("Выражение не имеет смысла, так как не может быть определено");
    return;
}
Console.WriteLine("A в степени B равно: " + exponent);