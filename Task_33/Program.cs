Console.Clear();
Console.WriteLine("Введите число для сравнения с массивом чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
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
int[] arr = CreateArrayRndint(8, 0, 9);
PrintArray(arr);
// Console.WriteLine();
bool ComparingNumbers(int[] array)
{
    bool exist = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (num == array[i])
        {
            exist = true;
            break;
        }
    }
    return exist;


}
Console.WriteLine();
bool result = ComparingNumbers(arr);
Console.WriteLine($"{result}");