// Задача 38: 
// 1)Задайте массив вещественных чисел. 
// 2)Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max) + rnd.NextDouble();
        array[i] = Math.Round(array[i], 1);
        // array[i] = Convert.ToDouble(rnd.Next(min, max))/10;
    }
    return array;
}

void PrintArray(double[] array)
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
double[] randomАrray = CreateArrayRndInt(5, 0, 100);
double maxnum = randomАrray[0];
double minnum = randomАrray[0];

for (int i = 1; i < randomАrray.Length; i++)
{
    if (maxnum < randomАrray[i])
    {
        maxnum = randomАrray[i];
    }
    if (minnum > randomАrray[i])
    {
        minnum = randomАrray[i];
    }
}
double res = maxnum - minnum;
PrintArray(randomАrray);
Console.WriteLine($"Разницу между максимальным и минимальным элементами массива -> {res}");