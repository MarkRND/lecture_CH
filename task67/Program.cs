// Задача 67. 
// Напишите программу, 
// которая будет принимать на вход число 
// и возвращать сумму его цифр

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int SumDigitals(int number)
{
    int sum = number % 10;
    if (number == 0) return sum;
    return sum += SumDigitals(number / 10);
}
int result = SumDigitals(num);
Console.Write($"{num} -> {result} ");