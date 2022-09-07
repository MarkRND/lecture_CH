// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N ");
int number2 = Convert.ToInt32(Console.ReadLine());

int AmountNumber(int num1, int num2)
{
    int sum = 0;
    if (num1 == num2)
    return num1;
    if (num1 < num2)
        sum = num1 + num2 + AmountNumber(num1 + 1, num2 - 1);
    return sum;
}
int result = AmountNumber(number1, number2);
Console.WriteLine($"Cумма натуральных элементов в промежутке от M = {number1} до N = {number2} -> {result}.");