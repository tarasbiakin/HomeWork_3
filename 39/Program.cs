//Вычисли периметр треугольника по координатам в 2D плоскости. Координаты вводит пользователь

Console.Write("Введите координаты точки 1 ХA: ");
double xa  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 1 YA: ");
double ya = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine($"{xa}.{ya}");

Console.Write("Введите координаты точки 2 ХA: ");
double xb  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 2 YA: ");
double yb = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты точки 3 ХA: ");
double xc  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки 3 YA: ");
double yc = Convert.ToDouble(Console.ReadLine());

double Lenght (double xa, double ya,double xb, double yb,double xc,double yc){
    double res = Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(xc-xa)*(xc-xa)+(yc-ya)*(yc-ya));
    return res;
}

double lenght = Lenght(xa,ya,xb,yb,xc,yc);
double lenghtRound= Math.Round(lenght,2, MidpointRounding.ToZero);
Console.WriteLine(lenghtRound);