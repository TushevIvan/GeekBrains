// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

foreach (int i in Enumerable.Range(1, int.Parse(Console.ReadLine()) >> 1))
Console.WriteLine(i << 1);
