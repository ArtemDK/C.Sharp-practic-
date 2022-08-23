// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]
// Найдите сумму отрициательных и положительных элементов массива.
Console.Clear();
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    {
        for (int i = 0; i < size; i++)
            array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
// ---------------------------------------------------------------------
int[] GetSumPos(int[] array)
{
    int otr = 0;
    int pol = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) otr += array[i];
        else pol += array[i];
    }
    return new int[] {otr, pol};
}
// ---------------------------------------------------------------
void PrintArr(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
        Console.WriteLine("]");
}
// ----------------------------------------------------------------
int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArr(arr);
int[] sumpos = GetSumPos(arr);
Console.WriteLine($"Cумма отрицательныъ элементов = {sumpos[0]}");
Console.WriteLine($"Cумма положительных элементов = {sumpos[1]}");