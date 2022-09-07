// задача № 21
// описываем метод
void GetDistance (double a1, double b1, double c1, double a2, double b2, double c2)
{
    // расстояние между точкамм
    Console.Write("Расстояние между точками: ");
    Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(a1-a2,2)+Math.Pow(b1-b2,2)+Math.Pow(c1-c2,2)),2));
}

// ввод данных
Console.WriteLine("Введите координаты первой точки:");
Console.Write("x1 = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1 = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("z1 = ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("x2 = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2 = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("z2 = ");
double z2 = Convert.ToDouble(Console.ReadLine());

// вызываем метод 
GetDistance(x1,y1,z1,x2,y2,z2);