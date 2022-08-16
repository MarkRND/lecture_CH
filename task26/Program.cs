// Задача 26: Напишите программу, 
// 1)которая принимает на вход число 
// 2)и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5






Console.Write(" Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int x = num;
int count = 0;
// if (x == 0)
//     {
//         count = 1;
//     }
// else
// {
// while (x != 0)
//     {
//         x = x / 10;
//         count++;
//     }
// }

int Numbers(int number)
{
int x = number;
 if (x == 0)
    {
        count = 1;
    }
else
{
while (x != 0)
    {
        x = x / 10;
        count++;
    }
}  
return count;
}

Console.WriteLine(Numbers(num));