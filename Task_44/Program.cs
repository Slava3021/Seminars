Console.Clear();
int num = default;
Console.Write("Введите целое число:");
while (!int.TryParse(Console.ReadLine(), out num))
{
    Console.Write("Ошибка!\nВведите целое число:");
}
int[] Fibonacci(int number)
{
    int[] array = new int[number];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < number; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}


int[] arr = Fibonacci(num);
PrintArray(arr);
