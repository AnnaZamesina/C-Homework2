// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления). 25347

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool Polyndrom(int num)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num / 10 % 10) return true;
    return false;
}

if (number < 10000 || number >= 1000000 ) Console.WriteLine("Некорректные данные, повторите ввод");
else Console.WriteLine(Polyndrom(number) ? "да" : "нет");

