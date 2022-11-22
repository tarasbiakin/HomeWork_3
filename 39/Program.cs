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

double st1=Math.Sqrt(Math.Pow (xa-xb,2)+(Math.Pow(ya-yb,2)));//Math.Pow(i,3)
double st2=Math.Sqrt(Math.Pow (xa-xc, 2))+(Math.Pow (ya-yc,2));
double st3=Math.Sqrt((Math.Pow (xb-xc,2))+(Math.Pow (yb-yc,2)));
//double p = st1+st2+st3;


double Lenght (double xa, double ya,double xb, double yb,double xc,double yc){
    double res = st1+st2+st3;
    return res;
}

double Sqare (double st1, double st2,double st3,double Lenght)
{
    double p = Lenght/2;
    double res = Math.Sqrt(p*((p-st1)*(p-st2)*(p-st3)));
    return res;
    //return p;
}

double lenght = Lenght(xa,ya,xb,yb,xc,yc);
double lenghtRound= Math.Round(lenght,2, MidpointRounding.ToZero);
Console.WriteLine("Периметр:"+lenghtRound);
Console.WriteLine($" {Math.Round(st1,3,MidpointRounding.ToZero)}| {Math.Round(st2,3,MidpointRounding.ToZero)}| {Math.Round(st3,3,MidpointRounding.ToZero)}");


double sqr = Sqare (st1,st2,st3,lenght);
double sqrRound= Math.Round(sqr,4, MidpointRounding.ToZero);
Console.WriteLine("Площадь: " +sqrRound);

//  double per = Sqare (st1,st2,st3);
//  double sqrRound= Math.Round(per,2, MidpointRounding.ToZero);
//  Console.WriteLine("Площадь: " +sqrRound);
