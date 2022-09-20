Console.Clear();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int Count(int num)
{
    if(num<0) num=-num;
    int i = 0;
    while (num > 0)
    {
        num = num / 10 ;
        i++;
    }
    return i;
    // Console.WriteLine($"Количество цифр числа {number} = {i} ");
}
int result = Count(number);
Console.WriteLine($"Количество цифр числа {number} = {result} ");