Console.WriteLine("Эта программа выводит случайное число из отрезка [10, 99] и показавывает наибольшую цифру числа!");

int randomNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число 10 - 99 => {randomNum}");

//int firstDigit = randomNum / 10;
//int secondDigit = randomNum % 10;
//int maxDigit = firstDigit> secondDigit? firstDigit : secondDigit;
//if (firstDigit > secondDigit) maxDigit = firstDigit;
//else maxDigit = secondDigit;
//Console.WriteLine($"Наибольшая цифра числа {randomNum} => {maxDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return 0;
    return firstDigit> secondDigit? firstDigit : secondDigit;
}

int maxDigit = MaxDigit(randomNum);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры одинаковые";
Console.WriteLine($"Найбольшая цифра числа {randomNum} => {result}");