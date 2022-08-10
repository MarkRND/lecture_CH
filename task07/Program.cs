// Напишите программу, которая 
// 1принимает на вход трехзначное число и
// 2 на выходе показывает последнюю цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num % 10;
if (num > 0)
Console.WriteLine($"Число {num2} являеться последней цифрой {num}");
else
Console.WriteLine($"Число {num2 = -num2} являеться последней цифрой {num}");