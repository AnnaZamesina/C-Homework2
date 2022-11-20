// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84


Console.WriteLine("Введите координаты точек");
Console.Write("X1: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("X2: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int zb = Convert.ToInt32(Console.ReadLine());

double DistanceVolume(int xc, int yc, int zc, int xd, int yd, int zd)
{
    double distance = Math.Sqrt((xc - xd) * (xc - xd) + (yc - yd) * (yc - yd) + (zc - zd) * (zc - zd));

    return Math.Round(distance, 2, MidpointRounding.ToZero);
}

double result = DistanceVolume(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Расстояние между точками в 3D пространстве: {result}");