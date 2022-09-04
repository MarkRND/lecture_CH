// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
void AnotherMatrix(int[,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int y = 0; y < matrix.GetLength(1) - 1; y++)
            {
                if (matrix[i, y] < matrix[i, y + 1])
                {
                    int res = 0;
                    res = matrix[i, y];
                    matrix[i, y] = matrix[i, y + 1];
                    matrix[i, y + 1] = res;
                }
            }
        }
    }
}
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
Console.WriteLine("Случайный массив.");
PrintMatrix(array2D);
Console.WriteLine();
Console.WriteLine("Упорядоченые по убыванию элементы каждой строки заданого массива.");
AnotherMatrix(array2D);
PrintMatrix(array2D);
