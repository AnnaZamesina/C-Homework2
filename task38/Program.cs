// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2, MidpointRounding.ToZero);
    }
    return arr;
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

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально допустимое число в массиве");
int imin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое число в массиве");
int imax = Convert.ToInt32(Console.ReadLine());

double[] array = CreateArrayRndDouble(length, imin, imax);
PrintArray(array, "[", "]");
double result = Math.Round(FindMax(array) - FindMin(array), 2, MidpointRounding.ToZero);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {result}");




