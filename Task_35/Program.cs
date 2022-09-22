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
int Selection(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100) count++;
    }

    return count;
   

}
int[] arr = CreateArrayRndint(123, 0, 123);
PrintArray(arr);
int result= Selection(arr);
 Console.WriteLine($"->Количество совпадений в данном массиве = {result}");
// Console.WriteLine($"Количество совпадений в данном массиве = {result}");
