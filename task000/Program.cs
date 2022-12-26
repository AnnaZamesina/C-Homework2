
string[] CreateArrayString(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr, string symb1, string symb2)
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

string[] CreateLessThan3ElementsArray(string[] arr)
{
    int lenghtNewArray = 0;
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) lenghtNewArray++;
    }
    string[] newArray = new string[lenghtNewArray];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArray[index] = arr[i];
            index++;
        }
    }
    return newArray;
}

Console.WriteLine("Введите длину массива");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Заполните строковый массив из {lenght} элементов");
string[] array = CreateArrayString(lenght);
PrintArray(array, "[", "]");
string[] array2 = CreateLessThan3ElementsArray(array);
Console.WriteLine();
PrintArray(array2, "[", "]");
