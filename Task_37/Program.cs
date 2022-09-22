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
int[] Multiplication(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size += 1;
    int[] arraymult = new int[size];
    int i = 0;
    while (i < size)
    {
        arraymult[i] = (array[i]) * (array[array.Length - i - 1]);
        i++;
        // Console.Write($": {arraymult[i]}");
    }
    if (arraymult.Length % 2 != 0) arraymult[arraymult.Length - 1] = array[array.Length / 2];
    return arraymult;
}
int[] arr = CreateArrayRndint(5, 0, 9);
PrintArray(arr);
int[] result = Multiplication(arr);
Console.WriteLine($"{result}");
PrintArray(result);

// double[] CreateArrayRndintDouble(int size, int min, int max)
// {
//     double[] array = new double[size];
//     Random rnd = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = rnd.NextDouble()*100;
//     }
//     return array;
// }




