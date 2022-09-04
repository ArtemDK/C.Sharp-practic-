// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

Console.Clear();
Console.WriteLine("Введите количество строк Массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов Массива: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m != n)
{
    Console.WriteLine("Количество строк и столбцов массива должно совпадать");
    return;
}

int[,] create = CreateArray(m, n);
Print(create);
Console.WriteLine();
int[,] result = Changeline(create);
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
int[,] reverse = new int[m,n];

    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++) 
        {
        reverse[i,j] = array [j,i];
        }
    
    }
        return reverse;
}