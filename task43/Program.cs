// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] IntersectionPoint(double c1, double d1, double c2, double d2)
{
    double[] coordinatesIntersection = new double[2];
    double x = (d2 - d1) / (c1 - c2);
    coordinatesIntersection[0] = x;
    double y = (coordinatesIntersection[0] * c1) + d1;
    coordinatesIntersection[1] = y;
    return coordinatesIntersection;
}

void PrintArray(double[] array)
{
    Console.Write("(");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine(")");
}

Console.WriteLine("Введите параметры уравнений");
Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите параметры уравнений");
Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите параметры уравнений");
Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите параметры уравнений");
Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 != k2)
{
    double[] coordinates = IntersectionPoint(k1, b1, k2, b2);
    PrintArray(coordinates);
}
else if (b1 == b2) Console.WriteLine(("Линии совпадают. Бесконечное множество точек пересечения"));
else Console.WriteLine(("Паралелльные линии. Нет пересечений"));