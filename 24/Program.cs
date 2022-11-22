//Напишите программу,которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());


void Sum(int n)
{  int sum =0;
 if(n<0){
     System.Console.WriteLine("не то число");
     }else{
    for (int i = 1; i <= n; i++)
    {
       sum=sum+i;
    } Console.WriteLine($"сумма последовательности {sum}");}
//return sum;
}

Sum(number);
