// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr, string symb1, string symb2)
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

int SumOddPosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) sum = sum + arr[i];
    }
    return sum;
}

Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально допустимое число в массиве");
int imin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально допустимое число в массиве");
int imax = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayRndInt(length, imin, imax);
PrintArray(array, "[", "]");
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {SumOddPosition(array)}");