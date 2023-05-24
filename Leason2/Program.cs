// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Prompt(string message)
{
    Console.WriteLine(message);
    string readImput = Console.ReadLine();
    int result = int.Parse(readImput);
    return result;
}

int GetSum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int num = Prompt("Введите число:");
Console.WriteLine($"Сумма всех чисел в цифре {num} = {GetSum(num)}");

