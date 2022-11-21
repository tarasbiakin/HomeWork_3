//Вычисли периметр треугольника по координатам в 2D плоскости. Координаты вводит пользователь

Console.Write("Введите координаты точки 1 ХA: ");
double xa  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 1 YA: ");
double ya = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"{xa}.{ya}");

Console.Write("Введите координаты точки 2 ХB: ");
double xb  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 2 YB: ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки 3 ХC: ");
double xc  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 3 YC: ");
double yc = Convert.ToDouble(Console.ReadLine());

double st1=Math.Sqrt(((xa-xb)*(xa-xb))+((ya-yb)*(ya-yb)));//Math.Pow(i,3)
double st2=Math.Sqrt(((xa-xc)*(xa-xc))+((ya-yc)*(ya-yc)));
double st3=Math.Sqrt(((xb-xc)*(xb-xc))+((yb-yc)*(ya-yc)));
//double p = st1+st2+st3;


double Lenght (double xa, double ya,double xb, double yb,double xc,double yc){
    double res = st1+st2+st3;
    return res;
}

double Sqare (double st1, double st2,double st3)
{
    double res = Math.Sqrt(((st1+st2+st3)/2)*(((st1+st2+st3)/2)-st1)*(((st1+st2+st3)/2)-st2)*(((st1+st2+st3)/2)-st3));
    return res;
}

double lenght = Lenght(xa,ya,xb,yb,xc,yc);
double lenghtRound= Math.Round(lenght,2, MidpointRounding.ToZero);
Console.WriteLine("Периметр:"+lenghtRound);
//Console.WriteLine($" {st1},{st2},{st3}");


double sqr = Sqare (st1,st2,st3);
double sqrRound= Math.Round(sqr,2, MidpointRounding.ToZero);
Console.WriteLine("Площадь: " +sqrRound);
