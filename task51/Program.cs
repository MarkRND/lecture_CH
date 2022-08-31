// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12


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
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 3}, ");
            // else Console.Write($"{matrix[i,j], 3}");
            Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[i, j],3}, " : $"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}
int SumOfMainDiagonalValue(int[,] matrix)
{

    int result = 0;
    // int mainDiag = 0;
    // if (matrix.GetLength(0) < matrix.GetLength(1)) mainDiag = matrix.GetLength(0);
    // else mainDiag = matrix.GetLength(1);
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        result += matrix[i, i];
    }
return result;

}
int[,] array2d = CreateMatrixRndInt(5, 5, 1, 5);
 PrintMatrix(array2d);
Console.WriteLine($"Найдите сумму элементовб находящихся на главной диагонали: {SumOfMainDiagonalValue (array2d)}");
// int[,] array2d = CreateMatrixRndInt(3, 5, 0, 10);
// PrintMatrix(array2d);
// Console.WriteLine();
// ChangeEvenIndexToPov(array2d);
// PrintMatrix(array2d);