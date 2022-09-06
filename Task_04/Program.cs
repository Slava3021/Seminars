// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Clear();
Console.Write("введите первое число число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье число число:");
int num3 = Convert.ToInt32(Console.ReadLine());
int maximum = num1;
if (maximum < num2 ) {
     maximum = num2;
}
if (maximum < num3) {
     maximum = num3;
    Console.WriteLine($"число {maximum} является максимальным");
}