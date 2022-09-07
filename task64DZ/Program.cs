// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число N ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = 1;
void PrintNaturalNumber(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"число {num1} не натуральное ");
    }
    if (num1 > num2)
    {
        Console.Write($"{num1}, ");
        PrintNaturalNumber(num1 - 1, num2);
    }
    if (num1 == num2)
    { Console.Write($"{num1} "); }
}
Console.WriteLine($"Все натуральные числа в промежутке от N = {number} до 1.");
PrintNaturalNumber(number, number2);
