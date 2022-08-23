// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Write($"Введите количество чисел : ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 0)
{
    int[] numbers = CreatIntNumbers(size);

    Console.WriteLine($"Чисел больше 0 -> {Comparison(numbers)}");
}
else
{
    Console.Write($"ОШИБКА, веденое число {size} отрицательное: ");
}
int[] CreatIntNumbers(int m)
{
    int[] numbers = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbers;
}
int Comparison(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0)
            count += 1;
    }
    return count;
}






// int[] numbers = new int[m];
// void IntNumbers(int m)
// {

//     for (int i = 0; i < m; i++)
//     {
//         Console.Write($"Введите {i + 1} число: ");
//         numbers[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }
// int Comparison(int[] num)
// {
//     int count = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] > 0)
//             count += 1;
//     }
//     return count;
// }


