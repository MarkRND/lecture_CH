// Задача 25: Напишите цикл, который
// 1) принимает на вход два числа (A и B) и 
// 2)возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write(" Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
// int result = a;
// for (int i = 1; i < b; i++)
// {
//     result *= a;
// }
// Console.WriteLine($"Число {a} возведеное в натуральную степень {b} равно {result}");
int DegreeNumbers(int number)
{  
int Degree = a;
int numDegree = b;
for (int i = 1; i < numDegree; i++)
     {
    Degree *= a;
     }
    return Degree;
}
int result = DegreeNumbers(a);
Console.WriteLine($"Число {a} возведеное в натуральную степень {b} равно {result}");