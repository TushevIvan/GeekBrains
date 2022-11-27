// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число 1");
string NumberStr1 = Console.ReadLine();
Console.WriteLine("Введите число 2");
string NumberStr2 = Console.ReadLine();
int NumberInt1 = int.Parse(NumberStr1);
int NumberInt2 = int.Parse(NumberStr2);
if (NumberInt1 > NumberInt2)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Второе число больше первого");
}