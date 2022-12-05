// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


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

int FindElement(int[,] matrix, int indI, int indJ)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == indI && j == indJ) result = matrix[i, j];
        }
    }
    return result;
}

int[,] matr = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matr);
Console.WriteLine("Введитете номер строки: ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитете номер столбца: ");
int columnNum = Convert.ToInt32(Console.ReadLine());
int findElement = FindElement(matr, rowNum, columnNum);

if (rowNum < 0 || columnNum < 0) Console.WriteLine("Введите положительные целые числа");
else if (rowNum > matr.GetLength(0) - 1 || columnNum > matr.GetLength(1) - 1) Console.WriteLine("Такой позиции нет, повторите ввод");
else Console.WriteLine($"Значение элемента на заданной позиции: {findElement}");