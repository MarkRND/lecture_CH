// 50 Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

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
void IntIndex(int[,] matrix)
{
    Console.Write("Введите номер строки: ");
    int num1 = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Введите номер столбеца: ");
    int num2 = Convert.ToInt32(Console.ReadLine()) - 1;
    // int result = matrix[num1, num2];
    if (num1 < 0 | num1 > matrix.GetLength(0) - 1 | num2 < 0 | num2 > matrix.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент по такой позиции не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", matrix[num1, num2]);
    }
}
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
IntIndex(array2D);



