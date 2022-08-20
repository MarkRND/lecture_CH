


// int[] arr = CreateArrayRndInp(5, 0, 9);

// Console.Write("Введите число для проверки: ");
// int number = Convert.ToInt32(Console.ReadLine());
// bool NumberIsInArray (int[] arrayForSerh, int number)
// {
//    for (int i = 0; i < arrayForSerh.Length; i++)
//    {
//      if (arrayForSerh[i] == number)
//      {
//         return $"число {number} содержится в массиве ";
//      }
//    }
//        return $"число {number} не содержится в массиве ";
// }


// int[] CreateArrayRndInp(int size, int min, int max)
// {
//     int[] array = new int[size];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if( i < array.Length -1) Console.Write($"{array[i]}, ");
//         else Console.Write($"{array[i]}");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }



// int[] CreateArrayRndInt(int size, int min, int max) {
    
//     int[] array = new int[size];
//     Random rnd = new Random();

//     for (int i = 0; i < size; i++) {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array) {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++) {
//         if (i < array.Length - 1) Console.Write($"{array[i]}, ");
//         else Console.Write(array[i]);
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// bool FindNumerFave(int[] array, int number) 
// {
//     bool j = false;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number) j = true;  
//     }
//     break;
// }

// Console.Write("Введите целое положительное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] arr = CreateArrayRndInt(10, 1, 10);
// PrintArray(arr);
// bool a = FindNumerFave(arr, num);
// if (a) Console.WriteLine("Да");
// else Console.WriteLine("Нет");





int[] CreateArrayRndInt(int size, int min, int max) 
{
    
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++) 
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array) 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++) 
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

bool FindNumberFave(int[] array, int number) 
{
    bool j = false;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] == number) 
        {
            j = true;
            break;
        }  
    }
    return j;
}

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayRndInt(10, 1, 10);
PrintArray(arr);
bool a = FindNumberFave(arr, num);
Console.WriteLine(a?"Да":"Нет");




