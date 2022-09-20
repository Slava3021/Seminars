Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int Factorial(int num)
{
    if (num < 0) Console.WriteLine("Введите целое положительное число");
    // int fact = 1;
    int j = 1;
    for (int i = 1; i <= num; i++)
    {
        j= j*i;
    }
    return j;
    // Console.WriteLine($"Количество цифр числа {number} = {i} ");
}
int result = Factorial(number);
Console.WriteLine($"Факториал числа {number} = {result} ");
