// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Clear();
Console.WriteLine("введите  число больше 99 ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num = num1;
if (num1 > 99)
{
    while (num > 1000)
    {
         num = num / 10;
        if (num < 1000)
        {
            int num2 = num % 10;
            Console.WriteLine($"Третья цифра числа:{num1} является:{num2}");
        }
    }
}

else
{
    Console.WriteLine("третьей цифры нет");
}
