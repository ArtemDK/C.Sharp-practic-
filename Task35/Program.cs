// // Задайте одномерный массив из 123 случайных чисел.
// Найдите количесво элементов массива, значения элементов которых лежат в отрезке [10,99].

Console.Clear();
int[] CreateArrayRndInt(int size, int min, int max)
{
    if (size == 0)
        return new int[] { };

    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArr(int[] array)
{
    if (array == null || array.Length <= 0)
    {
        Console.WriteLine("массив пуст");
        return;
    }
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int Find(int[] array,int min, int max)
{
    if (array == null || array.Length <= 0)
    {
        return 0;
    }
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max) count++;
    }
    return count;
}

int[] arr = CreateArrayRndInt(123, 0, 99);
PrintArr(arr);
int rez = Find(arr,10,99);
Console.WriteLine($"В массиве - {rez} значений лежащих в отрезке [10,99]");