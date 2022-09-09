int number = new Random().Next(10,100);
int firstDigit = number/10;
int secondDigit = number % 10;
// if (firstDigit > secondDigit) Console.WriteLine($"наибольшая цифра числа {number} ->{firstDigit}");
// else Console.WriteLine($"наибольшая цифра числа {number} ->{secondDigit}");

int max = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine($"наибольшая цифра числа {number} ->{max}");
