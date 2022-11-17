// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int num)
{
    if (num < 0) return num / 10 % 10 * -1;
    return num / 10 % 10;
}

if (number > -1000 && number <= -100) Console.WriteLine($"Вторая цифра числа: {SecondDigit(number)}");
else if (number >= 100 && number < 1000) Console.WriteLine($"Вторая цифра числа: {SecondDigit(number)}");
else Console.WriteLine("Ошибка. Число не трехзначное");
