/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */


Console.WriteLine("Программа запрашивает координаты двух точек и выводит 3D расстояние между ними");
Console.WriteLine("Введите координаты точки А ");
Console.WriteLine("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B ");
Console.WriteLine("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Z: ");
int zb = Convert.ToInt32(Console.ReadLine());
double Distance(int xta, int yta, int zta, int xtb, int ytb, int ztb)
{
    int cat1 = 0;
    int cat2 = 0;
    int cat3 = 0;
    double result = 0.0;

    cat1 = xta - xtb;
    cat2 = yta - ytb;
    cat3 = zta - ztb;
    result = Math.Sqrt(cat1 * cat1 + cat2 * cat2 + cat3 * cat3);
    return Math.Round(result, 2);
}

double result = Distance(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Расстояние между точками А и В: {result}");