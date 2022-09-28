Console.Clear();
Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());
void CheckTriangle(int number1,int number2, int number3)
{
    if(number1<number2+number3&& number2<number1+number3 && number3<number1+number2) Console.WriteLine("Треугольник с данными значениями существует");
    else Console.WriteLine("Треугольник с данными значениями не существует");
    return ;
}
// if(number1<number2+number3&& number2<number1+number3 && number3<number1+number2) Console.WriteLine("Треугольник с данными значениями существует");
// else Console.WriteLine("Треугольник с данными значениями не существует");

CheckTriangle(num1,num2,num3);