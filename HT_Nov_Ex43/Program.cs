/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/

Console.WriteLine("Pls enter point b1: ");
int pointb1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Pls enter point k1: ");
int pointk1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Pls enter point b2: ");
int pointb2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Pls enter point k2: ");
int pointk2 = Convert.ToInt32(Console.ReadLine());

int x = -(pointb1 - pointb2) / (pointk1 - pointk2);
int y = pointk1 * x + pointb1;

Console.WriteLine($"lines will be crossed in point: {x} ; {y})");
