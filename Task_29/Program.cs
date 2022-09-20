// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[] arr = new int[8];
arr[0] = new Random().Next();
void FillArray(int[] array)
{
    int count = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
}
void PrintArray(int[] array)
{
    Console.Write("[");
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (i==7) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
    // Console.Write("]");
}
FillArray(arr);
PrintArray(arr);