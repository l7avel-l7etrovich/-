

Console.WriteLine("Эта программа проверяет, является ли первое число квадратом второго, Введите первое число и нажмите Enter"); 
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число и нажмите Enter");
int second = Convert.ToInt32(Console.ReadLine());

if (second * second == first)
{
    Console.WriteLine($"Да, первое число это квадрат второго: {second} * {second} = {first}");
}
else
{
    Console.WriteLine($"Нет, первое число не является квадратом второго: {second} * {second} != {first}");
}