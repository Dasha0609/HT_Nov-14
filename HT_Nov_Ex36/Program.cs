// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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
        int randomNumber = new Random().Next(1, 10);
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
