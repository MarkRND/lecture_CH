// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
    Console.WriteLine($"Число {num2} меньше числа {num1}");
}
else if (num2 > num1)
{
    Console.WriteLine($"Число {num2} больше числа {num1}");
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}
else
{
    Console.WriteLine($"Число {num2} равно {num1} <ОШИБКА введите разные числа>");
}