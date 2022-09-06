// напишите программу, котороя на вход 
// принимает число и выдает его квадрат (число 
// умножается само на себя)
Console.Clear();
Console.Write("введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.WriteLine($"Квадрат числа {num} = {square}");
