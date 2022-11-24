// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. Вывод сделать отдельным методом.

Console.WriteLine("Please enter arrey length: "); 
string input = Console.ReadLine();
int arrey = Convert.ToInt32(input);

int [] number = new int [arrey];

for (int i = 0; i < number.Length; i++)
{
    number[i] = new Random().Next(0,100);
    Console.Write(number[i] + " ");
}

