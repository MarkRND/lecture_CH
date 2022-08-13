// Напишите программу, котора
// 1.выводиь случайное число из отрезка [10, 99] и
// 2. показывает наибольшую цифру

int number = new Random().Next(10, 100);  // 99+1
//Console.WriteLine($"Случайное число диапозона 10 - 99 => {number}");
int firstDigit = number / 10; // получаем первую цифру числа
int secondDigit = number % 10; // получаем вторую цифру числа

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} =>  {firstDigit}");
// else if (firstDigit == secondDigit) Console.WriteLine("Цифры равны");
// else Console.WriteLine($"Наибольшая цифра числа {number} =>  {secondDigit}");

string result = firstDigit == secondDigit ? "Цифры равны" 
: firstDigit > secondDigit 
? firstDigit.ToString() : secondDigit.ToString();  // тернарные операторы ? - тогда, : - иначе
Console.WriteLine($"Наибольшая цифра числа {number} => {result}");
