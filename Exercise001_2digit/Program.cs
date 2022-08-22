// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);           // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);       // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

Console.WriteLine("    Задача 1");
Console.WriteLine("***********************");

int number = Prompt("Введите 3-значное число  ");
if (number/100 > -10 & number/100 <10 & number/100 != 0)
{
    if (number < 0)
    {
        Console.WriteLine($"Вторая цифра данного числа: {-number / 10 % 10}");
    }
    else Console.WriteLine($"Вторая цифра данного числа: {number / 10 % 10}");
}    
else Console.WriteLine($"{number} – не 3-значное число");
Console.WriteLine("***********************");
