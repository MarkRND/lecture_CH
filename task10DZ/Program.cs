﻿// Задача 10: Напишите программу, которая
// 1 принимает на вход трёхзначное число 
// 2 и на выходе показывает вторую цифру этого числа. Решить без использования строк.

// 456 -> 5
// 782 -> 8
// 918 -> 1 

Console.Write("Введите трехзначное число : ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = (num / 10) % 10;
// int num2 = num12 % 10;
// Console.WriteLine($"вторая цифра {num2}  числа {num} ");
if (num >= 100 && num < 1000)
{
    Console.WriteLine($"вторая цифра {num2}  числа {num} ");
}
else if (num > -999 && num < -100)
{
    Console.WriteLine($"вторая цифра {-num2}  числа {num} ");
}
else
{
    Console.WriteLine($" Ошибка, число  {num} не трехзначное ");
}
