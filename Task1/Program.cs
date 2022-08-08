// Напишите программу, которая на вход принимает два числа
//  и проверяет, является ли первое число квадратом второго.
//   a = 25, b = 5 -> да
//    a = 2, b = 10 -> нет 
//    a = 9, b = -3 -> да 
//       a = -3 b = 9 -> нет


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите целое число 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите целое число 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2 * num2)
        {
            Console.Write($"число {num1} является квадратом числа {num2}");
        }
        else
        {
            Console.Write($"число {num1} не является квадратом числа {num2}");
        }
    }
}