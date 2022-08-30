// задайте двумерный массив размерами M на N. Запишиите его случайными числами.


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
            array[i, j] = rnd.Next(0, 99 + 1);
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
int[,] rez = CreateArray(m, n);
Print(rez);


