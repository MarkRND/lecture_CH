// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// 
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 49 2
// 5 81 2 9
// 64 4 4 4


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
void ChangeEvenIndexToPov (int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i+=2)  // строки row
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)  // столбцы col
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }


}
int[,] array2d = CreateMatrixRndInt(3, 5, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
ChangeEvenIndexToPov(array2d);
PrintMatrix(array2d);