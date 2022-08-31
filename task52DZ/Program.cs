// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

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

double[] Arithmetic(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            result[i] += matrix[j, i];
        }
        result[i] = Math.Round(result[i] / matrix.GetLength(0), 1);
        
    }
    return result;
}
void PrintArray (double[] array) 
{
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце. : ");
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++) 
    {
        if (i < array.Length - 1) Console.Write($"|{array[i]}| ");
        else Console.Write(array[i]);
    }
    Console.Write("| ]");
    Console.WriteLine();
}
int[,] array2D = CreateMatrixRndInt(4, 3, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
double[] array = Arithmetic(array2D);
Arithmetic(array2D);
PrintArray(array);


