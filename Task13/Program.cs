// Напишите программу, которая принимает на вход число и проверяет:
// кратно оно одновременно 7 и 23
// 14 - нет
// 46 - нет
// 161 - да


Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

bool Proverka(int dig, int a, int b)
{
return dig % a == 0 && dig % b == 0;
}
if (Proverka (num, 7, 23)) Console.WriteLine("да");
else Console.WriteLine("нет");

 

// int dig1 = 7;
// int dig2 = 23;

// int del1 = num % dig1;
// int del2 = num % dig2;

// if (del1 == 0 && del2 == 0) Console.WriteLine("да");
// else
// {
//     Console.WriteLine("нет");
// }