Console.Clear();
Console.Write("введите первое число число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второечисло число:");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2* num2;
if(square==num1) {
    Console.Write($"Число {num1} является квадратом {num2}");   
}
else {
    Console.Write($"Число {num1} не является квадратом {num2}");
}






