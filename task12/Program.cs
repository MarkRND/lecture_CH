// Напишите програму котрая:
// 1)Будет принимать на вход 2 числа
// 2)и выводить являеться ли второе число кратное первому
// 3) если второе число не кратно первому, то выводит остаток от деления
Console.Write("Введите первое число : ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num % num1;
// Console.WriteLine(num2);
if (num % num1 == 0)
{
    Console.WriteLine($"Первое число {num} кратно второму числу {num1} ");
}
else 
{
    Console.WriteLine($"Первое число {num} не кратно второму числу {num1} остаток от деления {num2} ");
}