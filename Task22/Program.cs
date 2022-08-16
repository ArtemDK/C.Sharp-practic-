// Напишите программу, которая принимает на вход число N  
// и выдает таблицу квадратов чисел от 1 до N.
//  5 -> 1, 4, 9, 16, 25

Console.Write("Введите целое число : ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) Console.WriteLine("введите число больше ноля");

void PrintQuard(int a)
{
    for (int i = 1; i < a; i++)
        Console.WriteLine($"{i} \t {i * i}");
}
PrintQuard(n);






// int index =  1;
// while (index != a )
// {
//     int squad = index * index;
//     index++;
//     Console.WriteLine (squad);
// }