Console.Write("Введите 2 числа ");

int number1 = int.Parse(Console.ReadLine()!);
int number2 = int.Parse(Console.ReadLine()!);

if(number1 == number2)
{
    Console.Write(" Числа равны ");
} else if (number1 > number2)
{
    Console.WriteLine(" Первое число больше: " + number1 );
} else
{
    Console.WriteLine(" Второе число больше: " + number2);
}
