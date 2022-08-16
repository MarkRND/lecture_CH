// Задача 28: Напишите программу, которая
// 1)принимает на вход число N и 
// 2)выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120




Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = 1;
for (int i = 1; i <= num; i++)
{
    num1 *= i;

}
Console.WriteLine($"Произведения чисел от 1 до {num} ==> {num1}");