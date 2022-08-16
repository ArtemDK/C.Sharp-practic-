// Напишите программу, которая:
// ПО заданноому номеру четверти, показывает диапазон возможных координта точек в этой четверти (x и y)

Console.Clear();
Console.WriteLine("Введите номер Четверти: ");
int x = Convert.ToInt32(Console.ReadLine());

string Coordinates(int xc)
{
    if (xc == 1) return "Диапазон координат для 1 Четверти";
    if (xc == 2) return "Диапазон координат для 2 Четверти";
    if (xc == 3) return "Диапазон координат для 3 Четверти";
    if (xc == 4) return "Диапазон координат для 4 Четверти";
    return "Такой четверти не существует";
}
string result = Coordinates (x);
Console.WriteLine (result);