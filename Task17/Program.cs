// Напишите программу, которая принимает на вход координаты точек X и Y, и определяет:
//  номер четверти плосткосли в которой находится эта координата.

Console.Clear();
Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0) Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("Координаты нулевые");

string GetQuarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Координаты нулевые";
}
string result = GetQuarter (x, y);
Console.WriteLine (result);