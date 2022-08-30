static void emptyString(int howmanyString)        // Выводит нужное кол-во пустых строк
{
    int a = 0;
    while (a < howmanyString)
    {
     Console.WriteLine();
     a++;
    }
}
emptyString(6);
string text = new String('*', 40);                        // Выводит заданное количество символов,
                                                          //  в данном случае 40
Console.WriteLine("    Задача 4");
Console.WriteLine(text);
emptyString(1);
Console.ForegroundColor = ConsoleColor.Green;                                                     
Console.WriteLine("  Напишите программу, которая принимает на вход \r\nцифру, обозначающую день недели, и\r\nпроверяет, является ли этот день выходным.");
emptyString(1);
Console.ResetColor(); 

static void weekofMari()
    {
        try
        {
        string[] dayWeek = new string[] { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "Воскресенье"};
        Console.Write("  Введите число, которое соответствует одному из семи дней недели: ");
        int numberofDay = int.Parse(Console.ReadLine());
            if (numberofDay < 8 & numberofDay > 5)
            {
             Console.WriteLine($"Это {dayWeek[numberofDay-1]}. Сегодня выходной! Можно отдохнуть.");
            }       
             else Console.WriteLine($"Это {dayWeek[numberofDay-1]}. До выходных осталось {5-(numberofDay -1)} дней.");
        }

        catch (IndexOutOfRangeException)
        {
        Console.WriteLine("Вы ввели число, которое не соответствует дню недели");
        weekofMari();    
        }

        catch (FormatException)
        {
        Console.WriteLine("Это НЕ число!!!\n");
        weekofMari();
        }

        Console.ReadLine();
    }
    weekofMari();
emptyString(1);    
Console.WriteLine(text);
emptyString(6);