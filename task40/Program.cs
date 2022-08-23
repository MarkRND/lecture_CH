// Задача 40: Напишите программу, 
// 1)которая принимает на вход три числа и 
// 2)проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

Console.Write(" Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());


    if( num1 < num2 + num3 && num2 < num1 + num3 && num3 < num2 + num1)
{
Console.WriteLine("Триугольник существует ");
}
else
{
Console.WriteLine("Триугольник не может существует ");
}

// Console.Write("Введите сторону A: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите сторону B: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите сторону C: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// bool Triangle(int a, int b, int c)
// {
//     return a < b + c && b < a + c && c < b + a;
// }
// bool result = Triangle(num1, num2, num3);
// Console.WriteLine(result?"Является треугольником":"Не является треугольником");
