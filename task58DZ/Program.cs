// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[i, j],3}," : $"{matrix[i, j],3}");
        }
        Console.WriteLine(" ]");
    }
}
int[,] СompositionMatrix(int[,] array2D, int[,] array2D2)
{
    int[,] resultMatrix = new int[array2D.GetLength(0), array2D2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int y = 0; y < array2D.GetLength(1); y++)
            {
                sum += array2D[i, y] * array2D2[y, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
}
int[,] array2D = CreateMatrixRndInt(2, 2, 2, 4);
Console.WriteLine("Первый массив");
PrintMatrix(array2D);
int[,] array2D2 = CreateMatrixRndInt(2, 2, 2, 4);
Console.WriteLine("Второй массив");
PrintMatrix(array2D2);
Console.WriteLine("Результат произведение двух матриц");
int[,] array = СompositionMatrix(array2D, array2D2);
PrintMatrix(array);

