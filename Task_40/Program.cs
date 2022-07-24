//Задача 40: Напишите программу, которая принимает на вход три
//числа и проверяет, может ли существовать треугольник с сторонами
//такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника
//меньше суммы двух других сторон.

bool YesOrNoTrial(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        return true;
    }
    else
    {
        return false;
    }
}

string ShowAnswer(bool a)
{
    if (a)
    {
        return"Треугольник возможен";
    }
    else
    {
        return"Треугольник не возможен";
    }
}
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

bool able = YesOrNoTrial(a, b, c);
string ansver = ShowAnswer(able);
Console.WriteLine(ansver);