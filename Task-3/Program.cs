// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 7 && number >= 1)
{
    bool result = DayOfTheWeek(number);
    Console.WriteLine(result ? "Да" : "Нет");
}
else Console.WriteLine("Такой цифры дня недели нет");


bool DayOfTheWeek(int day)
{
    return day == 6 || day == 7;
}