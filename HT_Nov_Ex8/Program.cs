// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("please enter your number N:");
string? input = Console.ReadLine();
int N = Convert.ToInt32(input);
int a = 1;

for (int i = a; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " , ");
    }
}

Console.ReadKey();


