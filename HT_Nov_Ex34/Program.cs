/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int size = ReadInt("Enter array length: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
WriteArray(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if ((numbers[i] % 2) == 0)
        count++;
}   
    Console.Write(count);
    Console.ReadKey();


void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        int randomNumber = new Random().Next(100, 1000);
        array[i] = Convert.ToInt32(randomNumber);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



