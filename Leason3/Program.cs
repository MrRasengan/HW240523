// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
//и выводит их на экран.
//1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]
//6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]

int Prompt(string message)
{
    Console.WriteLine(message);
    string readImput = Console.ReadLine();
    int result = int.Parse(readImput);
    return result;
}

int[] GenerateArray9int (int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length -1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}
int Length = Prompt("Длинна массива: ");
int min = Prompt("Начало массива: ");
int max = Prompt("Конец: ");
int[] array = GenerateArray9int (Length, min, max);
PrintArray(array);
