// Напишите программуБ которая принимает на вход число и выдает количество цифр.

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("количество знаков: "+Digits(number));
}
else
number = -number;
Console.WriteLine("количество знаков: "+Digits(number));
    //Console.Write("число меньше '0' ");

int Digits(int num)
{
    int result = 0;
    if (num > 0)
    {
        while (num > 0) { num = num / 10;result++;}
    }
    return result;
}
