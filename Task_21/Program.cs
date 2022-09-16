// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7) -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Введите координаты первой точки:");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double Distance(int xc1,int yc1,int xc2,int yc2,int zc1, int zc2)
{
    int xc3 = xc1- xc2;
    int yc3 = yc1 - yc2;
    int zc3 = zc1-zc2;
    double res = Math.Round(Math.Sqrt(xc3*xc3+yc3*yc3+zc3*zc3),2, MidpointRounding.ToZero);
    return res;
}
double result= Distance(x1,y1,x2,y2,z1,z2);
Console.Write(result);
