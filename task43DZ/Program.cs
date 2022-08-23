// Задача 43: Напишите программу, 

// 1которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double Input(string name)
{
    Console.Write("Введите значение " + name + " :");
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double b1 = Input("b1");
double k1 = Input("k1");
double b2 = Input("b2");
double k2 = Input("k2");
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
if (k1 != k2)
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> точка пересечения прямых линий ({x}; {y})");

else if (b1 == b2)
{
    Console.WriteLine("Прямые линии совпадают");
}
else
    Console.WriteLine("Прямые линии параллельны");


// / Console.Write($"Введите значение b1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите значение k1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите значение b2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Введите значение k2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());










// double[,] coeff = new double[2, 2];
// double[] crossPoint = new double[2];

// void InputCoefficients(){
//   for (int i = 0; i < coeff.GetLength(0); i++)
//   {
//     Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
//     for (int j = 0; j < coeff.GetLength(1); j++)
//     {
//       if(j==0) Console.Write($"Введите коэффициент k: ");
//       else Console.Write($"Введите коэффициент b: ");
//       coeff[i,j] = Convert.ToInt32(Console.ReadLine());
//     }
//   }
// }

// double[] Decision(double[,] coeff)
// {
//   crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
//   crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
//   return crossPoint;
// }

// void OutputResponse(double[,] coeff)
// {
//   if (coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1]) 
//   {
//     Console.Write($"\nПрямые совпадают");
//   }
//   else if (coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1]) 
//   {
//     Console.Write($"\nПрямые параллельны");
//   }
//   else 
//   {
//     Decision(coeff);
//     Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
//   }
// }

// InputCoefficients();
// OutputResponse(coeff);

// void CaseProgramm1()
// {
//     Console.WriteLine("ВВедите любые числа разделённые любым знаком");
//     int[] array = Array.ConvertAll(
//         FilterStringOutDigitals(Console.ReadLine()).Split(" "),
//         int.Parse);

//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     Console.WriteLine("Введено положительных чисел: " + count);
// }



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// void CaseProgramm2()
// {
//     double enterNumberK1, enterNumberB1;
//     double enterNumberK2, enterNumberB2;
//     double resultCoordinateX, resultCoordinateY;

//     Console.WriteLine("Укажите запрошенные переменные для двух прямыx заданых уравнением:");
//     Console.WriteLine("y = k * x + b");

//     Console.Write("k1 = ");
//     enterNumberK1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("b1 = ");
//     enterNumberB1 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("k2 = ");
//     enterNumberK2 = Convert.ToDouble(Console.ReadLine());
//     Console.Write("b2 = ");
//     enterNumberB2 = Convert.ToDouble(Console.ReadLine());

// if (enterNumberK1 != enterNumberK2)
// {
//     resultCoordinateX = (enterNumberB2 - enterNumberB1) / (enterNumberK1 - enterNumberK2);
//     resultCoordinateY = enterNumberK2 * resultCoordinateX + enterNumberB2;

//     Console.WriteLine("Координаты точки пересечения:");
//     Console.WriteLine($"X = {resultCoordinateX} ; Y = {resultCoordinateY}");
// }
// else if (enterNumberB1 == enterNumberB2) Console.WriteLine("Прямые совпадают");
// else Console.WriteLine("Прямые параллельны");