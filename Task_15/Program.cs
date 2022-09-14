// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите номер от 1 до 7:");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6) Console.Write("Сегодня выходной!");
if (day == 7) Console.Write("Сегодня выходной");
if (day<6) Console.WriteLine("Сегодня будний день(");
if (day>7) Console.WriteLine("Такого дня не существует");
