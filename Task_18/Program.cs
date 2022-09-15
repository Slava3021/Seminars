Console.WriteLine("Введите номер четверти");
// Console.Write("X:  ");
int x = Convert.ToInt32(Console.ReadLine());

string Quarte(int xc)
{
    if (xc == 1) return "x>0, y>0";
    if (xc == 2) return "x<0, y>0";
    if (xc == 3) return "x<0, y<0";
    if (xc == 4) return "x>0, y<0";
    return "Введите число от 1 до 4";
}
string result=Quarte(x);
Console.WriteLine(result);
