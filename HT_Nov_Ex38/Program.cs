// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int size = ReadInt("Enter array length: ");
double[] numbers = new double[size];
double max = 0;
double min = 0;
double diff = 0;

FillArrayRandomNumbers(numbers);
WriteArray(numbers);

for (int i = 0; i < size; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
diff = max - min;
 }
  Console.WriteLine($"the min is {min} and max is {max}");
  Console.Write(diff);
  Console.ReadKey();


void FillArrayRandomNumbers(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        int randomNumber = new Random().Next(100, 1000);
        array[i] = Convert.ToDouble(randomNumber) / 100;
    }
}

void WriteArray(double[] array)
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
