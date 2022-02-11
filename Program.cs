// Найти расстояние между точками в пространстве 2D/3D

Console.Clear();
Console.Write("Выберите мерность (2/3)");
int mer = int.Parse(Console.ReadLine());

void D2(int ax, int ay, int bx, int by)
{
    Console.WriteLine("Расстояние от точки а до точки b: " + Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2)));
}

void D3(int ax, int ay, int bx, int by, int az, int bz)
{
    Console.WriteLine("Расстояние от точки а до точки b: " + Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az),2)));
}

if (mer != 2 && mer != 3) Console.WriteLine("Неверный входной параметр!");

else if (mer == 2)
{
    Console.Write("Введите координату Х точки а: ");
    int ax = int.Parse(Console.ReadLine());
    Console.Write("Введите координату Y точки а: ");
    int ay = int.Parse(Console.ReadLine());
    Console.Write("Введите координату Х точки b: ");
    int bx = int.Parse(Console.ReadLine());
    Console.Write("Введите координату y точки b: ");
    int by = int.Parse(Console.ReadLine());

    D2(ax, ay, bx, by);
}

else
{
    Console.Write("Введите координату Х точки а: ");
    int ax = int.Parse(Console.ReadLine());
    Console.Write("Введите координату Y точки а: ");
    int ay = int.Parse(Console.ReadLine());
    Console.Write("Введите координату Z точки a: ");
    int az = int.Parse(Console.ReadLine());
    Console.Write("Введите координату y точки b: ");
    int by = int.Parse(Console.ReadLine());
    Console.Write("Введите координату Х точки b: ");
    int bx = int.Parse(Console.ReadLine());
    Console.Write("Введите координату Z точки b: ");
    int bz = int.Parse(Console.ReadLine());

    D3(ax, ay, bx, by, az, bz);
}