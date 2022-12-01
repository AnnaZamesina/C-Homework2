// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэффициент угла наклона k1 первой прямой");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1 первой прямой");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент угла наклона k2 второй прямой");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2 второй прямой");
double b2 = Convert.ToDouble(Console.ReadLine());

double[] FindCrossPoint(double indK1, double indB1, double indK2, double indB2)
{
    double[] foundPointArray = new double[2];
    foundPointArray[0] = Math.Round(((indB2 - indB1) / (indK1 - indK2)), 2, MidpointRounding.ToZero);
    foundPointArray[1] = Math.Round((indK1 * foundPointArray[0] + indB1), 2, MidpointRounding.ToZero);
    return foundPointArray;
}

void PrintArray(double[] arr, string symb1, string symb2)
{
    Console.Write(symb1);
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(symb2);
}

double[] resultArray = FindCrossPoint(k1, b1, k2, b2);

Console.WriteLine($"Координаты точки пересечения:");
PrintArray(resultArray, "(", ")");