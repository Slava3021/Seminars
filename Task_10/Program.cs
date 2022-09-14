
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.WriteLine("введите трехзначное  число для проверки");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 > 99 && num1 < 1000)
{
    int num2 = num1 / 10;
    num2=num2 % 10;
    Console.WriteLine($"вторая цифра числа:{num1} равна: {num2}");
}
else
{
    Console.WriteLine("Введите другое число");
}