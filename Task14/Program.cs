// Напишите программу, которая на вход принимает два числа и проверяет:
// является ли одно число квадратом другого.

Console.Write("Введите целое число 1: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число 2: ");
int second = Convert.ToInt32(Console.ReadLine());

bool Squ(int a, int b)
{
 return a == b * b || b == a * a;
 }
if (Squ (first, second)) Console.WriteLine("да");
else Console.WriteLine("нет");