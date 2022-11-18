// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Please enter three-digit number");
string? input = Console.ReadLine();
int a = Convert.ToInt32(input);
int number = input[input.Length - 1] - '0';


if (input.Length >= 3)
{
    Console.WriteLine("The third number is  " + input.ToString () + " = " + input.ToString()[2]);
}
else
{
    Console.WriteLine("There is no third number");
}

       