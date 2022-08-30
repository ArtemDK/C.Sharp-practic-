// Задайте 2х мерный массив найдите сумму элементов находящихся на главной диагонали (0.0) (1.1) ...


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
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],4},");
            else Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}
void SummDiagArray(int[,] arraydiag)
{
    int summ = 0;
    for (int i = 0; i < arraydiag.GetLength(0); i++)
    {
        for (int j = 0; j < arraydiag.GetLength(1); j++)
        {
            if (i == j)
            {
                Console.Write(arraydiag[i, j] + "+");
                summ = summ + arraydiag[i, j];
            }
        }
    }
    Console.Write($"={summ}");
}
int[,] rez = CreateArray(m, n);
Print(rez);
SummDiagArray(rez);
