// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.Clear();
Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int Sum(int num)
{
    if (num < 0) num = -num;
    int i = 0;
    int res = 0;
    while (num > 0)
    {
        int num2 = num % 10;
        res = res + num2;
        num = num / 10;
        i++;
    }
    return res;
}
int result = Sum(num1);
Console.WriteLine($"Сумма цифр в числе {num1} = {result} ");
