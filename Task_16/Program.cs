Console.Clear();
Console.WriteLine("введите введите первое число для проверки");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число для проверки");
int num2 = Convert.ToInt32(Console.ReadLine());

//  if (num2 == num1 * num1)
// {
//     Console.WriteLine($"число {num2} является квдратом числа {num1}");
// }
// else if (num1 == num2 * num2)
// {
//     Console.WriteLine($"число {num1} является квдратом числа {num2}");
// }
// else
// {
//     Console.WriteLine($"число {num1} не является квдратом числа {num2}");
//     Console.WriteLine($"число {num2} не является квдратом числа {num1}");
// }
bool Square(int num1, int num2){
    return ( num1*num1==num2 || num2*num2==num1);
}
bool result = Square(num1,num2);
if (result) Console.WriteLine($"Правда");
else Console.WriteLine($"ЛОЖЬ");