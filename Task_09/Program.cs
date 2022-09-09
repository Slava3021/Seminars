int number = new Random().Next(10,100);
// int firstDigit = number/10;
// int secondDigit = number % 10;
// // if (firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа {number} ->{firstDigit}");
// // else Console.WriteLine($"наибольшая цифра числа {number} ->{secondDigit}");
// if(firstDigit==secondDigit) Console.WriteLine($"цифры равны");
// else{
// int max = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"наибольшая цифра числа {number} ->{max}");
// }

int MaxDigit(int num)
{
int firstDigit = num/10;
int secondDigit = num % 10; 
if (firstDigit==secondDigit) return 0;
return firstDigit > secondDigit ? firstDigit : secondDigit;
}
int maxDigit =MaxDigit(number);
string result = maxDigit >0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine($"наибольшая цифра числа {number} -> {result}");

