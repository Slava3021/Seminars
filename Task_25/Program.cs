// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int Exponenta(int a1, int b1)
{
    int res = a1;
    for (int i = 1; i < b1; i++)
    {
        res *= a1;
    }
    return res;
}
int result = Exponenta(num1, num2);
Console.WriteLine($"Результат возведения числа{num1} в степень {num2} = {result} ");
