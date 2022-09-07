// Задача 69. Напишите программу, 
// которая на вход принимает два числа А и В, и
//  возводит чисто А в целую степень В с помощью рекурсии.

Console.WriteLine("Введите  число A ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите  число B ");
int b = Convert.ToInt32(Console.ReadLine());

int Degree(int num1, int num2)
{
    if(num2 == 0) return  1;
    return num1 *= Degree(num1, num2 - 1);
}
Console.Write(Degree(a, b));