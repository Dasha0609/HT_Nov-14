// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("please enter number a: ");
string? inputa = Console.ReadLine();
int a = Convert.ToInt32(inputa);
Console.Write("please enter number b: ");
string? inputb = Console.ReadLine();
int b = Convert.ToInt32(inputb);
Console.Write("please enter number c: ");
string? inputc = Console.ReadLine();
int c = Convert.ToInt32(inputc);

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

