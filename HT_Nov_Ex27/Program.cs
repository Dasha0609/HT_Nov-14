// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Please enter your number: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

int result = 0;

while (number > 0)
{
    result = result + number % 10;
    number = number/10;
}

Console.Write("colloquial of numbers is " + result);

