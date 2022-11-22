// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое число в массиве");
int imax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально допустимое число в массиве");
int imin = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];

void FillArray(int[] collection, int minInd, int maxInd)
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(minInd, maxInd + 1);
    }
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write ($"{col[i]}  ");
    }
}

FillArray(array, imin, imax);
PrintArray(array);