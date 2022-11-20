// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите число ");
int x = Convert.ToInt32(Console.ReadLine());

int Reverse(int i)
{
    int res = 0;
    while (i != 0)
    {
        int ostatok;
        i = Math.DivRem(i, 10, out ostatok);
        res = res * 10 + ostatok;
    }
    return res;
}
int a = Reverse(x);
Console.WriteLine((a==x)?"да":"нет");

//a =  x ?Console.WriteLine(a): "Нет";
//Console.WriteLine(a);

