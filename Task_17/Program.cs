Console.WriteLine("Введите координаты точки (Х и Y)");
Console.WriteLine("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc > 0 && yc > 0) return "Вторая четверть";
    if (xc > 0 && yc > 0) return "Третья четверть";
    if (xc > 0 && yc > 0) return "Четвертая четверть";
    return "Введены не корректные координаты";
}

string result = Quarter(x, y);
Console.WriteLine(result);