// Напишите программу которая
// 1 на вход принимаетодно число
// 2 а на выходе показывает все целые числа в промежуток от -N до N

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int num2 = - num;
// while (num2 <= num)
// {
//     Console.Write(num2 + " ");
//     num2++;                                   // альтернативный способ , через while
// }
// Console.WriteLine();
// Console.Write("вывод чисел ");
if (num > 0)

    for (int num2 = -num; num2 <= num; num2++)
    {
    Console.Write(num2 + " ");
    }    
else
// if (num < 0)

    for (int num2 = -num; num2 >= num; num2--)
    {
        Console.Write(num2 + " ");
    }
