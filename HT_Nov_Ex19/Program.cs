//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Pls enter your five-digit number: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

string value = number.ToString();
string result = "";
 for (int i = 0, j = value.Length - 1; (value.Length / 2 == 0 ? i < value.Length / 2 : i <= value.Length / 2); i++, j--)
 {
    if (value[i] == value[j])
    {
        result = "true"; Console.Write(number + " is palindrom");
        continue;
    }
    result = "false"; Console.Write(number + " is not a palindron");
    break;
 }  
 


