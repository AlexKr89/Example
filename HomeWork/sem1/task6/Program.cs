Console.WriteLine("Введите число");

string number1 = Console.ReadLine()!;

int parsed1 = int.Parse(number1);

if (parsed1 % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}