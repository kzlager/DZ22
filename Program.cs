// 22. Найти расстояние между точками в пространстве 2d/3d

//
double Distance2D(double x1, double y1. double x2, double y2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Mzth.Pow(y2 - y1, 2));
    return result;
}

double Distance3D(double x1, double y1. double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Mzth.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

Console.Write("Введите пространство для поиска расстояния между точками (2d или 3d): ");
string choice = Console.ReadLine();
