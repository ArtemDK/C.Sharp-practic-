// Найдите произведение пар чисел в массиве. Парой считаем первый и последний элемент массива и тд...
// результат запишите в новом массиве.
// [1,2,3,4,5] -> 5 8 3
// [6,7,3,6] -> 36 21

Console.Clear();

Console.Write("Введите число элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine("Число элементов не натуральное");
    return;
}
// ---------------------------------------------------
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
// ---------------------------------------------------------------
int[] GetMults(int[] array)
{
    int size = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1; // Тернарный оператор, Если длина массива четная, то Size будет в два раза меньше, если не четное, то Zize будет в два раза меньше +1
    int[] rezult = new int[size];
    int firstindex = 0;
    int lastindex = array.Length - 1;
    int i = 0;

    while (lastindex > firstindex)
    {
        rezult[i] = array[firstindex] * array[lastindex];
        firstindex++;
        lastindex--;
        i++;
    }
    if (lastindex == firstindex)
    {
        rezult[size - 1] = array[lastindex];
    }
    return rezult;
}
// ------Второй Метод - через FOR---------------

// int[] NewArray(int[] array)
// {
//     int size = array.Length / 2;
//     if (array.Length % 2 != 0) size++;
//     int[] rezult = new int[size];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         rezult[i] = array[i] * array[array.Length - i - 1];
//     }
//     if (array.Length % 2 != 0) rezult[size - 1] = array[array.Length / 2];
//     return rezult;
// }
// -------------------------------------------
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
        if (i < array.Length - 1) Console.Write( array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}
// -----------------------------------------------
int[] arr = CreateArrayRndInt(num, 0, 9);
PrintArr(arr);
int[] multarray = GetMults(arr);
Console.Write(" -> ");
PrintArr(multarray);



