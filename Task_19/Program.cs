// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное  число:");
Console.Write("N: ");
int num = Convert.ToInt32(Console.ReadLine());
// if (num < 10000 || num> 99999) Console.WriteLine("Введите пятизначное число");
void Polindrom(int number)
{
    if (num < 10000 || num> 99999) Console.WriteLine("Введите пятизначное число");
    else
    {
    int num1 = number % 10;
    int num2 = number / 10 % 10;
    int num3 = number / 1000 % 10;
    int num4 = number / 10000 % 10;
    if (num1 == num4 && num2 == num3) Console.WriteLine("число является палиндромом");
    else Console.Write("число не является палиндромом");
    }
}
Polindrom(num);



