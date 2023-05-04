/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/




int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine() ?? "";
    int result = int.Parse(readInput);
    return result;
}
int number = Prompt("Введите число: ");

Console.Write($"{number} -> ");
    for (int i = 1; i <= number; i++)
    {
        int cube  = i*i*i;

       Console.Write($"{cube} ");
    }
    


