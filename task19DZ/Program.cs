// Задача 19

// Напишите программу, которая 
// 1)принимает на вход пятизначное число 
// 2)и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write(" Введите положительное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number;
int num2 = 0;
while (num1 != 0)
{
    num2 = num2 * 10;
    num2 = num2 + num1 % 10;
    num1 = num1 / 10;
}

if ((number == num2) && (number > 999 && number < 100000) && number > 0)
{
    Console.WriteLine($"Число {number} являеться палиндромом");
}
else if (number > 0 && number < 999 || number > 99999)

{
    Console.WriteLine($"Число {number} НЕ являеться пятизначным");
}
else
{
    Console.WriteLine($"Число {number} НЕ являеться палиндромом");
}