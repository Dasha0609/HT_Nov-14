// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Без использования функции Math.Pow.

Console.Write("Please add first number: ");
string inputA = Console.ReadLine();
int numberA = Convert.ToInt32(inputA);

Console.Write("Please add second number: ");
string inputB = Console.ReadLine();
int numberB = Convert.ToInt32(inputB);

int result = 1;

for (int i = 1; i <= numberB; i++)
{
    result =  result * numberA;
}

Console.Write(result);