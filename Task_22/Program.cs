Console.Clear();
Console.WriteLine("Введите положительное число:");
Console.Write("N: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1) Console.Write("Введите положительно число");
int n = 1;
for (int i = n; i <= num; i++)
{
    int a = i * i;
    Console.Write($"{a},");
}


