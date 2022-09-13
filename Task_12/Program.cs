Console.Clear();
Console.WriteLine("введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1>num2){
    if(num1 % num2==0){
        Console.WriteLine($"{num1} кратно {num2}");
    }
    else{
        int ostatok = num1 % num2;
        Console.WriteLine($"{num1}  не кратно {num2}, остаток от деления равен:{ostatok}");
    }
}
else{
     Console.WriteLine($"Ошибка!!!Нужно чтобы первое число было больше чем второе");
}
