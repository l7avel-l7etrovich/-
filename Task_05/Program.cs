Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int negnum;
if (num > 0) {
negnum = num * -1;
}
else {
negnum = num;
num = negnum * -1;
}
while (negnum <= num) {
Console.Write($" {negnum} ");
negnum ++;
}