// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите натуральное число m ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число n ");
int number2 = Convert.ToInt32(Console.ReadLine());
int FunctionsAkker(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0 && m > 0)
        return FunctionsAkker(m - 1, 1);
    else
        return FunctionsAkker(m - 1, FunctionsAkker(m, n - 1));
}
int result = FunctionsAkker(number1, number2);
Console.WriteLine("Вычисления функции Аккермана");
Console.WriteLine($"m = {number1}, n = {number2} -> A(m,n) = {result}");
