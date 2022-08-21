// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
//  4 -> 24 5 -> 120 
Console.Clear();
Console.Write("Введите целое число : ");
int num = Convert.ToInt32(Console.ReadLine());
int Dig(int a)
{
    int sum = 1;
    for (int i = 1; i <= a; i++) sum = sum * i;
    return sum;
}
int rez = Dig(num);
Console.WriteLine($"произведение всех чисел от 1 до {num} = {rez}");