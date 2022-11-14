// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int a = 20;
int b = 10;
int c = 6;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);

if (a > b)
{
    if (a > c)
    {
        Console.Write("max is ");
        Console.WriteLine(a);
    }
    else
    {
        Console.Write("max is ");
        Console.WriteLine(c);
    }
}
else
if (b > c)
{
    Console.Write("max is ");
    Console.WriteLine(b);
}

