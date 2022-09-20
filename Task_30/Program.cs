int[] arr = new int[8];
arr[0] = new Random().Next();
// Console.WriteLine(arr[0]);
void FillArray(int[] array)
{
    int count = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}
FillArray(arr);
PrintArray(arr);