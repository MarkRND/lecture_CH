// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write(" Введите координаты первой точки x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите координаты второй точки y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите координаты второй точки z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите координаты первой точки x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите координаты второй точки y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите координаты второй точки z1: ");
double  z1 = Convert.ToInt32(Console.ReadLine());
double  asq = Math.Pow((x1 - x),2);
double  bsq = Math.Pow((y1 - y),2);
double  csq = Math.Pow((z1 - z),2);
double res = Math.Sqrt(asq + bsq + csq);
double result = Math.Round(res,2);
// Math.Round(result,2)
Console.WriteLine($"Расстояние между точками равно {result}");
// Console.WriteLine(Math.Round(res,2));