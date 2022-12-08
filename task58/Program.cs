// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultyplicityForMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] = resultMatrix[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}
int[,] table1 = CreateMatrixRndInt(2, 2, 0, 5);
int[,] table2 = CreateMatrixRndInt(2, 2, 0, 5);

PrintMatrix(table1);
Console.WriteLine();
PrintMatrix(table2);
Console.WriteLine();

if (table1.GetLength(1) == table2.GetLength(0))
{
    int[,] table3 = MultyplicityForMatrix(table1, table2);
    PrintMatrix(table3);
}
else Console.WriteLine("Измените размерность исходных матриц");