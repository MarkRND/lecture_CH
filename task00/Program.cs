// Напишите программу, которая
// 1 на вход принимает число
// 2 выводит его Квадрат



Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;
Console.Write($"Квадрат числа {num} = {square}");