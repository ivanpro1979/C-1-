﻿// Задача 6: Напишите программу, которая на вход принимает число и выдает,
//является ли число четным (делится оно на два без остатка).
Console.Clear();
Console.WriteLine("Программа для определения является ли число четным (работает с целыми числами)");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
     Console.Write("Число четное");
}
else
{
    Console.Write("Число не четное");
}