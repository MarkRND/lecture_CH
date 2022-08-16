// Задача 25: Напишите цикл, который
// 1) принимает на вход два числа (A и B) и 
// 2)возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write(" Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int Degree = a;
int numD = b;
if (b > 0)
{
    for (int i = 1; i < numD; i++)
    {
        Degree *= a;

    }
    Console.WriteLine($"Число {a} возведеное в натуральную степень {b} равно {Degree}");
}

else if (b == 0)
{
    Console.WriteLine($"Число {a} возведеное в натуральную степень {b} равно 1");
}

else
{
    Console.WriteLine($"ОШИБКА число {b} не являеться натуральным числом");
}

