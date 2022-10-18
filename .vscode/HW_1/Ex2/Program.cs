// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1");
string NumberStr1 = Console.ReadLine();
Console.WriteLine("Введите число 2");
string NumberStr2 = Console.ReadLine();
Console.WriteLine("Введите число 3");
string NumberStr3 = Console.ReadLine();
int NumberInt1 = int.Parse(NumberStr1);
int NumberInt2 = int.Parse(NumberStr2);
int NumberInt3 = int.Parse(NumberStr3);
if (NumberInt1 > NumberInt2 && NumberInt1 > NumberInt3)
{
    Console.WriteLine("Большее число: " + NumberInt1);
}
if (NumberInt2 > NumberInt1 && NumberInt2 > NumberInt3)
{
    Console.WriteLine("Большее число: " + NumberInt2);
}
if (NumberInt3 > NumberInt2 && NumberInt3 > NumberInt1)
{
    Console.WriteLine("Большее число: " + NumberInt3);
}