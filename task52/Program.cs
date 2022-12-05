// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double[] AverageArray(int[,] martix)
{
    double[] averageArray = new double[martix.GetLength(1)];
    double average = 0;
    double sumCoulumnElement = 0;
    for (int j = 0; j < martix.GetLength(1); j++)
    {
        for (int i = 0; i < martix.GetLength(0); i++)
        {
            sumCoulumnElement = (sumCoulumnElement + martix[i, j]);
        }
        average = Math.Round(sumCoulumnElement / martix.GetLength(0), 1, MidpointRounding.ToZero);
        averageArray[j] = average;
        sumCoulumnElement = 0;
    }
    return averageArray;
}

int[,] matr = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matr);
double[] resultArray = AverageArray(matr);
Console.WriteLine($"Среднее арифметическое каждого слобца:");
PrintArray(resultArray);