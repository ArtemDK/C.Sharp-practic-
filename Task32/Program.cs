// Напишите программу замена элементов массива: положительные элементы заменить на соответсвующие отрицательные, и наоорот
// [-4,-8,8,-2]->[4,8,-8,-2]


Console.Clear();
int[] CreateArrayRndInt(int size, int min, int max)
// --------------------------------
{
    int[] array = new int[size];
    Random rnd = new Random();
    {
        for (int i = 0; i < size; i++)
            array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
// --------------------------------
int[] Zamena(int[] array)
{
    {
        for (int i = 0; i < array.Length; i++) 
        array[i] = -array[i];
    }
    return array;
}
// --------------------------------
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
// ---------------------
int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArr(arr);
Zamena(arr);
PrintArr(arr);
