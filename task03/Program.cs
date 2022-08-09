// Напишите программу, которая будет выдавать названия дня недели по заданому номеру
Console.Write("Введите число от 1-7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine($"Число {num} => Понедельник");
}
if (num == 2)
{
    Console.WriteLine($"Число {num} => Вторник");
}
if (num == 3)
{
    Console.WriteLine($"Число {num} => Среда");
}
if (num == 4)
{
    Console.WriteLine($"Число {num} => Четверг");
}
if (num == 5)
{
    Console.WriteLine($"Число {num} => Пятница");
}
if (num == 6)
{
    Console.WriteLine($"Число {num} => Суббота");
}
if (num == 7)
{
    Console.WriteLine($"Число {num} => Воскресенье");
}
if (num > 7)
{
    Console.WriteLine($"Число {num} это число выходит за диапозон от 1-7, ОШИБКА веедите правильное число");
}
if (num < 7)
{
    Console.WriteLine($"Число {num} это число выходит за диапозон от 1-7, ОШИБКА веедите правильное число");
}