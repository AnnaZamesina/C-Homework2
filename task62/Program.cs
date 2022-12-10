// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixRndIntjm(int row, int column)
{
    int[,] matrix = new int[row, column];
    int temp = 1;
    int i =0;
    int j =0;
    while (temp < matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;
        temp++;
        if (i+j == matrix.GetLength(1)&&j<matrix.GetLength(1)) i++;
        else if (i == j) j--;
        else i--;
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

int[,] table1 = CreateMatrixRndIntjm(3, 3);

PrintMatrix(table1);