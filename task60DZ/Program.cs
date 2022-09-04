// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateMatrixRndInt(int row, int col, int div, int min, int max)
{

    int[,,] matrix = new int[row, col, div];
    Random rnd = new Random();
    int[] temp = new int[row * col * div];
    int  num;
    int count = 0;
    for (int i = 0; i < temp.GetLength(0); i++)
    {
        temp[i] = new Random().Next(min, max);
        num = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(min, max);
                    j = 0;
                    num = temp[i];
                }
                num = temp[i];
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)  // строки row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // столбцы col
        {
            for (int y = 0; y < matrix.GetLength(2); y++)  // столбцы div
            {
                matrix[i, j, y] = temp[count++];
                
            }
        }
        
    }
return matrix;
}
void PrintMatrix(int[,,] matrix)
{
    Console.WriteLine($"Массив размером {matrix.GetLength(0)} x {matrix.GetLength(1)} x {matrix.GetLength(2)}");
    for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
}
}
int[,,] array3D = CreateMatrixRndInt(2, 2, 2, 10, 99);
PrintMatrix(array3D);