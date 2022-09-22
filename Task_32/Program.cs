Console.Clear();
int[] CreateArrayRndint(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
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
int[] arr = CreateArrayRndint(8, -99, 99);
PrintArray(arr);
Console.WriteLine();
int[] ReversArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        array[i] = -array[i];
    }
    return array;
}
int[] result=ReversArray(arr);
Console.WriteLine();
Console.Write("Результат смены знака:");
PrintArray(result);


