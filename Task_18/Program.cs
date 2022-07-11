/* Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y). */

Console.WriteLine("Программа запршивает номер координатной четверти и выводит диапазон возможных координат");
Console.WriteLine("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());


string Coord(int q)
{
    switch (q)
    {
        case 1:
            return "Диапазон возможных координат Х > Y и X > Y";
        case 2:
            return "Диапазон возможных координат Х < Y и X > Y";
        case 3:
            return "Диапазон возможных координат Х < Y и X < Y";
        case 4:
            return "Диапазон возможных координат Х > Y и X < Y";
        default:
            return "Введена не коррктная четверть";
    }
}


string result = Coord(quarter);
Console.WriteLine(result);
