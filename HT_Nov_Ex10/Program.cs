// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Please enter three-digit number");

while (true)
{
    string input = Console.ReadLine();
    Console.WriteLine("{0}->{1}",input, input[1]);
    break;
}