// Задача 24: Напишите программу, которая
// 1принимает на вход число (А)
//  2и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write(" Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i <= num; i++)
// {
//     sum = sum + i;
//     // sum += i;
// }
// Console.WriteLine($"сумма чисел от 1 до {num} = {sum}" );



int SumNumbers(int number)
{
int sum = 0;
for (int i = 0; i <= num; i++)
{
    sum = sum + i;
    // sum += i;
}
    return sum;
}
int result = SumNumbers(num);
Console.WriteLine($"сумма чисел от 1 до {num} = {result}" );