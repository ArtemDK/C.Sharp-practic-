// Напишите программу которая определяет, присутсвует ли заданное число в массиве
// 4. - массив [6,7,19,345,3] -> нет
// 3. - массив [6,7,19,345,3] -> да

Console.Clear();
Console.WriteLine("Введите згачение числа для поиска:");
int dig = Convert.ToInt32(Console.ReadLine());
// --------------------------------------------------------
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
// ------------------------------------------------------------
int[] Find(int[] array, int dig1)
{
    int count = 0;
    {
        for (int i = 0; i < array.Length; i++)
            if (array[i] == dig1) count++;
    }
    if (count > 0) Console.WriteLine($"Значения {dig1} в массиве есть");
    else Console.WriteLine($"Значения {dig1} в массиве нет");
return array;
}
// ----------------------------------------------------------------
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
// -------------------------------------------------------------
int[] arr = CreateArrayRndInt(12, 0, 9);
PrintArr(arr);
Find(arr, dig);