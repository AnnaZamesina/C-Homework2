// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumofElementsInRange(int numberM, int numberN)
{
    if (numberM == numberN) return numberM;
    else if (numberM < numberN) return numberM + SumofElementsInRange(numberM + 1, numberN);
    return numberM + SumofElementsInRange(numberM - 1, numberN);
}

Console.WriteLine($"{SumofElementsInRange(m, n)}");