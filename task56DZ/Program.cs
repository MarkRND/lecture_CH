// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)  // строки row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // столбцы col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 3}, ");
            // else Console.Write($"{matrix[i,j], 3}");
            
            Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[i, j],3}, |" : $"{matrix[i, j],3}");
        }
        Console.WriteLine(" |]");
    }
}
void IndexMinSumMatrix(int[,] matrix)
{
    int msum = Int32.MaxValue;
    int indexLine = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if(sum < msum)
        {
            msum = sum;
            indexLine++;
        }
    }
    Console.WriteLine($"Cтрока с наименьшей суммой элементов под номером: {indexLine}");
}
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
IndexMinSumMatrix(array2D);

