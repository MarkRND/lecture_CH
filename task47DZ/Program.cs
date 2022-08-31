// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] CreateMatrixRndDouble(int row, int col, int min, int max)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)  // строки row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // столбцы col
        {
            matrix[i, j] = rnd.Next(min, max + 1) + rnd.NextDouble();
            matrix[i, j] = Math.Round(matrix[i, j], 1); ;
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 3}, ");
            // else Console.Write($"{matrix[i,j], 3}");
            Console.Write(j < matrix.GetLength(1) - 1 ? $" |{matrix[i, j],3}|," : $"|{matrix[i, j],3}| ");
        }
        Console.WriteLine("]");
    }
}
double[,] array2D = CreateMatrixRndDouble(3, 4, -1, 100);
PrintMatrix(array2D);