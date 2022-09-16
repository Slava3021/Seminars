
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Введите положительное число:");
Console.Write("N: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1) Console.Write("Введите положительно число");Console.Clear();
int n = 1;
for (int i = n; i <= num; i++)
{
    int a = i * i * i;
    Console.WriteLine($"{i} -> {a}");
}
