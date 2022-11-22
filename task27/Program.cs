// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int DigitSum(int num)
{
    int count = 0;
    int remain = 0;
    int sum = 0;
    if (num < 0) num = -num;   
    while (num > 0)
    {
        remain = num % 10;
        num = num / 10;
        sum = sum + remain;
        count++;
    }
    return sum == 0 ? 0 : sum;
}
Console.WriteLine($"Сумма цифр в числе: {DigitSum(number)}");

