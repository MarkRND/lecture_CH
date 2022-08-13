// Напишите программу,
// 1 которая выводит случайное трехзначное число
// 2 и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);
// int sec23 = number % 100; // находим  вторую и  третью
// int sec2 = sec23 / 10; // находим вторую цифру
// int sec3 = sec23 % 10; // находим третью
// int sec1 = number / 100;// находим первую цифру
// Console.WriteLine($"Первая и третья цифра {sec1}{sec3}  числа {number} ");

// int sec23 = number % 100; // находим  вторую и  третью
int sec3 = number % 10; // находим третью
int sec1 = number / 100;// находим первую цифру
int result = sec1 * 10 + sec3;
Console.WriteLine($"Первая и третья цифра {result}  числа {number} ");