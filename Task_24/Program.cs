Console.Clear();
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        // sum=sum+i;
        sum+=i;
    }
    return sum;
}
int result= SumNumbers(number);
Console.WriteLine($"сумма чисел от 1 до{number} = {result}");
