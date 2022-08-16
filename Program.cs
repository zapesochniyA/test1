// **Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100,1000);
string secondNumber = number.ToString();
Console.WriteLine($"{secondNumber[1]}");




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите любое число: ");
string? inputNumber = Console.ReadLine();
if (inputNumber?.Length >= 3) Console.WriteLine("Третья цифра введенного числа " + inputNumber[2]);
else Console.WriteLine("третьей цифры нет ");

 


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру: ");
int numberOfWeek = Convert.ToInt32(Console.ReadLine());
if (numberOfWeek == 1) Console.WriteLine("нет");
else if (numberOfWeek == 2) Console.WriteLine("нет");
else if (numberOfWeek == 3) Console.WriteLine("нет");
else if (numberOfWeek == 4) Console.WriteLine("нет");
else if (numberOfWeek == 5) Console.WriteLine("нет");
else if (numberOfWeek == 6) Console.WriteLine("да");
else if (numberOfWeek == 7) Console.WriteLine("да");
else Console.WriteLine("ошибка, такого дня недели не существует ");
