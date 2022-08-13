// // Напишите программу, 
// 1) которая принимает на вход число 
// 2)и проверяет кратноли оно одновременно 7 и 23

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
;
if (number / 7 == 0 & number / 23 == 0)
{
    Console.WriteLine($"Число {number} кратно  числам 7 и 23 ");
}
else
{
    Console.WriteLine($"Число {number} не кратно  числам 7 и 23 ");
}