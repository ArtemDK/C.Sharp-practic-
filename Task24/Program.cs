// Напишите программу, которая принимает на вход число (А)
//  и выдаёт сумму чисел от 1 до А. 
// 7 -> 28 4 -> 10 8 -> 36

Console.Write("Введите целое число : ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) Console.WriteLine("введите число больше 0");
int sum = 0;
for (int i = 1; i <= num; i++)
{
    sum += i;
}
Console.WriteLine($"сумма чисел от 1 до {num} = {sum}");