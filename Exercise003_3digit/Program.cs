int Prompt(string message)
{
    System.Console.Write(message);     // Вывести сообщение
    string readValue = Console.ReadLine();   // Считывает с консоли строку
    int result = int.Parse(readValue);    // Преобразует строку в целое число
    return result;                           // Возвращает результат функции
}

int Digits(int number)                       // Определяет кол-во знаков числа
{
    int howmanyDigits = 1;
    while (number < -9 ^ number > 9)
    {
     number = number / 10;
     howmanyDigits++;
    }
    return howmanyDigits;
}

static void emptyString(int howmanyString)        // Выводит нужное кол-во пустых строк
{
    int a = 0;
    while (a < howmanyString)
    {
     Console.WriteLine();
     a++;
    }
}

string text = new String('*', 40); // Выводит заданное количество символов,
                                             //  в данном случае 40

emptyString(6);
Console.WriteLine("    Задача 3");
Console.WriteLine(text);
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("  Напишите программу, которая выводит \r\nтретью цифру заданного числа \r\nили сообщает, что третьей цифры нет.");
Console.ResetColor(); 

int number = Prompt("Введите число  ");
int count = Digits(number);
Console.WriteLine($"Данное число {count}х-значное");
if (count < 3) Console.WriteLine("Ответ: третей цифры у данного числа нет");
else
{
   int m = Convert.ToInt32(Math.Pow(10, count-3));
   if (number < 0)
   {
       Console.WriteLine($"Ответ: третья цифра данного числа {-number/m%10}");
   }
   else Console.WriteLine($"Ответ: третья цифра данного числа {number/m%10}");
}   
Console.WriteLine(text);

emptyString(6);
