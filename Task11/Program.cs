// напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456-46
// 782-72
// 918-98


int number = new Random().Next(100, 1000);
Console.WriteLine($"cлучайное число -> {number}");

int First(int num)
{
    int firstdigit = num / 100;
    return firstdigit;
}
int Third(int num)
{
    int thirddigit = num % 100;
    return thirddigit;
}

int result1 = First(number);
int result2 = Third(number);
Console.WriteLine($"Число -> {number} без средней цифры -> {result1} {result2}");