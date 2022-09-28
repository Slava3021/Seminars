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
int[] CoppyArray(int[] array)
{
    int[] arr2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr2[i] = array[i];
    }
    return arr2;
}
int[] arr = CreateArrayRndint(5, 1, 9);
PrintArray(arr);
Console.WriteLine();
int[]arrCoppy=CoppyArray(arr);
arrCoppy[0]=50;
PrintArray(arrCoppy);
