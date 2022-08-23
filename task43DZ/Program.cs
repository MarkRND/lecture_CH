// Задача 43: Напишите программу, 

// 1которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double Input(string name)
{
    Console.Write("Введите значение " + name + " :");
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double b1 = Input("b1");
double k1 = Input("k1");
double b2 = Input("b2");
double k2 = Input("k2");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
if (k1 != k2)
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> точка пересечения прямых линий ({x}; {y})");

else if (b1 == b2)
{
    Console.WriteLine("Прямые линии совпадают");
}
else
    Console.WriteLine("Прямые линии параллельны");


// / Console.Write($"Введите значение b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите значение k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите значение b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите значение k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());

