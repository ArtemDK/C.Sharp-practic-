// // Напишите программу, которая выводит случайное число из отрезка (10,99) и показывает наибольшую цифру числа.
// 78->8
// 12-2
// 85-8

int number = new Random().Next(10, 100);
Console.WriteLine($"cлучайное число -> {number}");

// int firstdigit = number / 10;
// int seconddigit = number % 10;

// // if (firstdigit == seconddigit) Console.WriteLine($"Цифры в числе {number} одинаковые");
// // else if (firstdigit > seconddigit) Console.WriteLine($"Наибольшая цифра -> {firstdigit}");
// // else Console.WriteLine($"Наибольшая цифра -> {seconddigit}");

// int result = firstdigit > seconddigit ? firstdigit : seconddigit;

int MaxDigit(int num)
{
    int firstdigit = num / 10;
    int seconddigit = num % 10;
    if (firstdigit == seconddigit) return - 1;
    return firstdigit > seconddigit ? firstdigit : seconddigit;
} 
int result = MaxDigit(number);
string res = result == -1 ? "Цифры одинаковые" : result.ToString();