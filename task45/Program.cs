// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


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
int[] ReturnArray(int[] array)
{
    int[] arr = new int[array.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}

int[] arr1 = CreateArrayRndInt(10, 1, 20);
PrintArray(arr1);
int[] arr2 = ReturnArray(arr1);
PrintArray(arr2);

Console.WriteLine("Изменим втрое значение в массиве, чтобы определить скопированный массив");

arr1[1] = 30;
PrintArray(arr1);
PrintArray(arr2);


// // фибоначи, ввести число, и столько чиселок
// Console.Write("Введите число:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr=new int[size];
// arr[0]=0;
// arr[1]=1;
// for (int i = 2; i < size; i++)
// {
//     arr[i]=arr[i-1]+arr[i-2];
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}");
//         if (i != array.Length - 1) Console.Write(",");
//     }                                                                            через массив

//     Console.Write("]");
//     Console.WriteLine();
// }
// PrintArray(arr);
