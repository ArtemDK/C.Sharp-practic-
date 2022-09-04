// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.
Console.Clear();
int[,] rez = CreateArray(5, 6);
Print(rez);
Console.WriteLine();
int[,] result = Changeline(rez);
Print(result);

int[,] CreateArray(int m1, int n1)
{
    int[,] array = new int[m1, n1];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = rnd.Next(0, 10 + 1);
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
int[,] Changeline(int[,] array)
{
    int j = 0;
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < col; i++)
    {
        int dig = array[j, i];
        array[j, i] = array[row - 1, i];
        array[row - 1, i] = dig;
    }
    return array;
}
