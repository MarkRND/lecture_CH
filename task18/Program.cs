// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).




Console.Write(" Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());


string GetRange(int q)

{
    if (q == 1) return " X > 0 и Y > 0";
    if (q == 2) return " X < 0 и Y > 0";
    if (q == 3) return " X < 0 и Y < 0";
    if (q == 4) return " X > 0 и Y < 0";
    return "Введено некоректное значение";
}

string result = GetRange(quarter);

Console.WriteLine(result);