// Задача 25: Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prompt(string message)
{
    Console.WriteLine(message);
    string readImput = Console.ReadLine();
    int result = int.Parse(readImput);
    return result;
}

int GetStep(int numA, int numB)
{
    int number =1;
    for (int i = 0; i < numB; i++)
    {
        number *= numA;
    }
    return number;
}

bool ValidateNum(int numB)
{
    if ( numB < 0)
    {
        Console.WriteLine("Вы ввели число 0 либо меньше");
        return false;
    }
    return true;
}

int numA = Prompt("Введите число: ");
int numB = Prompt("Введите степень в которую хотите возвести число: ");
if (ValidateNum(numB))
{
    Console.WriteLine($"Число {numA} в степени {numB} равно {GetStep( numA, numB)}");
}


