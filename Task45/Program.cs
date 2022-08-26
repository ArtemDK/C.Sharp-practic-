// которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();
Console.WriteLine("Введите количество эементов Массива: ");
int qty = Convert.ToInt32(Console.ReadLine());
if (qty <= 0)
{
    Console.WriteLine("Количество элементов должно быть больше нуля");
    return;
}
int[] create = CreateArray(qty, 0, 10);
Print(create);
Console.Write(" -> ");
Copy(create);
Print(create);


int[] CreateArray(int size, int min, int max)
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
void Print(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}
int[] Copy(int[] array)
{
    int size = array.Length;
    int[] copyarray = new int[size];
    for (int i = 0; i < size; i++) copyarray[i] = array[i];

    return copyarray;
}