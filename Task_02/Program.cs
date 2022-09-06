// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее. Например:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Clear();
Console.Write("введите первое число число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число число:");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2){
    Console.WriteLine($"{num1} является максимальным числом");
}
else if (num1<num2){
    Console.WriteLine($"{num2} является максимальным числом");
}
else {
    Console.WriteLine($"числа {num1} и {num2} является равными");
}