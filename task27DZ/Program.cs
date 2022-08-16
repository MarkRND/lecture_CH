// Задача 27: Напишите программу, которая
// 1) принимает на вход число 
// 2)и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// Console.Write(" Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int number = num;
// int result = 0;
// int inter = 0;
// int length = 0;
// int number = num;
// while (number > 0 || number < 0 ) 
// {
//    number = number / 10;                                        альтернатива
//    length++;
// }
// for (int i = 0; i < length; i++)
//     {
//       inter = num - num % 10;
//       result = result + (num - inter);
//       num = num / 10;
//     } 
// Console.WriteLine($"Cумма цифр в числе {numbers} равно {result}"); 



Сonsole.Write(" Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int LengthNumbers(int num)
{
    int length = 0;
    int number = num;
    while (number > 0 || number < 0)
    {
        number = number / 10;
        length++;
    }
    return length;
}
int lengths = LengthNumbers(num);
int SumNumbers(int num)
{
    int result = 0;
    int inter = 0;

    for (int i = 1; i <= lengths; i++)
    {
        inter = num - num % 10;
        result = result + (num - inter);
        num = num / 10;
    }
    return result;
}

int numbers = num;
int result = SumNumbers(num);
Console.WriteLine($"Cумма цифр в числе {numbers} равно {result}");