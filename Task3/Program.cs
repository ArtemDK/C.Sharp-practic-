// Напишите программу, которая будет выдавать название дня недели по заданному номеру. 3 -> Среда 5 -> Пятница

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите номер дня недели: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 1 || num > 7)
            Console.Write($"для числа {num} нет дня недели");
        else if (num == 1)
        {
            Console.Write($"{num} день недели - понедельник");
        }
        else if (num == 2)
        {
            Console.Write($"{num} день недели - вторник");
        }
        else if (num == 3)
        {
            Console.Write($"{num} день недели - среда");
        }
        else if (num == 4)
        {
            Console.Write($"{num} день недели - четверг");
        }
        else if (num == 5)
        {
            Console.Write($"{num} день недели - пятница");
        }
        else if (num == 6)
        {
            Console.Write($"{num} день недели - суббота");
        }
        else if (num == 7)
        {
            Console.Write($"{num} день недели - воскресенье");
        }
    }
}