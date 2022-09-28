// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите количество чисел которое хотите ввести :");
int m = Convert.ToInt32(Console.ReadLine());
int[] CreateArray(int sizeArray)
{
    int[] array = new int[sizeArray];
    int i = 0;
    while (i < sizeArray)
    {
        Console.WriteLine($"Введите число №{i + 1} :");
        int n = Convert.ToInt32(Console.ReadLine());
        array[i] = n;
        i++;
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

int CreaterThanZero(int[] array)
{
    int j=0;
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i]>0) j++; 
    }
    // Console.WriteLine($"Число введеных чисел больше нуля ={j}");
    return j;
}
int[]arr=CreateArray(m);
PrintArray(arr);
Console.WriteLine();
int res=CreaterThanZero(arr);
Console.WriteLine($"Число введеных чисел больше нуля = {res}");


