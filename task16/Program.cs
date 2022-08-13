// Напишите программу, которая
// 1 принимает на вход 2 числа
// 2 и проверяет, являеться ли одно число квадратом другого

Console.Write("Введите первое число : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num % num1 == 0 || num1 % num == 0)
{
    Console.WriteLine($"Числа {num} {num1} => ДА");
}
else
{
    Console.WriteLine($"Числа {num} {num1} => НЕТ ");
}