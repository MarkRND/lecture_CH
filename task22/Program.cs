// Задача 22: Напишите программу, которая
// 1)принимает на вход число (N) и
// 2 выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.Write(" Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"квадраты числа от 1 до {i} {i * i} ");
}

// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());

// if (n > 0)
// {
//     for (int i = 1; i <= n; i++)                                альтернатива
//     {
//         Console.WriteLine($"{i}\t{i * i}");
//     }
// }
// else Console.WriteLine("Введено некорректное значение");


// Console.WriteLine("Введите значение: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int i = 1;
// if (num > 0)
// {
//    while (i <= num)
//    {                                                                 альтернатива
//        int q = i * i;
//        Console.WriteLine($"{i}   {q}");
//        i++;
//    }
// }
// else 
// {
//     Console.WriteLine("Введите значение больше 0!");
// }
