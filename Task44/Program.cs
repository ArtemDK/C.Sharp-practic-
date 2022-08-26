// программу, каорая выводит первые N чисел Фибоначи.
Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()!);
Fibo(num);
void Fibo(int number)
{
    int prevPrev = 0;
    int prev = 1;
    Console.Write($"{prevPrev} {prev} ");
    for (int i = 3; i <= number; i++)
    {
        int rezult = prev + prevPrev;
        Console.Write(rezult + " ");
        prevPrev = prev;
        prev = rezult;
    }
}