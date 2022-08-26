// Напишите прошраммуб которая принимает на вход три числа
// и проверяет может ли существать треугольник со сторонами такой длины.

Console.WriteLine("Введите 3 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a < b + c && b < a + c && c < a + b) Console.WriteLine("может");
else Console.WriteLine("Не может");