﻿// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

void Day(int number)
{
    if (number >= 1 && number <= 5)
        Console.WriteLine("Нет");

    if (number == 6 || number == 7)
        Console.WriteLine("Да");

    if (number < 1 || number > 7)
        Console.WriteLine("Некорректное число");
}

Day(num);

