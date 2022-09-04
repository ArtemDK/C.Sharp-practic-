// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// Набор данных Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 } 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Clear();
int[,] res = CreateArray(3, 3);
Print(res);
Console.WriteLine();
int[] result = Singlearray(res);
Print1(result);
PodchetElementov(result);

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
void Print1(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}
int[] Singlearray(int[,] array)
{
    int element = 0;
    int[] single = new int[array.Length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            single[element] = array[i, j];
            element++;
        }
    }
    Array.Sort(single); // сортировка по возрастанию
    return single;
}
void PodchetElementov(int[] array)
{
    int summ = 1;
    int element = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == element) summ++;
        else
        {
            Console.WriteLine($"Число Элементов {element} в массиве -> {summ}");
            element = array[i];
            summ = 1;
        }
        if (i == array.Length - 1) Console.WriteLine($"Число Элементов {element} в массиве -> {summ}");
    }
}