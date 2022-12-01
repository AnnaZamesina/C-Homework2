// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

Console.WriteLine("Сколько чисел вы хотите ввести?");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {number} чисел");

int[] FillArray(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int OverZeroNumbers(int[] arr)
{
    int amount = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) amount++;
    }
    return amount;
}

int[] array = FillArray(number);
Console.WriteLine($"Количество введенных чисел больше 0: {OverZeroNumbers(array)}");