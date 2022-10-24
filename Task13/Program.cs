// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int Value(int number)
{
   
    if (number >= 100)
    {
        while (number > 999)
        {
            number /= 10;
        }
        return number % 10;
    }
    return -1;
}

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = Value(Math.Abs(num));

if(result == -1)
{
    Console.WriteLine($"В числе {num} третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра числа {num} равна {result}");
}




