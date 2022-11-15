//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Please enter first number: ");
String? input = Console.ReadLine();
int a = Convert.ToInt32(input);

Console.Write("lease enter second number: ");
String? inputb = Console.ReadLine();
int b = Convert.ToInt32(inputb);

if (a > b)
{
    Console.Write(" the biggest number is ");
    Console.WriteLine(a);
    Console.Write(" the smallest number is ");
    Console.WriteLine(b);
}
else
{
    Console.Write(" the biggets number is "); 
    Console.WriteLine(b);
    Console.Write(" the smallest number is ");
    Console.WriteLine(a);
}



