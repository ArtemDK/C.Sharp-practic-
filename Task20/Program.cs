// Напишите программу, которая принимает на вход координаты двух точек 
// и показывает расстояние между ними в 2D пространстве.
// А (3,6); B (2,1) -> 5,09
// А (7,-5); B (1,-1) -> 7,21

Console.Clear();

Console.WriteLine("Введите координаты точки: ");

Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

// double sum = Math.Sqrt ((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
// Console.WriteLine (Math.Round(sum,2));

double Summlenght(int x1с, int y1c, int x2с, int y2c)
{
    return Math.Sqrt((x1c - x2c) * (x1c - x2c) + (y1c - y2c) * (y1c - y2c));
}
double result = Summlenght(x1, y1, x2, y2);
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));