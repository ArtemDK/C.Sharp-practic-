// Напишите программу, которая принимает на вход число
//  и выдаёт количество цифр в числе. 
//  456 -> 3 78 -> 2 89126 -> 5
Console.Clear();
Console.Write("Введите целое число : ");
int num = Convert.ToInt32(Console.ReadLine());
int Dig(int a)
{
    int count = 0;
    while (a > 0)
    {
        a = a / 10;
        count++;
    }
    return count;
}
int res = Dig(num);
Console.WriteLine($"Количесвто цифр в числе {num} -> {res}");