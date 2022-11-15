// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("please enter your number:");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

if (number % 2==0)
{
    Console.WriteLine("it's an even number");
}
else
{
    Console.WriteLine("it's an odd number");
}









