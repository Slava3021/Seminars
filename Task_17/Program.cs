Console.WriteLine("Введите координаты точки");
Console.Write("X:  ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y:  ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarte(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая  четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "введены некоректные координаты";
}
string result = Quarte(x,y);
Console.WriteLine(result);
