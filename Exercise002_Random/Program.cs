 int MyRandom3()
{
 Random rnd = new Random(); //
int answer = rnd.Next(100,1000); // случайное число в пределах диапазона
if (rnd.Next(0, 2) == 0)         // условие, при котором будет возвращаться
{                                                    // отрицательное 3-значное число
    return -answer;                                   // возвращение отриц 3-значного числа
}
return answer;                                       //возвращение полож 3-значного числа
}

int a = 0;
while (a < 10)
{
    Console.WriteLine();
    a++;
}

string text = new String('*', 40);

Console.WriteLine("    Задача 2");
Console.WriteLine(text);
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("  Напишите программу, которая выводит \r\nслучайное трёхзначное число \r\nи удаляет вторую цифру этого числа.");
Console.ResetColor(); 

int number = MyRandom3();
Console.WriteLine($"  Случайное 3-значное число: {number}");
if (number < 0)
{
    Console.WriteLine($"  Вторая цифра в этом числе: {-number/10%10}. Удалим ее.");
}
else Console.WriteLine($"  Вторая цифра в этом числе: {number/10%10}. Удалим ее.");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Ответ: {number/100*10 + number%10}");
Console.ResetColor(); 
Console.WriteLine(text);
