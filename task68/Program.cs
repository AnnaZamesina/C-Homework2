// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    else if (numberN == 0) return Akkerman(numberM - 1, 1);
    return Akkerman(numberM - 1, Akkerman(numberM, numberN - 1));
}

if (m < 0 || n < 0) Console.WriteLine("Вы ввели отрицательное число. Повторите ввод");
else Console.WriteLine(Akkerman(m, n));