// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координаты точки ХA: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки YA: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки ZA: ");
double za = Convert.ToDouble(Console.ReadLine());


Console.Write("Введите координаты точки ХB: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки YB: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты точки ZB: ");
double zb = Convert.ToDouble(Console.ReadLine());


double Lenght (double xa, double ya,double za,double xb, double yb, double zb){
    double res = Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(za-zb)*(za-zb));
    return res;
}

double lenght = Lenght(xa,ya,za,xb,yb,zb);
double lenghtRound= Math.Round(lenght,2, MidpointRounding.ToZero);
Console.WriteLine(lenghtRound);
