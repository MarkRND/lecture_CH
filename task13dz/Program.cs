﻿// Задача 13: Напишите программу, которая 
// 1)выводит третью цифру заданного числа или
// 2) сообщает, что третьей цифры нет. Решить без использования строк.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num;
if (num2 < 0)
{
    num2 = -num2;
}
while (num2 > 999)
{
    num2 = num2 / 10;
}
if (num2 > 99)
    Console.WriteLine($"Число {num2 = num2 % 10} являеться тетьей цифрой в числе {num}");
else
    Console.WriteLine($"У числа {num} , нет третьей цифры");