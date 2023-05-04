/*
задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine() ?? "";
    int result = int.Parse(readInput);
    return result;
}
int number = Prompt("Введите число: ");

static int GetLength(int number)
{
    int n = 0;
    while (number > 0)
    {
        number /= 10;
        n++;
    }
    return n;
}

static bool IsPalindrome(int number)
{
    if (number >= 0 && number < 10)
        return true;
    int numberLength = GetLength(number);
    int[] digits = new int[numberLength];
    for (int j = numberLength - 1; j >= 0; j--)
    {
        digits[j] = number % 10;
        number /= 10;
    }
    for (int j = 0; j < numberLength / 2; j++)
    {
        if (digits[j] != digits[numberLength - j - 1])
            return false;
    }
    return true;



}

Console.WriteLine($"{number} -> {IsPalindrome(number)} ");