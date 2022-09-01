//Задача 43: Напишите программу,
//которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0,5; -0,5)

Console.WriteLine("Введите координаты точки (B1, K1, B2, K2)");
Console.WriteLine("K1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("B1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("K2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("B2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 0;
if (k1 != k2)
{
    
    x = (b2 - b1) / (k1 - k2);
    y = k2 * x + b2;

    Console.WriteLine($"Точка пресечения {x} -> X и {y} -> Y ");
}
else if (b1 != b2) Console.WriteLine("Прямые параллельны");
else Console.WriteLine("Прямые совпадают");
