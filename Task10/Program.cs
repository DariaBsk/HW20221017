// Задача 10: Напишите программу, которая принимает
//  на вход трёхзначное число 
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите целое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int first = num / 100;
int third = num % 10;
int second = (num-first*100-third)/10;


Console.WriteLine(second);