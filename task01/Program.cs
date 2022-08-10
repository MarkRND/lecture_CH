// напишите программу, которая на вход 
// 1принимает два числа
// 2и проверяет, являеться ли первое число квадратом второго

// if (num == 7 && num == 5)  "если  num равен 7 и num равен 5"
// {

// }
// esle if (num == 6 || num != 3) "или если num равен 6 и не равен 3"
// {

// }
// esle 
// {

// }
Console.Write("Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
// int lul = num2 * num2;
if (num1 == num2 * num2)
{
Console.WriteLine($"Число {num1} являеться квадратом числа {num2}");
}
if (num1 != num2 * num2)
{
Console.Write($"Число {num1} не являеться квадратом числа {num2}");
}
