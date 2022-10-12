Console.Clear();
string[] CreateArrayString(int size)
{
    string[] stringArray = new string[size ];
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine("Ввудите несколько символов");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}


void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}







string[] arr = CreateArrayString(5);

PrintArray(arr);
Console.WriteLine();
string[] LesseQuallyThree(string[] array)
{
    int count = 0;
    int n = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
            
        }
    }
      string[] stringArray = new string[count];
    for (int i = 0; i < arr.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            stringArray[n] = array[i];
            n++;
        }
    }

    return stringArray;
}




string[] result = LesseQuallyThree(arr);
PrintArray(result);



