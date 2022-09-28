Console.Clear();
int num = default;
Console.Write("Введите целое число:");
while(!int.TryParse(Console.ReadLine(),out num))
{
    Console.Write("Ошибка!\nВведите целое число:");
}

int ConvertTobinary(int num1)
{
    int count = 1;
    int ost = 0;
    while (num1 !=0)
    {
        ost += (num1 % 2) * count ;
        num1 /= 2;
        count *= 10;
    }
    return ost;
}

Console.Write(ConvertTobinary(num));


