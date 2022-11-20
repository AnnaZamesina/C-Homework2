// 
// n=0+1=1 number=1232  
// n=10+2=12 number=123
// n=120+3=123 number=12 
// n=1230+2=1232 number=1 
// n=12320+1 number =0

Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());

bool Polyndrom(int num)
{
    int n = 0;
    int number = num;
    while (num > 0)
    {
        n = n * 10 + num % 10;
        num = num / 10;
    }

    if (n == number) return true;
    return false;
}

if (number<10) Console.WriteLine("Некорректные данные.Повторите ввод");
else Console.WriteLine(Polyndrom(number) ? "да" : "нет");
