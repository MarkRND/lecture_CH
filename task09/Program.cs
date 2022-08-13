// Напишите программу, котора
// 1.выводиь случайное число из отрезка [10, 99] и
// 2. показывает наибольшую цифру

int number = new Random().Next(10, 100);  // 99+1
//Console.WriteLine($"Случайное число диапозона 10 - 99 => {number}");
// int firstDigit = number / 10; // получаем первую цифру числа
// int secondDigit = number % 10; // получаем вторую цифру числа

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} =>  {firstDigit}");
// else if (firstDigit == secondDigit) Console.WriteLine("Цифры равны");
// else Console.WriteLine($"Наибольшая цифра числа {number} =>  {secondDigit}");              1) метода решения



// string result = firstDigit == secondDigit ? "Цифры равны" 
// : firstDigit > secondDigit 
// ? firstDigit.ToString() : secondDigit.ToString();  // тернарные операторы ? - тогда, : - иначе
// Console.WriteLine($"Наибольшая цифра числа {number} => {result}");                            // 2) метод решения

int MaxDigit(int num)
{
    int firstDigit = num / 10; // получаем первую цифру числа
    int secondDigit = num % 10; // получаем вторую цифру числа
    if (firstDigit == secondDigit) return 0;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}

int result = MaxDigit(number);
string res = result == 0 ? " цифры равны" : result.ToString();
// int result2 = MaxDigit(56);
Console.WriteLine($"Наибольшая цифра числа {number} => {res}");
// Console.WriteLine($"Наибольшая цифра числа {56} => {result2}");
