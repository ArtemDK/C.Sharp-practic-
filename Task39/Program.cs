// Напишите программу, которая перевернет одномерный массив.
// последний элемент будет на первом месте, а первый на последнем.


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
Array.Reverse(create);
// Reload1(create);
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

//Array.Reverse(arr) - Метод реверзии массива
// void Reload(int[] array)
// {
//     int size = array.Length;
//     int index1 = 0;
//     int index2 = size - 1;

//     while (index1 < index2)
//     {
//         int obj = array[index1];
//         array[index1] = array[index2];
//         array[index2] = obj;
//         index1++;
//         index2--;
//     }
// }
// void Reload1(int[] array) // Метод через For
// {
//     int size = array.Length;
//     for (int i = 0; i < size/2; i++)
//     {
//         int obj = array[i];
//         array[i] = array[size - 1 - i];
//         array[size - 1 - i] = obj;

//     }
// }