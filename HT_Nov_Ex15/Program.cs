// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int weekday;
Console.WriteLine("Please enter day number from 1 thru 7");
weekday = Convert.ToInt32(Console.ReadLine());

/*switch (weekday)
{
    case 1:
    Console.WriteLine("Workday");
    break;
    case 2:
    Console.WriteLine("Workday");
    break;
    case 3:
    Console.WriteLine("Workday");
    break;
    case 4:
    Console.WriteLine("Workday");
    break;
    case 5:
    Console.WriteLine("Workday");
    break;
    case 6:
    Console.WriteLine("Weekend");
    break;
    case 7:
    Console.WriteLine("Weekend");
    break;
}*/

switch (weekday)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    Console.WriteLine("Workday");
    break;
    case 6:
    case 7:
    Console.WriteLine("Weekend");
    break;
    default:
    Console.WriteLine("Incorrect input");
    break;
}
