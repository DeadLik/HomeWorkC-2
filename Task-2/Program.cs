// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (TheThirdDigit(number) == 0) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine($"Третья цифра в {number} -> {TheThirdDigit(number)}");


int TheThirdDigit(int num)
{
    int res = 0;
    if (num >= 100)
    {
        while (num > 999)
        {
            num /= 10;
        }
        res = num % 10;
    }
    return res;
}