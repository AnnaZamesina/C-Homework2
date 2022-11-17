// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
bool WeekendNumber(int num)
{
    if (num == 6 || num == 7) return true;
    return false;
}
Console.WriteLine(WeekendNumber(day) ? "Ура!Выходной!" : "К сожалению, нет");

