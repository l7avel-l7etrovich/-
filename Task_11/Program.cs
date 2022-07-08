int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int result= ((num / 100) * 10) + (num % 10);
Console.WriteLine(result);