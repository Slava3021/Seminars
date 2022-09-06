// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
int n=1;
Console.Write("введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
int factorial;
for (int i=n;i<=num;i++) {
     if (i% 2==0) {
    Console.Write(i + ",");
}
}