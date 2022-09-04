// Задача 59: Задайтедвумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

Console.Clear();
Console.WriteLine("Введите количество строк Массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов Массива: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] res = CreateArray(m, n);
Print(res);
Console.WriteLine();
int[] findminElement = FindminElement(res);
int[,] rearray = Rearray(res, m, n, findminElement);
Print(rearray);

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
int[] FindminElement(int[,] array)
{
    int minrow = 0;
    int mincol = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; i < array.GetLength(1); i++)
        {
            if (array[i, j] < min)
                minrow = i;
            mincol = j;
        }
    }
    int[] min = new int[2] { minrow, mincol };
    return min;
}
int[] Rearray(int[,] array, int row, int col, int[] minindexarray)
{
    int[,] rearray = new int[row - 1, col - 1];
    for (int i = 0; i < array.GetLength(0); i++)
        if (i == minindexarray[0]) i++;
        else
        {
            for (int j = 0; i < array.GetLength(1); i++)
            {
                if (j == minindexarray[0]) j++;
                else
                {
                    rearray[i, j] = array[i, j];
                }
            }
        }
    return rearray;
}
