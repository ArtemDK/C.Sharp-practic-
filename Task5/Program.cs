﻿// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа. 
// 456 -> 6 
// 782 -> 2 
// 918 -> 8

Console.Write("введите трехнзаначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int rez = num % 10;
Console.Write($"последняя цифра: {rez}");