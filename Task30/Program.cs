// Напишите программу, которая выводит массив из 8 элементов и заполняет его нулями и единицами в случайном порядке.
Console.Clear();

int[] CreateArray(int n, int min, int max) //Метод для набора массива
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

// void PrintArr(int[] array) // Метод для вывода массива #1
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i == 0) Console.Write("[");
//         if (i > 0 && i < array.Length - 1) Console.Write(array[i] + ",");
//         else Console.Write(array[i] + "]");
//     }
// }
void PrintArr(int[] array) // Метод для вывода массива #2
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int[] result = CreateArray(8, 0, 2);
PrintArr(result);