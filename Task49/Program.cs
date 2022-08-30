// Задайте 2х мерный массив. Найдите элементы у которых индексы четные и замените их на их квадраты.


Console.Clear();
Console.WriteLine("Введите количество строк Массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов Массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int m1, int n1)
{
    int[,] array = new int[m1, n1];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(0, 5 + 1);
    }
    return array;
}
void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 4},");
            else Console.Write($"{array[i, j], 4} ");
        }
        Console.WriteLine("]");
    }
}
int[,] DoubleArray (int[,] arraydouble)
{
        for (int i = 0; i < arraydouble.GetLength(0); i+=2) 
            {
        for (int j = 0; j < arraydouble.GetLength(1); j+=2)
            // if (i%2==0 && j%2==0) 
            arraydouble[i,j]*=arraydouble[i,j];
    }
    return arraydouble;
}

int[,] rez = CreateArray(m, n);
Print(rez);
Console.WriteLine("новый");
int [,] doublearr = DoubleArray(rez);
Print(doublearr);
