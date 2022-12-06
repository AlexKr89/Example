Console.Write(" Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);

bool first = false;

for (int i = 1; i <= number1; i++)
{
    if (i % 2 == 0)
    {
        if (first == true)
        { Console.Write(" , " + i); }
        else
        {
            first = true;
            Console.Write(i);
        }
    }
}