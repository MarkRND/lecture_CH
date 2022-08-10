// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число от 1: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 1)
for (int num2 = 1; num2 <= num; num2++)
        {
            if (num2 % 2 == 0) 
            Console.Write(num2 + " ");        
        }
else
        {
Console.WriteLine("Ошибка введите положительное число от 1");
        }





// for (int num2 = 1; num2 >= num; num2--)
//         {
//             if (num2 % 2 == 0) 
//             Console.Write(num2 + " ");
//         }
// int num2 = - num;
// while (num2 <= num; num2 = num % 2;)
// {
//     Console.Write(" ");
//     num2++;                                   // альтернативный способ , через while
// }
// Console.WriteLine();
// Console.Write("вывод чисел ");


// int chet = num % 2;
// if (chet == 0)

    // for (int num2 = 1; num2 <= num; num2++)

    // {
    //     // int chet = num % 2;
    //     // if (chet == 0)
    // //   {
    // //     if (num2 = num % 2)
    // //   }
    // Console.Write(num2 + " ");
    // }    

// int N = 1;
// while (N <= num)
//  {
//    {
//     if (num % 2 == 0)
// for (int i = 1; i <= n; i++)
//     if (i % 2 == 0)
//         Console.WriteLine(i);
//    }

// if (num2 % 2 == 0)
//     {
//     for( int num2 = 1; num2 <= num; num2++)
//         {
//             Console.Write(num2 + " ");
//         }    
        
//     Console.Write(num2 + " ");
//     }

// if (num > 0)

//     for (int num2 = -num; num2 <= num; num2++)
//     {
//         if (num2 == num2 / 2)  
//     Console.Write(num2 + " ");
//     }

