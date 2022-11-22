// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

Console.WriteLine("Введите значение основания степени");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение показателя степени");
int b = Convert.ToInt32(Console.ReadLine());

int NumberToPower(int basement, int power)
{
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result = result * basement;
    }
    return result;
}

if (b <= 0) Console.WriteLine("Показатель степени должен быть натуральным числом");
else Console.WriteLine($"Ответ: {NumberToPower(a, b)}");
