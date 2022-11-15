// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = OutputThreeDigit(number);
    Console.WriteLine(result);
}
else Console.WriteLine($"Введённое число {number} не является трёхзначным");


int OutputThreeDigit(int num)
{
    int res = (num % 100) / 10;
    return res;
}

