// Console.Clear();
// Console.WriteLine("введите  число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 % 7 == 0 && num1 % 23 == 0)
// {
//     Console.WriteLine($"число {num1} кратно 7 и 23 одновременно");
// }
// else
// {
//     Console.WriteLine($"число {num1} не кратно 7и 23 одновременно");
// }
Console.Clear();
Console.WriteLine("введите число для проверки");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите введите первое число для кратности");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число для кратности");
int num2 = Convert.ToInt32(Console.ReadLine());

bool IsCratno(int num1, int num2, int number)
{
    return number % num1 == 0 && number % num2 == 0;
}
bool result = IsCratno(num1, num2, number);

if (result)
{
    Console.WriteLine($"число {number} кратно и {num1} и {num2} одновременно");
}
else
{
    Console.WriteLine($"число {number} не кратно и {num1} и {num2} одновременно");
}
